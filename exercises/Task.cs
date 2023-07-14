using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    internal class Task
    {
        public Task(int id, string name, string description, string fullDescription)
        {
            Id = id;
            Name = name;
            Description = description;
            FullDescription = fullDescription;
        }


        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? FullDescription { get; set; }



        public void PrintDescription()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Задача #{Id} : {Description}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------------------------");
        }


        public void PrintFullDescription()
        {
            Console.WriteLine("******************************");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Задача #{Id} : {FullDescription}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("******************************");
        }

    }

    public class TaskDatabase
    {
        


    }
}
