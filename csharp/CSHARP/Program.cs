namespace MultileveInheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new Developer(); // Calling base class in the object
            developer.Display("Aaditya");
            developer.GetEmpId(001129069);
            developer.WriteCode();
            Console.ReadLine();
        }
    }
}
