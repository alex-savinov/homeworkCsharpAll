using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace exercises
{
    internal class Universal
    {
        //Функция Аккермана
        static public ulong Akkermana(ulong value1, ulong value2)
        {
        
                if (value1 == 0) return value2 + 1;
                else if ((value1 != 0) && (value2 == 0)) return Akkermana(value1 - 1, 1);
                else return Akkermana(value1 - 1, Akkermana(value1, value2 - 1));
            
         
        }
        //Подсчет количества четных элементов в массиве
        static public int CountEvenElementArray(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) count++;
            }
            return count;
        }
        //Функция находит строку с наименьшей суммой элементов
        static public int MinSumElementRow(int[,] array)
        {
            int[] sumElementRow = new int[array.GetLength(0)];
            int min = int.MaxValue;
            int index = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sumElementRow[i] += array[i, j];
                }
                if (min > sumElementRow[i])
                {
                    min = sumElementRow[i];
                    index = i;
                }
            }
            return (index + 1);
        }
        //Генерация двузначных не повторяющихся элементов
        static public int NoRepeatRandom(ref int[] array)
        {

            Random rnd = new Random();
            int buffer = array[rnd.Next(0, array.Length)];
            array = array.Where(value => value != buffer).ToArray();

            return buffer;
        }
        //Получаем данные из строки и конвертируем в тип данных int 
        static public int ReadInt(string value)
        {
            try
            {
                Console.Write(value);
                return (Convert.ToInt32(Console.ReadLine()));
            }
            catch { return 0; }
        }
        //Получаем данные из строки и конвертируем в тип данных int
        static public ulong Readulong(string value)
        {
            try
            {
                Console.Write(value);
                return (Convert.ToUInt64(Console.ReadLine()));
            }
            catch { return 0; }
        }
        //Сумма натуральных чисел в промежутке от N к M
        static public int SumNumbers(int M, int N)
        {
            if (M > N) return 0;
            return M + SumNumbers(M + 1, N);
        }
        //Получаем данные из строки и конвертируем в тип данных double 
        static public double ReadDouble(string value)
        {
            try
            {
                Console.Write(value);
                return (Convert.ToDouble(Console.ReadLine()));
            }
            catch { return 0; }

        }
        //Считает сумму нечетных элементов
        static public int SumNoEvenElementArray(int[] array)
        {
            int sum = 0;
            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
            }
            return sum;
        }
        //Массив значений от 10 до 100
        static public int[] BufferArray()
        {
            int[] array = new int[90];
            array[0] = 10;
            for (int i = 1; i < array.Length; i++)
            {
                array[i] = array[i - 1] + 1;
            }
            return array;
        }
        //Считываем строку в массив 
        static public int[] ReadLineToArray(string value)
        {
            try
            {
                Console.WriteLine(value);
                int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
                return array;
            }
            catch
            {
                int[] array = { 0 };
                return array;
            }

        }
        //Генерируем целочисленный массив из случайных чисел в заданном диапазоне
        static public int[] FillRandomIntArray(int length, int min, int max)
        {
            int[] array = new int[length];
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                array[i] = rnd.Next(min, max + 1);
            }
            return array;
        }
        //Получаем координаты точки в трехмерном пространстве
        static public double[] Coordinate(string value)
        {
            try
            {
                Console.WriteLine(value);
                string userInput = Console.ReadLine() ?? "";
                userInput = userInput.Replace(" ", "");
                return (userInput.Split(',').Select(element => double.Parse(element)).ToArray());
            }
            catch
            {
                double[] array = { 0, 0, 0 };
                return (array);
            }
        }
        //Генерируем double массив из случайных чисел в заданном диапазоне
        static public double[] FillRandomDoubleArray(int length, double min, double max)
        {
            double[] array = new double[length];
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                array[i] = Math.Round(min + rand.NextDouble() * (max - min), 2);

            }
            return array;
        }
        //Пересечение прямых
        static public double[] IntersectionLines(double k1, double k2, double b1, double b2)
        {
            double[] answer = new double[2];
            answer[0] = Math.Round((b2 - b1) / (k1 - k2), 2);
            answer[1] = Math.Round((k1 * answer[0] + b1), 2);
            return answer;
        }
        //Функция произведения матриц
        static public int[,] CompositionMatrix(int[,] array1, int[,] array2)
        {
            int[,] resultArray = new int[array1.GetLength(0), array2.GetLength(1)];

            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    for (int k = 0; k < array2.GetLength(0); k++)
                    {
                        resultArray[i, j] += array1[i, k] * array2[k, j];
                    }
                }

            }
            return resultArray;

        }
        //Заполняем  трехмерную матрицу по условию 60 задачи 
        static public int[,,] FillMatrixForTask60(int x, int y, int z, ref int[] buffer)
        {
            int[,,] tempMatrix = new int[x, y, z];

            for (int i = 0; i < tempMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < tempMatrix.GetLength(1); j++)
                {
                    for (int k = 0; k < tempMatrix.GetLength(2); k++)
                    {
                        tempMatrix[i, j, k] = NoRepeatRandom(ref buffer);
                    }
                }
            }
            return tempMatrix;
        }
        //Создает новый двумерный массив с заданным количеством элементов сгенирированных случайным образом в заданном диапазоне
        static public int[,] FillRandomIntMatrix(int row, int col, int min, int max)
        {
            int[,] array = new int[row, col];
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(min, max + 1);
                }
            }
            return array;
        }
        //Генерация двумерного массива со случайными вещественными числами
        static public double[,] FillRandomDoubleMatrix(int row, int col, double min = -10, double max = 10)
        {
            double[,] array = new double[row, col];
            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Math.Round(min + rand.NextDouble() * (max - min), 2);
                }
            }
            return array;
        }
        //Пузырьковая сортировка 
        static public void BubbleSortForIntMatrix(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(1) - 1; k++)
                    {
                        if (array[i, k] < array[i, k + 1])
                        {
                            int temp = array[i, k];
                            array[i, k] = array[i, k + 1];
                            array[i, k + 1] = temp;
                        }
                    }
                }
            }
        }
        // Спиральное заполнение массива 
        static public void FillSpiralArray(ref int[,] array, int value1, int value2)
        {
            int step = 0;
            int countValue = 0;
            while (value1 > 0 && value2 > 0)
            {

                for (int i = 0; i < value2; i++)
                {
                    countValue++;
                    array[0 + step, i + step] = countValue;
                }
                if (value1 > 1)
                {
                    for (int i = 0; i < value1 - 1; i++)
                    {
                        countValue++;
                        array[1 + i + step, value2 - 1 + step] = countValue;
                    }
                    if (value2 > 1)
                    {
                        for (int i = 0; i < value2 - 1; i++)
                        {
                            countValue++;
                            array[value1 - 1 + step, value2 - 2 - i + step] = countValue;
                        }
                        for (int i = 0; i < value1 - 2; i++)
                        {
                            countValue++;
                            array[value1 - 2 - i + step, 0 + step] = countValue;
                        }
                    }

                }
                value2 -= 2;
                value1 -= 2;
                step++;
            }
        }
        //Печать двумерного массива int
        static public void PrintIntMatrix(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
        //Печать двумерного массива double
        static public void PrintDoubleMatrix(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
        //Выводим  трехмерную матрицу по условию 60 задачи 
        static public void PrintMatrixForTask60(int[,,] matrixForPrint)

        {
            for (int k = 0; k < matrixForPrint.GetLength(2); k++)
            {
                for (int i = 0; i < matrixForPrint.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixForPrint.GetLength(1); j++)
                    {
                        System.Console.Write($"{matrixForPrint[i, j, k]}({i},{j},{k}) ");

                    }
                    System.Console.WriteLine();
                }

            }
        }
        //Выводим матрицу по условию 62 задачи 
        static public void PrintMatrixForTask62(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > 9) Console.Write(array[i, j] + "\t");
                    else Console.Write($"0{array[i, j]}" + "\t");
                }
                Console.WriteLine();
            }

        }


    }
}
