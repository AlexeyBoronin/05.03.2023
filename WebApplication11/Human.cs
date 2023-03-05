namespace WebApplication11
{
    public class Human
    {
        public string Name { get; }
        public int Age { get; }
        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString() => $"Human {Name} ({Age} лет)";
        
    }
}
