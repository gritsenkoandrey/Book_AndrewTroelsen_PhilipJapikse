using System;


namespace CarDelegateMethodGroupConversion
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****i Method Group Conversion *****\n");
            Car c1 = new Car();

            // зарегистрировать простое имя метода
            c1.RegisterWithCarEngine(CallMeWhere);
            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }
            // Отменить регистрацию простого имени метода
            c1.UnRegisterWithCarEngine(CallMeWhere);
            // Уведомления больше не поступают!
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }
            Console.ReadLine();
        }

        static void CallMeWhere(string msg)
        {
            Console.WriteLine(" = > Message from Car: {0}", msg);
        }
    }
}