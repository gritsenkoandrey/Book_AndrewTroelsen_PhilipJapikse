using System;


namespace GenericPoint
{
    // Обобщенная структура Point
    public struct Point<T>
    {
        // Обобщенные данные состояния
        private T xPos;
        private T yPos;

        // Обобщенный конструктор
        public Point(T xVal, T yVal)
        {
            xPos = xVal;
            yPos = yVal;
        }

        // Обобщенные свойства
        public T X
        {
            get => xPos;
            set => xPos = value;
        }

        public T Y
        {
            get => yPos;
            set => yPos = value;
        }

        public override string ToString() => $"[{xPos}, {yPos}]";

        // Сбросить поля в стандартные значения для заданного параметра типа
        // Ключевое слово default в языке C# перегружено
        // При использовании с обобщениями оно представляет стандартное значение для параметра типа
        public void ResetPoint()
        {
            xPos = default(T);
            yPos = default(T);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point<int> pointI = new Point<int>(20, 10);
            Console.WriteLine($"x = {pointI.X}, y = {pointI.Y}");
            pointI.ResetPoint();
            Console.WriteLine($"x = {pointI.X}, y = {pointI.Y}");

            Console.WriteLine(pointI.ToString());

            Console.ReadLine();
        }
    }
}