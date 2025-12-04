namespace Task1
{
    class Program
    {
        static void Main()
        {
            Rectangle r = new Rectangle { Length = 5, Width = 3 };

            Console.WriteLine($"Area = {r.GetArea()}");
            Console.WriteLine($"Perimeter = {r.GetPerimeter()}");
        }
    }

}