// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net;
using System.Xml.Linq;
namespace HomeWork
{
    internal class Program
    {
        private class ListTask
        {
            private readonly List<string> _listOfInts = new List<string>()
            {
                "Сергей",
                "Андрей",
                "Арсений"
            };
            public void TaskLoop()
            {
                Console.WriteLine("Начальный список:");
                PrintList(_listOfInts);
                while (true)
                {
                    Console.Write("\nВведите новую строку для добавления в конец списка (Для выхода введите exit): ");
                    string newItem = Console.ReadLine();

                    if (newItem != "exit")
                    {   
                        _listOfInts.Add(newItem);
                        Console.WriteLine("\nСписок после добавления новой строки:");
                        PrintList(_listOfInts);
                    }
                    else
                    {
                        Console.WriteLine("Выполнение программы прервано.");
                        break;
                    }
                }
            }
            public static void PrintList(List<string> list)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {list[i]}");
                }
            }
        }
            private class LinkedListTask
        {
            private class Node 
            {
                public string Name {  get; set; }
                public int Grade {  get; set; }
                //public Dictionary<int, string, int> Students = new Dictionary<int, string, int>() Почему нельззя так сделать? Тут ведь должен быть один справочник с именем студента и оценками? Или как то по другому должно быть?
                //{
                //    {1, "Иван",  3 },
                //    {2, "Иван",  5 },
                //    {3, "Николай",  3 },
                //    {4, "Николай",  5 }
                //};


            
            } // Узел списка

            public void TaskLoop()
            {
                var node1 = new Node() { Name = "Иван", Grade = 3 };
                var node2 = new Node() { Name = "Иван", Grade = 5 };
                var node3 = new Node() { Name = "Николай", Grade = 3 };
                var node4 = new Node() { Name = "Николай", Grade = 5 };
                int s=0;
                int grade;
                Console.WriteLine("Введите имя студента:");
                string studname = Console.ReadLine();
                Console.Write($"Введите оценку для {studname} (от 2 до 5): ");
                string inputGrade = Console.ReadLine();
                while (true)
                {
                    if (int.TryParse(inputGrade, out grade) && grade >= 2 && grade <= 5)
                    {
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: Оценка должна быть числом от 2 до 5.");
                    }
                }

                if (studname == node1.Name)
                {
                    s=(node1.Grade+node2.Grade+grade)/3;
                    Console.WriteLine($"Средняя оценка {studname} : {s}");
                }
                if (studname == node3.Name)
                {
                    s = (node3.Grade + node4.Grade + grade) / 3;
                    Console.WriteLine($"Средняя оценка {studname} : {s}");
                }
                else
                {
                    Console.WriteLine($"Средняя оценка {studname} : {s}");
                }

                    Console.WriteLine(studname + " " + grade);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1,2 or 3 to check task 1,2 or 3");
            int task = int.Parse(Console.ReadLine()); // Используйте tryParse
            switch (task)
            {
                case 1:
                    CheckTaskFirst(); // Выполнение задания в отдельном методе
                    break;
                case 2:
                    CheckTaskTwo(); // Выполнение задания в отдельном методе
                    break;
                //case 3:
                //    CheckTaskThree(); // Выполнение задания в отдельном методе
                //    break;

            }
        }

        private static void CheckTaskFirst()
        {
            var listTask = new ListTask();
            listTask.TaskLoop();
        }
        private static void CheckTaskTwo()
        {
            var linkedListTask = new LinkedListTask();
            linkedListTask.TaskLoop();
        }
        //private static void CheckTaskThree()
        //{
        //    var linkedListTask = new LinkedListTask();
        //    linkedListTask.TaskLoop();
        //}
    }
}

