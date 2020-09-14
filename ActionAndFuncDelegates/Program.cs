using System;


namespace ActionAndFuncDelegates
{
    public class Program
    {
        // Delegate Action<> можно использовать для "указания" на
        // метод, который принимает вплоть до 16 аргументов и возвращает void.

        // Это цель для делегата Action<>
        private static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
        {
            ConsoleColor previous = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;
            for (int i = 0; i < printCount; i++)
            {
                Console.WriteLine(msg);
            }
            Console.ForegroundColor = previous;
        }

        // Обобщенный делегат Func<> способен указывать на методы, которые
        // принимают вплоть до 16 параметров и имеют специальное возвращаемое значение.

        // Цель для делегата Func<>
        // последний параметр в Func<> всегда представляет возвращаемое значение метода.
        private static int Add(int x, int y)
        {
            return x + y;
        }

        private static string SumToString(int x, int y)
        {
            return (x + y).ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Action and Func *****");
            // Использовать делегат Action<> для указания на DisplayMessage.
            Action<string, ConsoleColor, int> actionTarget = new Action<string, ConsoleColor, int>(DisplayMessage);
            actionTarget("Action Message", ConsoleColor.Yellow, 5);

            Func<int, int, int> funcTarget = new Func<int, int, int>(Add);
            int result = funcTarget.Invoke(4, 7);
            Console.WriteLine("4 + 7 = {0}", result);

            Func<int, int, string> funcTarget2 = new Func<int, int, string>(SumToString);
            string sum = funcTarget2(47, 74);
            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}