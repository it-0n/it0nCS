using System;
using System.Threading;
using System.Collections.Generic;

class SpaceGame
{
    static int width, height;
    static int shipX;
    static List<int[]> bullets = new List<int[]>();
    static List<int[]> meteors = new List<int[]>();
    static int meteorsDestroyed = 0;
    static int totalMeteors = 100;
    static char[,] field;
    static bool gameOver = false;
    static bool shipDestroyed = false;
    static List<int[]> explosions = new List<int[]>();
    static int shipExplosionStep = 0;
    static int meteorFallSpeed = 0;
    static HashSet<int> destroyedShieldPositions = new HashSet<int>();

    static void Main()
    {
        Clear();
        CursorVisible = false;

        width = WindowWidth;
        height = WindowHeight - 1;
        shipX = width / 2;

        field = new char[height, width];

        Thread inputThread = new Thread(ReadInput);
        inputThread.Start();

        while (!gameOver)
        {
            UpdateGame();
            DrawGame();
            Thread.Sleep(200);
        }

        SetCursorPosition(0, height / 2);
        WriteLine(shipDestroyed ? "Игра окончена!" : "Вы победили!");
    }

    static void ReadInput()
    {
        while (!gameOver && !shipDestroyed)
        {
            if (KeyAvailable)
            {
                ConsoleKeyInfo key = ReadKey(true);
                if (key.Key == ConsoleKey.LeftArrow && shipX > 1) shipX--;
                if (key.Key == ConsoleKey.RightArrow && shipX < width - 5) shipX++;
                if (key.Key == ConsoleKey.Spacebar) bullets.Add(new int[] { height - 3, shipX + 2 });
            }
        }
    }

    static void UpdateGame()
    {
        for (int y = 0; y < height; y++)
            for (int x = 0; x < width; x++)
                field[y, x] = ' ';

        if (!shipDestroyed && meteors.Count < totalMeteors && new Random().Next(0, 10) == 0)
        {
            int meteorX = new Random().Next(2, width - 2);
            meteors.Add(new int[] { 0, meteorX });
        }

        meteorFallSpeed++;
        if (meteorFallSpeed % 2 == 0)
        {
            for (int i = meteors.Count - 1; i >= 0; i--)
            {
                meteors[i][0]++;
                if (meteors[i][0] >= height - 2)
                {
                    destroyedShieldPositions.Add(meteors[i][1]);
                    meteors.RemoveAt(i);
                }
            }
        }

        for (int i = bullets.Count - 1; i >= 0; i--)
        {
            bullets[i][0]--;
            if (bullets[i][0] < 0) bullets.RemoveAt(i);
        }

        for (int i = meteors.Count - 1; i >= 0; i--)
        {
            for (int j = bullets.Count - 1; j >= 0; j--)
            {
                if (meteors[i][0] == bullets[j][0] && meteors[i][1] == bullets[j][1])
                {
                    explosions.Add(new int[] { meteors[i][0], meteors[i][1], 0 });
                    meteors.RemoveAt(i);
                    bullets.RemoveAt(j);
                    meteorsDestroyed++;
                    break;
                }
            }
        }

        for (int i = explosions.Count - 1; i >= 0; i--)
        {
            explosions[i][2]++;
            if (explosions[i][2] > 2) explosions.RemoveAt(i);
        }

        foreach (var meteor in meteors)
        {
            if (meteor[0] == height - 3 && (meteor[1] >= shipX && meteor[1] <= shipX + 4))
            {
                shipDestroyed = true;
                return;
            }
        }

        foreach (var meteor in meteors)
        {
            if (meteor[0] == height - 2)
                destroyedShieldPositions.Add(meteor[1]);
        }

        if (!shipDestroyed && meteorsDestroyed >= totalMeteors)
        {
            bool hasShieldLeft = false;
            for (int x = 0; x < width; x++)
            {
                if (!destroyedShieldPositions.Contains(x))
                {
                    hasShieldLeft = true;
                    break;
                }
            }

            if (hasShieldLeft)
            {
                gameOver = true;
                return;
            }
        }

        foreach (var meteor in meteors) field[meteor[0], meteor[1]] = '*';

        foreach (var bullet in bullets) field[bullet[0], bullet[1]] = '!';

        foreach (var explosion in explosions)
        {
            char explosionChar = explosion[2] switch
            {
                0 => 'o',
                1 => 'O',
                _ => '0',
            };
            field[explosion[0], explosion[1]] = explosionChar;
        }

        if (shipDestroyed)
        {
            if (shipExplosionStep < 4)
            {
                char[] explosionStages = { '_', '=', '+', '*' };
                for (int i = 0; i < 5; i++)
                    field[height - 3, shipX + i] = explosionStages[shipExplosionStep];
                shipExplosionStep++;
            }
            else
            {
                gameOver = true;
            }
        }
        else
        {
            int shipY = height - 3;
            field[shipY, shipX] = '<';
            field[shipY, shipX + 1] = '=';
            field[shipY, shipX + 2] = '!';
            field[shipY, shipX + 3] = '=';
            field[shipY, shipX + 4] = '>';
        }

        for (int x = 0; x < width; x++)
            field[height - 2, x] = destroyedShieldPositions.Contains(x) ? '+' : '=';

        string score = $"Сбитые метеориты: {meteorsDestroyed}/{totalMeteors}";
        for (int i = 0; i < score.Length && i < width; i++)
            field[height - 1, i] = score[i];
    }

    static void DrawGame()
    {
        SetCursorPosition(0, 0);
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
                Write(field[y, x]);
            WriteLine();
        }
    }
}
