using System;


namespace CarDelegate
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Delegates as event enablers *****\n");

            // Создать объект Car.
            Car car = new Car("Ford", 50, 100);

            // Сообщить объекту Car, какой метод вызывать,
            // когда он пожелает отправить сообщение.
            //car.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent1));
            //car.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent2));

            Car.CarEngineHandler handler1 = new Car.CarEngineHandler(OnCarEngineEvent1);
            car.RegisterWithCarEngine(handler1);
            Car.CarEngineHandler handler2 = new Car.CarEngineHandler(OnCarEngineEvent2);
            car.RegisterWithCarEngine(handler2);

            // Увеличить скорость (это инициирует события).
            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 5; i++)
            {
                car.Accelerate(10);
            }

            car.UnRegisterWithCarEngine(handler2);
            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 5; i++)
            {
                car.Accelerate(10);
            }

            Console.ReadLine();
        }
        public static void OnCarEngineEvent1(string msg)
        {
            Console.WriteLine("\n***** Message From Car Object *****");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("*********************************\n");
        }

        public static void OnCarEngineEvent2(string msg)
        {
            Console.WriteLine("=> {0}", msg.ToUpper());
        }
    }
}