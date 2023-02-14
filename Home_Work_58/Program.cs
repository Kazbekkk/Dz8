/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */
Console.Clear();

Random r = new Random();

int lineOne, columnOne, lineTwo, columnTwo;

Console.WriteLine("Введите значения ниже чтобы заполнить двумерный массив для нахождения произведения двух матриц.");
Console.Write("Введите количесвто строк первого массива: ");
lineOne = int.Parse(Console.ReadLine());

Console.Write("Введите количесвто столбцов первого массива: ");
columnOne = int.Parse(Console.ReadLine());

Console.Write("Введите количесвто строк второго массива: ");
lineTwo = int.Parse(Console.ReadLine());

Console.Write("Введите количесвто столбцов второго массива: ");
columnTwo = int.Parse(Console.ReadLine());



if (columnOne == lineTwo)
{

    int[,] arrayOne = Array(lineOne, columnOne);
    Console.WriteLine();
    int[,] arrayTwo = Array(lineTwo, columnTwo);

    int[,] Array(int lineArr, int columnArr)
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

    void MatrixSumm()
    {

        int[,] matrix = new int[lineOne, columnTwo];
        for (int i = 0; i < matrix.GetLength(0); i++)
        // строки матрицы 1 2 
        //                * *
        {
            for (int l = 0; l < matrix.GetLength(1); l++)
            // столбцы 1 *
            //         2 * 
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                // сложение 1 2  +  1 * = 1 * 1 + 2 * 2 *   =  5 *
                //          * *     2 *         *       *      * *
                // значение k в arrayOne[i,k] меняет столбец первого массива, а в arrayTwo[k,l] меняет строку 
                {
                    matrix[i, l] += (arrayOne[i, k] * arrayTwo[k, l]);
                }
                Console.Write($"[{String.Join(", ", matrix[i, l])}]");
            }
            Console.WriteLine();
        }


    }

    Console.WriteLine();
    Console.WriteLine("Произведение матрицы:");
    MatrixSumm();
}
else { Console.WriteLine("Ошибка! Число столбцов первой матрицы не совпадает с числом строк второй матрицы!!! "); }