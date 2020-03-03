namespace vicd.app.DataStructures.LinkedList
{
    internal class Person
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Person(int id, string firstName, string lastName) =>
            (Id, FirstName, LastName) = (id, firstName, lastName);
    }
}
