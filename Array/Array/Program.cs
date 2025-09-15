// See https://aka.ms/new-console-template for more information
using System.Drawing;
using System.Text;

namespace HomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            int k=10;

            int a = 0;
            int b = 1;
            Console.Write("Первые 10 чисел Фибоначчи: ");
            for (int i = 0;i<k;i++)
            {
                Console.Write(a + " ");
                int next = a + b;
                a = b;
                b = next;
            }
            Console.WriteLine();

            // Задание 2
            Console.Write("Четные числа от 2 до 20: ");

            for (int i = 2; i <= 20; i+=2)
            {
                Console.WriteLine(i);
            }

            // Задание 3
            Console.Write("Таблица умножения от 1 до 5: ");
            for (int i = 1; i < 6; i ++)
            {
                for (int j = 1; j < 11; j++)
                { 
                    Console.Write($"{i}*{j} = {i * j}\t"); 
                }
            
                Console.WriteLine();
            }
            // Задание 4
            string password = "qwerty";
            Console.Write("Введите пароль ");
            string pas = Console.ReadLine();
            if (pas == password)
            {
                Console.WriteLine("Пароль верный");
            }
            else
            {
                do
                {
                    Console.Write("Введите пароль ");
                    pas = Console.ReadLine();
                }
                while (pas != password);
                Console.Write("Пароль верный");
            }

        }
        }
}


