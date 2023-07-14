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
        //Получаем координаты точки в трехмерном пространстве
        static public double[] Coordinate(string str)
        {
            try
            {
                Console.WriteLine(str);
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
       
    }
}
