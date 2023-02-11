/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */
Console.Clear();


Random r = new Random();

int lines, column;

Console.WriteLine("Задайте размер двумерного массива.");
Console.Write("Укажите количесвто строк в массиве: ");
lines = int.Parse(Console.ReadLine());

Console.Write("Укажите количесвто столбцов в массиве: ");
column = int.Parse(Console.ReadLine());

int[,] array = Array(lines, column);


int[,] Array(int linesArr, int columnArr)
{
    int[,] array = new int[linesArr, columnArr];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = r.Next(-10, 10 + 1);
            Console.Write($"[{String.Join(", ", array[i, j])}]");
        }
        Console.WriteLine();
    }

    return array;
}

void Sorting()
{
    for (int i = 0; i < array.GetLength(0); i++) // строки
    {

        for (int r = 0; r < array.GetLength(1); r++) // столбцы
        {

            for (int d = 0; d < array.GetLength(1); d++) // цикл с повторение проверки
            {
                for (int j = 0; j < array.GetLength(1) - 1; j++) // цикл с проверкой стобцов 
                {

                    if (array[i, j] < array[i, j + 1])
                    {
                        int temporary = array[i, j + 1];
                        array[i, j + 1] = array[i, j];
                        array[i, j] = temporary;

                    }


                }
            }
            Console.Write($"[{String.Join(", ", array[i, r])}]");
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}



Console.WriteLine("Масиив упорядочен по убыванию пузырьковым методом: ");
Sorting();