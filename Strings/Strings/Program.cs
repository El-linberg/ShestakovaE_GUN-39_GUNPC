using System.Collections.Generic;
using System.Text;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //Напишите метод, который принимает две строки и возвращает конкатенацию этих строк.

            Console.WriteLine("Задание 1");
            ConcatenateStrings();
            static void ConcatenateStrings()
            {
                var str1 = Console.ReadLine();
                var str2 = Console.ReadLine();
                Console.WriteLine(str1 + str2);
            }

            //Задание 2
            //Напишите метод GreetUser, который получает имя (string) и возраст (int), а затем использует строку с форматом $ для возврата сообщения вида “Hello, [Name]! You are [Age] years old.” .
            //Второе предложение должно идти с новой строки (используйте escape последовательность)
            Console.WriteLine("Задание 2");
            GreetUser();
            static void GreetUser()
            {
                var name = Console.ReadLine();
                var age = Console.ReadLine();
                Console.WriteLine($"Hello, {name}! You are {age} years old.");
            }


            //Задание 3
            //Закончите метод, который получает строку и возвращает новую строку с информацией: Количество символов в строке Строку в верхнем регистре Строку в нижнем регистре
            //Используйте методы класса string
            Console.WriteLine("Задание 3");
            NewString();
            static void NewString()
            {
                var str3 = Console.ReadLine();
                var i1 = str3.Length;
                var i2 = str3.ToUpper();
                var i3 = str3.ToLower();

                Console.WriteLine($"Количество символов в строке: {i1}, Строка в верхнем регистре {i2} Строка в нижнем регистре {i3}");
            }

            //Задание 4
            //Напишите метод, который возвращает первые 5 символов строки. Используйте метод Substring
            Console.WriteLine("Задание 4");
            FirstFive();
            static void FirstFive()
            {
                var str4 = Console.ReadLine();
                var first = str4.Substring(0, 5);

                Console.WriteLine($"Первые 5 символов: {first}");
            }

            //Задание 5
            //Напишите метод, принимающий на вход массив из строк и возвращающий экземпляр StringBuilder. Вам нужно создать экземпляр StringBuilder,
            //который объединяет все элементы входного массива в одно предложение, каждый элемент - через пробел. Какой метод StringBuilder вы будете использовать: Append или AppendLine?
            Console.WriteLine("Задание 5");
            BuilderString();
            static void BuilderString()
            {
                var a = Console.ReadLine();
                var b = Console.ReadLine();
                var c = Console.ReadLine();
                var builder = new StringBuilder();
                builder.Append(a);
                builder.Append(' ');
                builder.Append(b);
                builder.Append(' ');
                builder.Append(c);
                Console.WriteLine(builder.ToString());
            }


            //Задание 6
            //Напишите метод, который принимает строку и два слова: одно для поиска и другое для замены.
            //Затем замените все вхождения первого слова на второе слово в введенной строке и верните результат. 
            Console.WriteLine("Задание 6");
            ReplaceWord();
            static void ReplaceWord()
            {
                Console.WriteLine("Введите строку ");
                var inputString = Console.ReadLine();
                Console.WriteLine("Введите слово для поиска ");
                var findWord = Console.ReadLine();
                Console.WriteLine("Введите слово для замены ");
                var replaceWord = Console.ReadLine();
                Console.WriteLine(inputString.Replace(findWord, replaceWord));
            }

        }
    }

 
    
}
