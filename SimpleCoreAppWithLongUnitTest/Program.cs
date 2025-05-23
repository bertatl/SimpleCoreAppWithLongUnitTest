namespace SimpleCoreAppWithLongUnitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int a = 2;
            int b = 3;
            var mu = new MathUtils.Utils();
            Console.WriteLine($"{a} + {b} = {mu.Add(a,b)}");
        }
    }
}
