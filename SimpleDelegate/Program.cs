using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    public delegate int BinaryOp(int x, int y);

    public class SimpleMath
    {
        //public static int Add(int x, int y) => x + y;
        //public static int Subtract(int x, int y) => x - y;
        //public static int SquareNumber(int a) => a * a;

        public int Add(int x, int y) => x + y;
        public int Subtract(int x, int y) => x - y;
        public int SquareNumber(int a) => a * a;

    }

    class Program
    {
        //Dыводит на консоль имена методов, поддерживаемых объектом делегата,
        //а также имя класса, определяющего метод.
        static void DisplayDelegateInfo(Delegate delObj)
        {
            // Вывести имена всех членов в списке вызовов делегата
            foreach (Delegate d in delObj.GetInvocationList())
            {
                // имя метода
                Console.WriteLine("Method Name: {0}", d.Method);
                // имя типа, выводит если только метод нестатический
                Console.WriteLine("Type Name: {0}", d.Target);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("*****Simple Delegate Example * ****\n");
            // Создать объект делегата BinaryOp, который "указывает" на SimpleMath.Add()
            //BinaryOp b = new BinaryOp(SimpleMath.Add);

            // Делегаты .NET могут также указывать на методы экземпляра.
            SimpleMath simpleMath = new SimpleMath();
            BinaryOp b = new BinaryOp(simpleMath.Add);

            // Вывести сведения об объекте
            DisplayDelegateInfo(b);

            // Вызвать метод Add() косвенно с использованием объекта делегата.
            Console.WriteLine("10 + 10 is {0}", b(10, 10));
            Console.WriteLine("10 + 10 is {0}", b.Invoke(10, 10));

            Console.ReadLine();
        }
    }
}