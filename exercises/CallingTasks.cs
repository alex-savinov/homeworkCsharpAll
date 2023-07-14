using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    internal class CallingTasks
    {
        public void Task2()
        {
            int valueA = Universal.ReadInt("Введите первое число : ");
            int valueB = Universal.ReadInt("Введите второе число : ");
            Console.Write($"\r\na = {valueA}, b = {valueB} -> ");
            if (valueA > valueB) Console.Write("max = " + valueA);
            else Console.Write("max = " + valueB);
        }
        public void Task4()
        {
            int valueA = Universal.ReadInt("Введите первое число : ");
            int valueB = Universal.ReadInt("Введите второе число : ");
            int valueC = Universal.ReadInt("Введите третье число : ");
            Console.Write($"\r\n{valueA}, {valueB}, {valueC} -> ");
            valueA = (valueA < valueB) ? valueB : valueA;
            valueA = (valueA < valueC) ? valueC : valueA;
            Console.Write(valueA);
        }
        public void Task6()
        {
            int valueA = Universal.ReadInt("Введите число : ");
            Console.Write($"\r\n{valueA} -> ");
            if (valueA % 2 == 0) Console.Write("да");
            else Console.Write("нет");
        }
        public void Task8()
        {
            int value = Universal.ReadInt("Введите число: ");
            Console.Write($"\r\n{value} -> ");
            for (int i = 2; i <= value; i += 2)
            {
                Console.Write(i);
                if (i + 2 <= value) Console.Write(", ");
            }
            Console.WriteLine();
        }
        public void Task10()
        {
            int value = Universal.ReadInt("Введите трехзначное число: ");
            Console.Write($"\r\n{value} -> ");
            if ((value >= 100) && (value < 1000)) Console.WriteLine((value / 10) % 10);
            else Console.Write("Вы ввели не трехзначное число, попробуйте еще раз");
        }
        public void Task13()
        {
            int value = Universal.ReadInt("Введите трехзначное число: ");
            Console.Write($"\r\n{value} -> ");
            if (value < 100) Console.Write("третьей цифры нет");
            else
            {
                while (value >= 1000) value = value / 10;
                Console.Write(value % 10);
            }
        }
        public void Task15()
        {
            Console.WriteLine("Введите цифру от 1 до 7");
            var userInput = Console.ReadKey();
            if ((userInput.Key == ConsoleKey.D6) || (userInput.Key == ConsoleKey.D7))
            {
                Console.WriteLine(" -> да");
            }
            else if ((userInput.Key == ConsoleKey.D1) ||
                (userInput.Key == ConsoleKey.D2) ||
                (userInput.Key == ConsoleKey.D3) ||
                (userInput.Key == ConsoleKey.D4) ||
                (userInput.Key == ConsoleKey.D5))
            {
                Console.WriteLine(" -> нет");
            }
            else { Console.WriteLine("\r\nЦифра вне диапазона 1 - 7"); }
        }
        public void Task19()
        {
            int value = Universal.ReadInt("Введите пятизначное число: ");
            bool palindrome = false;
            int[] array = value.ToString().Select(element => Convert.ToInt32(element) - 48).ToArray();
            if (array.Length == 5)
            {
                for (int i = 0; i < (array.Length / 2); i++)
                {
                    if (array[i] != array[array.Length - i - 1])
                    {
                        Console.WriteLine($"\r\n{value} -> нет");
                        break;
                    }
                    palindrome = true;
                }
                if (palindrome) Console.WriteLine($"\r\n{value} -> да");
            }
            else Console.WriteLine("\r\nВведено не пятизначное число");
        }
        public void Task21()
        {
            double[] arrayA = Universal.Coordinate("Введите координаты точки A, в формате x, y, z");
            double[] arrayB = Universal.Coordinate("Введите координаты точки B, в формате x, y, z");
            Console.Write($"\r\nA ({arrayA[0]},{arrayA[1]},{arrayA[2]}); B ({arrayB[0]},{arrayB[1]},{arrayB[2]}) -> ");
            Console.Write(Math.Round(Math.Sqrt(Math.Pow(arrayA[0] - arrayB[0], 2) + Math.Pow(arrayA[1] - arrayB[1], 2) + Math.Pow(arrayA[2] - arrayB[2], 2)), 2));
        }
        public void Task23()
        {
            int value = Universal.ReadInt("Введите число: ");

            Console.Write($"\r\n{value} -> ");
            for (int i = 1; i <= value; i++)
            {
                Console.Write(Math.Pow(i, 3));
                if (i + 1 <= value) Console.Write(", ");
            }
        }
        public void Task25()
        {
            double value1 = Universal.ReadInt("Введите число: ");
            double value2 = Universal.ReadInt("Введите степень числа: ");
            double result = 1;
            Console.Write($"\r\n{value1}, {value2} -> ");
            if (value2 > 0)
            {
                for (int i = 1; i <= value2; i++)
                {
                    result = result * value1;
                }
                Console.Write(result);
            }
            else Console.WriteLine("\r\nДанная программа не ищет значения отрицательной степени или степени равной = 0");
        }
        public void Task27()
        {
            int value = Universal.ReadInt("Введите число: ");
            Console.Write($"\r\n{value} -> ");
            int[] array = value.ToString().Select(element => Convert.ToInt32(element) - 48).ToArray();
            Console.Write(array.Sum());
        }
        public void Task29()
        {
            int value = Universal.ReadInt("Введите количество элементов в массиве: ");
            int[] array = new int[value];
            Random rand = new Random();
            int left = 0;
            int right = 99;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(left, right+1);
            }
            Console.WriteLine($"[{string.Join(", ", array)}]");
        }
        public void Task34()
        {
            int value = Universal.ReadInt("Введите количество элементов в массиве: ");
            int[] array = Universal.FillRandomIntArray(value, 100, 999);
            Console.Write($"\r\n[{string.Join(", ", array)}] -> ");
            Console.Write(Universal.CountEvenElementArray(array));
        }
        public void Task36()
        {
            int value = Universal.ReadInt("Введите количество элементов в массиве: ");
            int[] array = Universal.FillRandomIntArray(value, -10, 100);
            Console.Write($"\r\n[{string.Join(", ", array)}] -> ");
            Console.Write(Universal.SumNoEvenElementArray(array));
        }
        public void Task38()
        {
            int value = Universal.ReadInt("Введите количество элементов в массиве: ");
            double[] array = Universal.FillRandomDoubleArray(value, 0, 99);
            Console.Write($"\r\n[{string.Join(", ", array)}] => ");
            Console.WriteLine($"{array.Max()} - {array.Min()} = {array.Max() - array.Min()}");
        }
        public void Task41()
        {
            Console.WriteLine();
            int[] array = Universal.ReadLineToArray("Введите числа через пробел: ");
            Console.Write($"\r\n{string.Join(", ", array)} => ");
            Console.Write(array.Count(x => x > 0));
        }
        public void Task43()
        {
            double k1 = Universal.ReadInt("Введите значение аргумента для первой прямой: ");
            double b1 = Universal.ReadInt("Введите свободный член для первой прямой: ");
            double k2 = Universal.ReadInt("Введите значение аргумента для второй прямой: ");
            double b2 = Universal.ReadInt("Введите свободный член для второй прямой: ");
            if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают");
            else if (k1 == k2 && b1 != b2) Console.WriteLine("Прамые параллельны и решений нет");
            else
            {
                double[] array = Universal.IntersectionLines(k1, k2, b1, b2);

                Console.Write($"\r\nb1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ");
                Console.Write($"({string.Join(",  ", array)})");
            }
        }
        public void Task47()
        {
            int m = Universal.ReadInt("Введите количество столбцов в массиве: ");
            int n = Universal.ReadInt("Введите количество строк в массиве: ");
            double[,] array = Universal.FillRandomDoubleMatrix(m, n);
            Console.WriteLine($"m = {m}, n = {n}.");
            Universal.PrintDoubleMatrix(array);
        }
        public void Task50()
        {
            int row = Universal.ReadInt("Введите количество строк в массиве: ");
            int col = Universal.ReadInt("Введите количество столбцов в массиве: ");
            int[] findElement = Universal.ReadLineToArray("Введи позицию искомого элемента через пробел (пример: 4 5): ");
            int[,] array = Universal.FillRandomIntMatrix(row, col, 0, 20);
            Universal.PrintIntMatrix(array);
            if (findElement[0] < row && findElement[1] < col)
            {
                Console.WriteLine($"{findElement[0]},{findElement[1]} -> {array[findElement[0], findElement[1]]}");
            }
            else Console.WriteLine($"{findElement[0]},{findElement[1]} -> такого числа в массиве нет");

        }
        public void Task52()
        {
            int row = Universal.ReadInt("Введите количество строк в массиве: ");
            int col = Universal.ReadInt("Введите количество столбцов в массиве: ");
            int[,] array = Universal.FillRandomIntMatrix(row, col, 0, 100);
            double[] arithmeticMean = new double[col];
            Universal.PrintIntMatrix(array);
            int result = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    result += array[i, j];
                }
                arithmeticMean[j] =Math.Round((double)result / (double)array.GetLength(0),2);
                result = 0;
            }
            Console.WriteLine("\r\nСреднее арифметическое каждого столбца: " + string.Join(";  ", arithmeticMean) + ".");
        }
        public void Task54()
        {
            int row = Universal.ReadInt("Введи количество строк в массиве: ");
            int col = Universal.ReadInt("Введи количество столбцов в массиве: ");
            int[,] array = Universal.FillRandomIntMatrix(row, col, 0, 10);
            Universal.PrintIntMatrix(array);
            Console.WriteLine();
            Universal.BubbleSortForIntMatrix(array);
            Universal.PrintIntMatrix(array);
        }
        public void Task56()
        {
            int row = Universal.ReadInt("Введи количество строк в массиве: ");
            int col = Universal.ReadInt("Введи количество столбцов в массиве: ");
            int[,] array = Universal.FillRandomIntMatrix(row, col, 0, 10);
            Console.WriteLine();
            Universal.PrintIntMatrix(array);
            Console.WriteLine();
            Console.WriteLine($"Наименьшая сумма элементов находится на строке #{Universal.MinSumElementRow(array)}");

        }
        public void Task58()
        {
            int rows1 = Universal.ReadInt("Введите количество строк первой матрицы: ");
            int cols1 = Universal.ReadInt("Введите количество столбцов первой матрицы: ");

            int rows2 = Universal.ReadInt("Введите количество строк второй матрицы: ");
            int cols2 = Universal.ReadInt("Введите количество столбцов второй матрицы: ");
            if (cols1 != rows2) { Console.WriteLine("Перемножение матриц не возможно"); }
            else
            {
                int[,] array1 = Universal.FillRandomIntMatrix(rows1, cols1, 0, 10);
                int[,] array2 = Universal.FillRandomIntMatrix(rows2, cols2, 0, 10);
                int[,] resultArray = Universal.CompositionMatrix(array1, array2);
                Console.WriteLine();
                Universal.PrintIntMatrix(array1);
                Console.WriteLine();
                Universal.PrintIntMatrix(array2);
                Console.WriteLine();
                Universal.PrintIntMatrix(resultArray);
            }
        }
        public void Task60()
        {
            int x = Universal.ReadInt("Введите x: ");
            int y = Universal.ReadInt("Введите y: ");
            int z = Universal.ReadInt("Введите z: ");
            if (x * y * z <= 90)
            {
                int[] buffer = Universal.BufferArray();
                int[,,] matrix = Universal.FillMatrixForTask60(x, y, z, ref buffer);
                Universal.PrintMatrixForTask60(matrix);
            }
            else Console.WriteLine("Мы не можем сгенерировать такой массив соблюдая условия задачи.");
        }
        public void Task62()
        {
            int number1 = Universal.ReadInt("Введите количество строк: ");
            int number2 = Universal.ReadInt("Введите количество столбцов: ");
            int[,] array = new int[number1, number2];
            Console.WriteLine();
            Universal.FillSpiralArray(ref array, number1, number2);
            Universal.PrintMatrixForTask62(array);
        }
        public void Task66()
        {
            int M = Universal.ReadInt("Введите число M: ");
            int N = Universal.ReadInt("Введите число N: ");
            if (M > N) Console.WriteLine($" Сумма натуральных элементов равна: {Universal.SumNumbers(N, M)}");
            else Console.WriteLine($" Сумма натуральных элементов равна: {Universal.SumNumbers(M, N)}");

        }
        public void Task68()
        {
            ulong valueA = Universal.Readulong("Введите первое число : ");
            ulong valueB = Universal.Readulong("Введите второе число : ");
            if (valueA >= 0 && valueB >= 0)
            {
                if ((valueA == 0 && valueB <= ulong.MaxValue - 1)||
                    (valueA == 1 && valueB <= 12021)||
                    (valueA == 2 && valueB <= 6008)||
                    (valueA == 3 && valueB <= 10))
                {
                    ulong result = Universal.Akkermana(valueA, valueB);
                    Console.Write($"\r\nm = {valueA}, n = {valueB} -> {result}");
                    
                }else Console.WriteLine("Программа не в состоянии посчитать функцию для таких значений");

            }
            else  Console.WriteLine("Числа должны быть не отрицательные");
        }

      
        //функция вызова медота по имени 
        public void Call(string taskName)
        {
            Console.WriteLine();
            MethodInfo myTask = GetType().GetMethod(taskName);
            myTask.Invoke(this, null);

        }
    }
}
