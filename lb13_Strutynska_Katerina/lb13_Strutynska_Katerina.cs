//
// Струтинська Катерина КІ-20009Б
//
// Завдання до лабораторної роботи
// Описати базовий клас (можливо, абстрактний), у якому за допомогою 
// віртуальних або абстрактних методів та властивостей задається інтерфейс для 
// похідних класів. 
// В усіх класах потрібно перевизначити метод Equals, щоби порівнювались 
// значення, а не посилання. Визначити в класах усі можливі конструктори.
// Метод Main повинен утримувати масив або список з елементів базового 
// класу, заповнений посиланнями на похідні класи, та демонструвати 
// використання усіх розроблених елементів класів відповідно варіанту.
// Показати на прикладі одного з методів, присутніх у кожному класі,
// використання поліморфізму.
// Обов’язково продемонструвати різницю між раннім та пізнім зв’язуванням
// 
// Варіант 16 (1) Квіткарка. Визначити ієрархію квітів. Створити кілька об'єктів-квітів. Зібрати букет з визначенням його вартості.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication24
{
    //Клас Квітка
    public abstract class Flower : IComparable<Flower>
    {
        //Властивість - ціна
        public virtual int Cost { get; set; }

        //Конструктор
        public Flower(int cost)
        {
            Cost = cost;
        }
        //Перевизначення ToString();
        public override string ToString()
        {
            return string.Format("Cost: {0:C}",
                                 Cost);
        }

        //Інтерфейс для сортування IComparable<Flower>
        public int CompareTo(Flower other)
        {
            if ((int)this.Cost > (int)other.Cost)
                return 1;
            if ((int)this.Cost < (int)other.Cost)
                return -1;
            else
                return 0;
        }
    }
    //Клас Роза
    public class Rose : Flower
    {
        //Конструктор
        public Rose(int cost)
            : base(0)
        {
            Cost = cost;
        }
        //Перевизначення ToString();
        public override string ToString()
        {
            return string.Format("{0}; {1}", "Rose", base.ToString()); ;
        }
    }
    //Клас Ірис
    public class Iris : Flower
    {

        //Конструктор
        public Iris(int cost)
            : base(0)
        {
            Cost = cost;
        }
        //Перевизначення ToString();
        public override string ToString()
        {
            return string.Format("{0}; {1}", "Iris", base.ToString()); ;
        }
    }
    //Клас Лілія
    public class Lily : Flower
    {

        //Конструктор
        public Lily(int cost)
            : base(0)
        {
            Cost = cost;
        }
        //Перевизначення ToString();
        public override string ToString()
        {
            return string.Format("{0}; {1}", "Lily", base.ToString()); ;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Масив (букету) квітів
            Flower[] flowers = new Flower[5]
            {
                new Rose(120),
                new Lily(100),
                new Iris(90),
                new Rose(150),
                new Iris(52)
            };

            Console.WriteLine("***** Букет цветов несортированный *****\n");
            foreach (Flower f in flowers)
            {
                Console.WriteLine(f.ToString());
            }

            //Сортуванння масиву
            Array.Sort(flowers);

            Console.WriteLine("\n***** Букет цветов отсортированный *****\n");
            foreach (Flower f in flowers)
            {
                Console.WriteLine(f.ToString());
            }
            Console.ReadLine();
        }
    }
}