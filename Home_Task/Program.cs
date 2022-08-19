using System;

namespace Home_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            void Zadacha47()
            {
                // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
                // m = 3, n = 4.

                Random random = new Random();
                int rows = random.Next(4, 8);
                int columns = random.Next(4, 8);
                double[,] array = new double[rows, columns];
                FillArray(array);
                PrintArray(array);
            }


            void Zadacha50()
            {
                // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
                // и возвращает значение этого элемента или же указание, что такого элемента нет.

                Random random = new Random();
                int rows = random.Next(4, 8);
                int columns = random.Next(4, 8);
                int[,] array = new int[rows, columns];
                FillArray(array);
                PrintArray(array);

                Console.WriteLine("Введите номер сроки ");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите номер стобца ");
                int column = Convert.ToInt32(Console.ReadLine());

                if (row <= rows && row > 0 && column <= columns && column > 0)
                {
                    Console.WriteLine($"Выбранный элемент {array[row, column]}");
                }
                else
                {
                    Console.WriteLine("Элемента не существует ");
                }
            }



            void Zadacha52()
            {
                // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

                Random random = new Random();
                int rows = 4;
                int columns = 8;
                int[,] array = new int[rows, columns];
                FillArray(array, 0, 10);
                PrintArray(array);
                Console.WriteLine();
                for (int j = 0; j < columns; j++)
                {
                    double sum = 0;
                    for (int i = 0; i < rows; i++)
                    {
                        sum += array[i, j];
                    }
                    Console.Write(Math.Round(sum / rows, 2) + "\t");
                }

            }

            //Zadacha47();
            //Zadacha50();
            Zadacha52();
        }

        static void FillArray(int[,] array, int startNumber = 0, int finishNumber = 9)
        {
            Random random = new Random();
            finishNumber++;
            int rows = array.GetLength(0); // строки (0)
            int colums = array.GetLength(1); // столбцы (1)

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    array[i, j] = random.Next(startNumber, finishNumber);
                }
            }
        }

        static void FillArray(double[,] array)
        {

            int rows = array.GetLength(0); // строки (0)
            int colums = array.GetLength(1); // столбцы (1)
            Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    array[i, j] = Math.Round(random.NextDouble() * 10 - 5, 2);
                }
            }
        }

        static void PrintArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void PrintArray(double[,] array)
        {
            int rows = array.GetLength(0); // строки (0)
            int colums = array.GetLength(1); // столбцы (1)

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
