﻿using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace exercises
{
    class Program
    {
        //Повторный вывод всего приложения
        static void RepeatExercises()
        {
            bool answerUser = true;
            while (answerUser)
            {
                Console.Clear();
                Task[] tasks = new Task[28];
                //lesson1
                tasks[0] = new Task(2, "Task2", "Cравнение двух чисел", "Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.\r\n\r\na = 5; b = 7 -> max = 7\r\n\r\na = 2 b = 10 -> max = 10\r\n\r\na = -9 b = -3 -> max = -3");
                tasks[1] = new Task(4, "Task4", "Максимальное значение из 3 элементов", "Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.\r\n\r\n2, 3, 7 -> 7\r\n\r\n44 5 78 -> 78\r\n\r\n22 3 9 -> 22");
                tasks[2] = new Task(6, "Task6", "Проверка на четность", "Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).\r\n\r\n4 -> да\r\n\r\n-3 -> нет\r\n\r\n7 -> нет");
                tasks[3] = new Task(8, "Task8", "Четные от 1 до N", "Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.\r\n\r\n5 -> 2, 4\r\n\r\n8 -> 2, 4, 6, 8");
                //lesson2
                tasks[4] = new Task(10, "Task10", "Вторая цифра трехзначного числа", "Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.\r\n456 -> 5\r\n782 -> 8\r\n918 -> 1");
                tasks[5] = new Task(13, "Task13", "Третья цифра числа", " Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.\r\n645 -> 5\r\n78 -> третьей цифры нет\r\n32679 -> 6");
                tasks[6] = new Task(15, "Task15", "Проверка на выходной", "Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.\r\n6 -> да\r\n7 -> да\r\n1 -> нет");
                //lesson3
                tasks[7] = new Task(19, "Task19", "Проверка на полиндром", "Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.\r\n14212 -> нет\r\n12821 -> да\r\n23432 -> да");
                tasks[8] = new Task(21, "Task21", "Расстояние между точками в 3D пространстве", "Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.\r\nA (3,6,8); B (2,1,-7), -> 15.84\r\nA (7,-5, 0); B (1,-1,9) -> 11.53\r\n");
                tasks[9] = new Task(23, "Task23", "Таблица кубов от 1 до N", "Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.\r\n3 -> 1, 8, 27\r\n5 -> 1, 8, 27, 64, 125");
                //lesson4
                tasks[10] = new Task(25, "Task25", "Возводим A в степень B", " Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.\r\n3, 5 -> 243 (3⁵)\r\n2, 4 -> 16");
                tasks[11] = new Task(27, "Task27", "Сумма цифр в числе", "Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.\r\n452 -> 11\r\n82 -> 10\r\n9012 -> 12");
                tasks[12] = new Task(29, "Task29", "Создание массива и вывод на экран", " Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.\r\n1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]\r\n6, 1, 33 -> [6, 1, 33]");
                //lesson5
                tasks[13] = new Task(34, "Task34", "Массив положительных трехзначных чисел", "Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.\r\n[345, 897, 568, 234] -> 2\r\n");
                tasks[14] = new Task(36, "Task36", "Сумма элементов на нечетных позициях массива", "Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.\r\n[3, 7, 23, 12] -> 19\r\n[-4, -6, 89, 6] -> 0");
                tasks[15] = new Task(38, "Task38", "Разница между макс. и мин. элементом массива", "Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.\r\n[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76");
                //lesson6
                tasks[16] = new Task(41, "Task41", "Подсчет положительных чисел в введенной пользователем строке", "Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.\r\n0, 7, 8, -2, -2 -> 2\r\n1, -7, 567, 89, 223-> 3");
                tasks[17] = new Task(43, "Task43", "Точка пересечения двух прямых", "Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.\r\n\r\nb1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)");
                //lesson7
                tasks[18] = new Task(47, "Task47", "Создание двумерного массива заполненого вещественными числами", "Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.\r\n\r\nm = 3, n = 4.\r\n0,5 7 -2 -0,2\r\n1 -3,3 8 -9,9\r\n8 7,8 -7,1 9");
                tasks[19] = new Task(50, "Task50", "Поиск элемента по индексу в двумерном массиве", "Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.\r\n\r\nНапример, задан массив:\r\n1 4 7 2\r\n5 9 2 3\r\n8 4 2 4\r\n17 -> такого числа в массиве нет");
                tasks[20] = new Task(52, "Task52", "Среднее арифметическое каждого столбца массива", "Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.\r\n\r\nНапример, задан массив:\r\n1 4 7 2\r\n5 9 2 3\r\n8 4 2 4\r\nСреднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.");
                //lesson8
                tasks[21] = new Task(54, "Task54", "Упорядочивание по убыванию элементов каждой строки двумерного массива", "Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.\r\nНапример, задан массив:\r\n1 4 7 2\r\n5 9 2 3\r\n8 4 2 4\r\nВ итоге получается вот такой массив:\r\n7 4 2 1\r\n9 5 3 2\r\n8 4 4 2");
                tasks[22] = new Task(56, "Task56", "Поиск строки с наименьшей  суммой элементов", "Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.\r\n\r\nНапример, задан массив:\r\n1 4 7 2\r\n5 9 2 3\r\n8 4 2 4\r\n5 2 6 7\r\nПрограмма считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка");
                tasks[23] = new Task(58, "Task58", "Произведение матриц", "Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.\r\nНапример, даны 2 матрицы:\r\n2 4 | 3 4\r\n3 2 | 3 3\r\nРезультирующая матрица будет:\r\n18 20\r\n15 18");
                tasks[24] = new Task(60, "Task60", "Вывод трехмерного массива с неповторяющимися двузначными числами", "Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.\r\nМассив размером 2 x 2 x 2\r\n66(0,0,0) 25(0,1,0)\r\n34(1,0,0) 41(1,1,0)\r\n27(0,0,1) 90(0,1,1)\r\n26(1,0,1) 55(1,1,1)");
                tasks[25] = new Task(62, "Task62", "Заполнение массива спиральным типом", "Напишите программу, которая заполнит спирально массив 4 на 4.\r\nНапример, на выходе получается вот такой массив:\r\n01 02 03 04\r\n12 13 14 05\r\n11 16 15 06\r\n10 09 08 07");
                //lesson9
                tasks[26] = new Task(66, "Task66", "Сумму натуральных элементов в промежутке от M до N рекурсией.", "Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.\r\nM = 1; N = 15 -> 120\r\nM = 4; N = 8. -> 30");
                tasks[27] = new Task(68, "Task68", "Вычисления функции Аккермана с помощью рекурсии", "Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.\r\nm = 2, n = 3 -> A(m,n) = 9\r\nm = 3, n = 2 -> A(m,n) = 29\r\n");

                //Выводим список всех задач
                for (int i = 0; i < tasks.Length; i++) { tasks[i].PrintDescription(); }

                //Выбираем интересующее нас задание 
                int inputUser = Universal.ReadInt("Введите номер задания: \t");
                bool existenceTask = false;
                for (int i = 0; i < tasks.Length; i++)
                {
                    if (inputUser == tasks[i].Id)
                    {
                        Console.Clear();
                        tasks[i].PrintFullDescription();
                        RepeatTask(tasks[i].Id, tasks[i].Name ?? " ", tasks[i].FullDescription ?? " ");
                        existenceTask = true;
                        break;
                    } 
                }
                if (!existenceTask) { Console.WriteLine("Не могу найти данное задание, попробуйте еще раз."); Thread.Sleep(2000); }
                
               
            }
            
        }
        //Повторный вывод задания
        static void RepeatTask(int id, string name, string fullDescription)
        {
                Console.Clear();
                Console.WriteLine("******************************");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Задача #{id} : {fullDescription}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("******************************");
                CallingTasks task = new CallingTasks();
                task.Call(name);
                Console.WriteLine("\r\n\r\nПовторим упражнение? Y/N");
                var userInput = Console.ReadKey();
                if ((userInput.Key == ConsoleKey.Y) || (userInput.Key == ConsoleKey.L) || (userInput.Key == ConsoleKey.D1)) RepeatTask(id,name,fullDescription);

        }
        //Основной метод
        static void Main()
        {
            RepeatExercises();
        }

    }
}

