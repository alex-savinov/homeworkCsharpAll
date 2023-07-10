using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    internal class Universal
    {
        //Получаем данные из строки и конвертируем в тип данных int 
        static public int ReadInt(string value)
        {
            Console.Write(value);
            return (Convert.ToInt32(Console.ReadLine()));
        }
        //Получаем данные из строки и конвертируем в тип данных double 
        static public double ReadDouble(string value)
        {
            Console.Write(value);
            return (Convert.ToDouble(Console.ReadLine()));
        }
        //Выводит список уроков.



    }
}
