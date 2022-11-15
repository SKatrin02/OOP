//
// Струтинська Катерина КІ-20009Б
//
//                  Завдання до лабораторної роботи
// 1. Створити клас з прихованими полями, конструкторами з параметрами та 
// без параметрів, методами, властивостями і перевантаженими операціями 
// відповідно варіанту.
// 2. Розроблена програма повинна містити перевірку усіх розроблених 
// елементів класу.
// 3. Необхідно також перевизначити метод ToString() та метод Equals().
//
//                         Варіант 16 (1).
// Створити базовий клас «комплексне число», такий, що:
// a) його екземпляр містить дійсну і уявну частину - змінні з плаваючою 
// точкою.
// b) його конструктор без параметра створює екземпляр зі значенням 0.0 + 
// i0 .0, а конструктор з параметрами створює екземпляр з відповідною 
// дійсної та уявної частиною.
// c) його властивості дозволяють отримувати і присвоювати значення дійсної 
// та уявної частини.
// d) метод ToString() повертає рядок у вигляді 0.00 ± i0.00.
// e) операція «+» перевантажена: для двох комплексних чисел обчислює 
// суму, складаючи окремо дійсні частини і окремо - уявні частини; при
// додаванні з дійсним числом збільшується тільки дійсна частина.
// Скласти програму, яка перевіряє виконання перерахованих функцій.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb12_Strutynska_Katerina
{
    // Створення класу "комплексних чисел".
    class Complex
    {
        // Приховане поле. 
        private double r, i;

        public double R { get => r; set => r = value; }
        public double I { get => i; set => i = value; }

        public Complex()// Конструктор без параметрів.
        {
            this.R = 0.0;
            this.I = 0.0;
        }
        public static Complex Sum(Complex a, Complex b)// Конструктор з параметрами.
        {
            Complex res = new Complex();
            res.R = a.R + b.R;
            res.I = a.I + b.I;
            return res;
        }
        public static Complex operator +(Complex a, Complex b) // Перевантаження оператора +.
        {
            return Complex.Sum(a, b);
        }
        public override string ToString()// Повернення рядку методом ToString до вигляду 0.00 + i0.00 .
        {
            return String.Format("{0} + i {1}", this.R, this.I);
        }
        public void PrintLine(Complex a)
        {
            Console.WriteLine(a);
        }
    }
    // Створення класу програма, для перевірки виконання перерахованих функцій.
    class Programa
    {
        static  void Main(string[] args)
        {
            Complex c1 = new Complex();
            Complex c2 = new Complex();
            // Задаємо значення дійсним і уявним частинам.
            Console.Write("Enter the integer part of the first complex number: ");
            c1.R = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the imaginary part of the first complex number: ");
            c1.I = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the integer part of the second complex number: ");
            c2.R = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the imaginary part of the second complex number: ");
            c2.I = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            // Показ заданих значень.
            Console.WriteLine("Entered complex numbers: ");
            c1.PrintLine(c1);
            c2.PrintLine(c2);
            Console.WriteLine("\nTo continue, press [Enter]");
            Console.ReadLine();
            Console.Clear();
            // Розрахунок суми двох комплексних чисел.
            Console.WriteLine("The addition of complex numbers:       {0} + {1}i", (c1 + c2).R, (c1 + c2).I);
            Console.WriteLine("\nTo exit the program, press [Enter]");
            Console.ReadLine();
        }
    }
}
