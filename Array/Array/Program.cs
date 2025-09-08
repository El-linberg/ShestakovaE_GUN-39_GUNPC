// See https://aka.ms/new-console-template for more information
using System.Drawing;
using System.Text;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            int[] fib = new int[8] { 0, 1, 1, 2, 3, 5, 8, 13 };
            
            // Задание 2
            string[] mon = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            // Задание 3
            int[,] matrix = new int[3,3] {  {2,3,4},
                                            {4,9,16},
                                            {8,27,64}};
            // Задание 4
            double[][] jaggedArray = new double[][] { new double[] { 1, 2, 3, 4, 5 }, new double[] { Math.E, Math.PI }, new double[] { Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000) } };
            
            // Массивы для заданий 5-6 
            int[] array = { 1, 2, 3, 4, 5 };
            int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };
            
            // Задание 5
            Array.Copy(array, 0, array2, 0, 3);
            foreach (var n in array2)
                Console.WriteLine(n); // Выведите результат                                    

            //Задание 6
            string[] sample = { "rtr", "rtr" };
            int newSize = sample.Length *2;
            Array.Resize(ref sample, newSize);
            foreach (var r in sample)
                Console.WriteLine(r);
                Console.WriteLine("Длина массива:" +sample.Length);
                // Выведите результат
        }
    }
}


