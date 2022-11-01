//
// Квіткова клумба має форму кола. За заданим радіусом обчислити її периметр і площу
//
// Початок просторів імен що підключаються
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Кінець просторів імен

namespace lb9_Task2_Strutynska_Katerina// Оголошення нового простору імен
{
    class Program// Оголошення нового класу
    {
        static void Main(string[] args)// Оголошення нового методу
        {
            double P;// Периметр
            double S;// Площа
            // Початок задання значення радіусу
            Console.Write("Set a value radius = ");
            int r = Convert.ToInt32(Console.ReadLine());
            // Кінець задання значення
            P = 2 * Math.PI * r;// Формула периметра
            S = Math.PI * Math.Pow(r, 2);// Формула площі
            // Початок показу результатів розв'язання формул
            Console.WriteLine($"Flower bed perimeter = {P}");
            Console.WriteLine($"Flower bed area = {S}");
            // Кінець показу результатів
            Console.ReadKey();// Показ інформації в консолі
        }
    }
}
