using Lesson_9_Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomGenericMethods
{
    public static class MyGenericMethods
    {
        // обобщенный метод Swap<T>, который способен менять местами два значе­ния типа Т
        public static void Swap<T>(ref T a, ref T b) /*where T : struct*/
        {
            Console.WriteLine("You sent the Swap() method a {0}", typeof(T));
            T temp = a;
            a = b;
            b = temp;
        }

        public static void DispalayBaseClass<T>()
        {
            // BaseType - метод, используемый в рефлексии;
            Console.WriteLine("Base class of {0} is: {1}.", typeof(T), typeof(T).BaseType);
        }

        // Ошибка на этапе компиляции! Невозможно применять операции к параметрам типа!
        //public class BasicMath<T>
        //{
        //    public T Add(T argl, T arg2)
        //    { return argl + arg2; }
        //    public T Subtract(T argl, T arg2)
        //    { return argl - arg2; }
        //    public T Multiply(T argl, T arg2)
        //    { return argl * arg2; }
        //    public T Divide(T argl, T arg2)
        //    { return argl / arg2; }
        //}
    }

    public class Program
    {
        static void Main(string[] args)
        {
            double a = 90;
            double b = 10;

            string c = "World";
            string d = "Hello";

            bool a1 = true;
            bool b1 = false;

            Console.WriteLine("Before a = {0}, b = {1}", a, b);
            MyGenericMethods.Swap<double>(ref a, ref b);
            Console.WriteLine("After a = {0}, b = {1}", a, b);

            Console.WriteLine("Before c = {0}, d = {1}", c, d);
            MyGenericMethods.Swap<string>(ref c, ref d);
            Console.WriteLine("After c = {0}, d = {1}", c, d);

            MyGenericMethods.Swap<bool>(ref a1, ref b1);

            MyGenericMethods.DispalayBaseClass<int>();
            MyGenericMethods.DispalayBaseClass<string>();

            Console.ReadLine();
        }

        // Поменять местами два целочисленных значения,
        //static void Swap(ref int a, ref int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}

        //static void Swap(ref Person a, ref Person b)
        //{
        //    Person temp = a;
        //    a = b;
        //    b = temp;
        //}
    }
}