//
// Варіант 16(1)
//
// Завдання 1 - a=x2+Vz2-y
//
// Завдання 2 - Квіткова клумба має форму кола. За заданим радіусом обчислити її периметр і площу
//

// Початок просторів імен що підключаються
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Кінець просторів імен

namespace Task_1// Оголошення нового простору імен
{
    class Program// Оголошення нового класу
    {
        static void Main(string[] args)// Оголошення нового методу
        {
            int number; // Значення для оператора
            do// Початок оператора
            {
                // Початок задання значень X, Y, Z
                Console.Write("Set a value X = ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Set a value Y = ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.Write("Set a value Z = ");
                int z = Convert.ToInt32(Console.ReadLine());
                // Кінець задання значень
                number = x; // Прирівнюємо значення для оператора while із значенням X
                double a = Math.Pow(x, 2) + Math.Sqrt(Math.Pow(y, 2) - y);// Розв'язання формули відповідно варіанту
                Console.WriteLine($"a = {a}");// Показ результату розв'язання формули
                // Початок визначення і показу відповідного діапазону Х
                if (x < -10) Console.WriteLine($"X less than -10");
                if ((x > -10) && (x < -1)) Console.WriteLine($"X less than -1");
                if ((x > 1) && (x < 10)) Console.WriteLine($"X more for 1");
                if (x > 10) Console.WriteLine($"X more for 10");
                // Кінець визначення і показу діапазону Х

                // Визначення і показ відповідного діпазону результату розв'язання формули
                if (a < 0) Console.WriteLine($"The result is negative");
                if (a > 0) Console.WriteLine($"The result is positive");
                // Кінець визначення і показу діапазону результату
                Console.ReadKey();// Показ інформації в консолі
            }
            while (number != 0);// Перевірка оператором значення X, програма буде повторюватись поки X не буде = 0
        }
    }
}