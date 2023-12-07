using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
int rows, cols;
// Запрашиваем у пользователя число строк и столбцов
Console.WriteLine("Введите количество строк:");
if (!int.TryParse(Console.ReadLine(), out rows))
{
    Console.WriteLine("Некорректные данные.");
    return;
}

Console.WriteLine("Введите количество столбцов:");
if (!int.TryParse(Console.ReadLine(), out cols))
{
    Console.WriteLine("Некорректные данные.");
    return;
}
// Создается массив и заполняется рандомными числами
int[,] matrix = new int[rows, cols];
Random random = new Random();
// Вывод матрицы
Console.WriteLine("Матрица создана!");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = random.Next(1, 101);  // Случайные целые числа от 1 до 100
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
// Подсчет чисел в матрице
int sum = 0;
foreach (int num in matrix)
{
    sum += num;
}
Console.WriteLine($"Сумма всех элементов матрицы: {sum}");
Console.ReadKey();
        }
    }
}
