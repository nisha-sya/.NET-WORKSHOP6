namespace Task2
{
    internal class Program
    {
        public static void Main()
        {
            // created delegated object and assign method
            Calculate calculate;
            calculate = Add;
            Console.WriteLine(calculate(5, 8));

            calculate = Subtract;
            Console.WriteLine(calculate(10, 4));


            Console.WriteLine(CalculateFinalPrice(1000, FestivalDiscount));
            Console.WriteLine(CalculateFinalPrice(1000, SeasonalDiscount));
            Console.WriteLine(CalculateFinalPrice(1000, NoDiscount));
            Console.WriteLine(CalculateFinalPrice(1000, (double price = 1000) => price * 0.3));





        }

        public delegate int Calculate(int x, int y);



        public static int Add(int x, int y) => x + y;
        public static int Subtract(int x, int y) => x - y;



        public delegate double DiscountStrategy(double price);

        public static double FestivalDiscount(double price) => price * 0.2;

        public static double SeasonalDiscount(double price) => price * 0.1;

        public static double NoDiscount(double price) => price * 0;


        public static double CalculateFinalPrice(double OriginalPrice, DiscountStrategy discountStrategy)
        {
            double discount = discountStrategy(OriginalPrice);
            return OriginalPrice - discount;
        }

    }

}