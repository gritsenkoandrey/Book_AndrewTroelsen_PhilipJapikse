namespace FunWithObservableCollections
{
    class Person
    {
        public string PersonFirstName { get; set; }
        public string PersonLastName { get; set; }
        public int PersonAge { get; set; }

        public Person(string firstName, string lastName, int age)
        {
            PersonFirstName = firstName;
            PersonLastName = lastName;
            PersonAge = age;
        }

        public Person()
        {

        }

        public override string ToString()
        {
            return $"{PersonFirstName} {PersonLastName} {PersonAge}";
        }
    }
}