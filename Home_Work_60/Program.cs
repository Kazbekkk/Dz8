/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */
Console.Clear();

Random r = new Random();


int line, column, post;

Console.WriteLine("Данная программа выводит трёхмерный массив с индексами из неповторяющихся двузначных чисел.");
Console.WriteLine("Введите значения ниже.");

Console.Write("Количесвто строк массива:");
line = int.Parse(Console.ReadLine());

Console.Write("Количесвто столбцов:");
column = int.Parse(Console.ReadLine());

Console.Write("Количесвто столбиков:");
post = int.Parse(Console.ReadLine());

int[,,] array = Array(line, column, post);


int[,,] Array(int lineArr, int columnArr, int postArr)
{
    int[,,] array = new int[lineArr, columnArr, postArr];
    int num = 10;
    for (int i = 0; i < array.GetLength(0); i++) // строки
    {
        for (int o = 0; o < array.GetLength(1); o++) // столбцы
        {
            for (int p = 0; p < array.GetLength(2); p++) // столбики
            {
                array[i, o, p] += num;
                num += 1;
                Console.Write($"[{String.Join(", ", array[i,o,p])}]({i}, {o}, {p} ) ");
            }
            Console.WriteLine(" ");
        }
    }
    return array;
}
