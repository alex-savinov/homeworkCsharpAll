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
        public void Task41() => Console.WriteLine("Вызван метод 41 ");
        public void Task43() => Console.WriteLine("Вызван метод 43 ");
        public void Task47() => Console.WriteLine("Вызван метод 47 ");
        public void Task50() => Console.WriteLine("Вызван метод 50 ");
        public void Task52() => Console.WriteLine("Вызван метод 52 ");
        public void Task54() => Console.WriteLine("Вызван метод 54 ");
        public void Task56() => Console.WriteLine("Вызван метод 56");
        public void Task58() => Console.WriteLine("Вызван метод 58 ");
        public void Task60() => Console.WriteLine("Вызван метод 60 ");
        public void Task62() => Console.WriteLine("Вызван метод 62 ");
        public void Task66() => Console.WriteLine("Вызван метод 66 ");
        public void Task68() => Console.WriteLine("Вызван метод 68 ");


        //функция вызова медота по имени 
        public void Call(string taskName)
        {
            Console.WriteLine();
            MethodInfo myTask = GetType().GetMethod(taskName);
            myTask.Invoke(this, null);

        }
    }
}
