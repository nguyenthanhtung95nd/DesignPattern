namespace CreationalDesignPattern.Prototype
{
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Person GetClone()
        {
            return (Person) this.MemberwiseClone();
        }
    }
}