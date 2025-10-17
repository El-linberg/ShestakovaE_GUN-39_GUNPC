// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
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
                    if (string.IsNullOrEmpty(newItem))
                    {
                        Console.WriteLine("\nСтрока не может быть пустой");
                        break;
                    }
                    if (newItem == "exit")
                    {
                        Console.WriteLine("Выполнение программы прервано.");
                        break;
                    }
                    else
                    {
                        _listOfInts.Add(newItem);
                        Console.WriteLine("\nСписок после добавления новой строки:");
                        PrintList(_listOfInts);
                    }
                    Console.Write("\nВведите новую строку для добавления в середину списка (Для выхода введите exit): ");
                    string newItem1 = Console.ReadLine();
                    if (string.IsNullOrEmpty(newItem1))
                    {
                        Console.WriteLine("\nСтрока не может быть пустой");
                        break;
                    }
                    if (newItem1 == "exit")
                    {
                        Console.WriteLine("Выполнение программы прервано.");
                        break;
                    }
                    else
                    {
                        int middle = _listOfInts.Count/2;
                        _listOfInts.Insert(middle,newItem1);
                        Console.WriteLine("\nСписок после добавления новой строки:");
                        PrintList(_listOfInts);
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
        private class Dictionary
        {

            public Dictionary< string, int> Students = new Dictionary<string, int>() 
            {
                {"Иван",  3 },
                {"Георгий",  5 },
                {"Николай",  3 },
                {"Игорь",  5 }
            };
            public void TaskLoop()
            {
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
                        Students[studname] = grade;
                        Console.WriteLine(studname + " " + grade);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: Оценка должна быть числом от 2 до 5.");
                    }
                }
                Console.WriteLine("Введите имя студента");
                string input = Console.ReadLine();
                int gradeFind;
                
                if (Students.ContainsKey(input))
                {
                    gradeFind = Students[input];
                    Console.WriteLine(input + " " + gradeFind);
                }
                else {
                    Console.WriteLine("Студент не найден");
                        }
            }
        }
        private class LinkedListTask
        {

            private readonly List<Node> _list = new List<Node>(6);
            public void TaskLoop()
            {
                Node previous = null;
                Node next = null;
                while (_list.Count != 6)
                {
                    string index = Console.ReadLine();
                    Node newNode = new Node();
                    newNode.previous = previous;
                    if (previous != null)
                    {
                        newNode.next = newNode;
                        previous = newNode;
                    }
                    Node first = _list[0];
                    while (first != null)
                    {
                        Console.WriteLine(first.Index);
                        first = first.next;
                    }
                    Node last = _list[_list.Count - 1];
                    while (last != null)
                    {
                        Console.WriteLine(last.Index);
                        last = last.next;
                    }
                }
            }
            public class Node
            {
                public Node previous;
                public Node next;
                public Node Index;
            
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
                case 3:
                    CheckTaskThree(); // Выполнение задания в отдельном методе
                    break;

            }
        }

        private static void CheckTaskFirst()
        {
            var listTask = new ListTask();
            listTask.TaskLoop();
        }
        private static void CheckTaskTwo()
        {
            var linkedListTask = new Dictionary();
            linkedListTask.TaskLoop();
        }
        private static void CheckTaskThree()
        {
            var listTask = new LinkedListTask();
                listTask.TaskLoop();
        }
    }
}

