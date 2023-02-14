/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */
Console.Clear();

int line, column;

Console.WriteLine("Программа заполняет массив спирально.");
line = 4;
column = 4;

int[,] array = Array(line, column);

int[,] Array(int lineArr, int columnArr)
{
    int[,] array = new int[lineArr, columnArr];
    int num = 0;
    for (int i = 0; i < 6; i++)
    {
        if (i == 0)
        {
            for (int o = 0; o < 4; o++)
            {
                num += 1;
                array[i,o] = num;
            }
        }
        else if (i == 1)
        {
            for (int p = 1; p < 4; p++)
            {
                num += 1;
                array[p,3] = num;
            }
        }
        else if (i == 2)
        {
            for (int u = 2; u > 0; u--)
            {
                int s = 3;
                num += 1;
                array[s,u] = num;
            }
        }
        else if (i == 3)
        {
            for (int y = 3; y > 0; y--)
            {
                num += 1;
                array[y,0] = num;
            }
        }
        else if (i == 4)
        {
            for (int t = 1; t < 3; t++)
            {
                num += 1;
                array[1,t] = num;
            }
        }
        else if (i == 5)
        {
            for (int r = 2; r > 0; r--)
            {
                num += 1;
                array[2,r] = num;
            }
        }
        
    }
    return array;
}

void Sad()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            Console.Write($"[{String.Join(", ", array[i,k])}]");
        }
        Console.WriteLine();
    }
}

Sad();