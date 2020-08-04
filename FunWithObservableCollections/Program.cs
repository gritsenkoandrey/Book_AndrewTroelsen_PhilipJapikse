using System;
using System.Collections.ObjectModel;


namespace FunWithObservableCollections
{
    public enum NotifyCollectionChangedAction
    {
        Add = 0,
        Remove = 1,
        Replace = 2,
        Move = 3,
        Reset = 4,
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Сделать коллекцию наблюдаемой и добавить в нее несколько объектов Person.
            ObservableCollection<Person> people = new ObservableCollection<Person>()
            {
                new Person {PersonFirstName = "Andrey", PersonLastName = "Gritsenko", PersonAge = 32},
                new Person {PersonFirstName = "Irina", PersonLastName = "Gritsenko", PersonAge = 35}
            };

            // Привязаться к событию CollectionChanged.
            people.CollectionChanged += People_CollectionChanged;

            people.Add(new Person { PersonFirstName = "Arina", PersonLastName = "Gritsenko", PersonAge = 2 });
            people.Remove(people[2]);

            Console.ReadLine();
        }

        private static void People_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            // Выяснить действие, которое привело к генерации события.
            Console.WriteLine($"Action for this event: {0}", e.Action);

            // Было что-то удалено
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                // старые элементы
                Console.WriteLine("Here are the OLD items:");
                foreach (Person p in e.OldItems)
                {
                    Console.WriteLine(p.ToString());
                }
                Console.WriteLine();
            }
            // Было что-то добавлено
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                // Теперь вывести новые элементы, которые были вставлены.
                Console.WriteLine("Here are the NEW items:");
                // новые элементы
                foreach (Person p in e.NewItems)
                {
                    Console.WriteLine(p.ToString());
                }
            }
        }
    }
}