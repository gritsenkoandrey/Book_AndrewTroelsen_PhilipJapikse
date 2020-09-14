using System;


namespace CarDelegateMethodGroupConversion
{
    public class Car
    {
        //1. Определить тип делегата.
        public delegate void CarEngineHandler(string msgForCaller);
        //2. Определить переменную-член этого типа делегата.
        private CarEngineHandler _listOfHandlers;
        //3. Добавить регистрационную функцию для вызывающего кода.
        // Добавление поддержки группового вызова.
        // Обратите внимание на использование операции +=,
        // а не обычной операции присваивания (=) .
        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            _listOfHandlers += methodToCall;
        }
        //Была объявлена закрытая переменная-член делегата (_listOfHandlers)
        //и вспомогательная функция(RegisterWithCarEngine ()), которая позволяет 
        //вызываю­щему коду добавлять метод в список вызовов делегата.

        //public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        //{
        //    if (_listOfHandlers == null)
        //        _listOfHandlers = methodToCall;
        //    else
        //        Delegate.Combine(_listOfHandlers, methodToCall);
        //}

        public void UnRegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            _listOfHandlers -= methodToCall;
        }

        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public string PetName { get; set; }

        private bool _carIsDead;

        public Car() { }
        public Car(string petName, int currenSpeed, int maxSpeed)
        {
            CurrentSpeed = currenSpeed;
            MaxSpeed = maxSpeed;
            PetName = petName;
        }

        // 4. Реализовать метод Accelerate () для обращения к списку
        // вызовов делегата в подходящих обстоятельствах.
        public void Accelerate(int delta)
        {
            if (_carIsDead)
            {
                _listOfHandlers?.Invoke("Sorry, this car is dead...");
                //if (_listOfHandlers != null)
                //{
                //    _listOfHandlers("Sorry, this car is dead...");
                //}
            }
            else
            {
                CurrentSpeed += delta;
                // Автомобиль почти сломан?
                if (10 == (MaxSpeed - CurrentSpeed)/* && _listOfHandlers != null*/)
                {
                    _listOfHandlers?.Invoke("Careful buddy! Gonna blow!");
                }

                if (CurrentSpeed >= MaxSpeed)
                {
                    _carIsDead = true;
                }
                else
                {
                    Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
                }
            }
        }
    }
}