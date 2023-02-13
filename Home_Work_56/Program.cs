/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

Console.Clear();
Random r = new Random();

int line, column;

Console.WriteLine("Введите параметры ниже для заполнения двумерного массива.");

Console.Write("Введите количесвто строк: ");
line = int.Parse(Console.ReadLine());

Console.Write("Введите количесвто столбцов: ");
column = int.Parse(Console.ReadLine());

int[,] array = Array(line, column);

int[,] Array(int lineArr, int columnArr) // рандомный массив
{
    int[,] array = new int[lineArr, columnArr];
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

void MinSummLine() // нахождение строки с наименьшей суммой элементов 
{
    
    int[] summArray = new int[column];
    for (int j = 0; j < array.GetLength(0); j++) // складывание чисел и добавление результата в одномерный массив
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            summArray[j] += array[j, k];
        }
        /* Console.WriteLine(summArray[j]); */ // проверка сложения чисел
    }


    int minSumm = summArray[0]; // поиск строки с минимальной суммой чисел
    int index = 0;
    for (int k = 0; k < summArray.Length; k++)
    {
        for (int i = 0; i < summArray.Length; i++)
        {
            if (summArray[i] < minSumm)
            {
                minSumm = summArray[i];
                index = i;
            }
        }
    }

    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {index + 1} строка");

}


Console.WriteLine();
MinSummLine();
