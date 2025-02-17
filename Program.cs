namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter the first number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Operation");
            string operation = Console.ReadLine();

            switch(operation)
            {
                case "+":
                    Console.WriteLine("The sum is: " + (a + b));
                    break;
                case "-":
                    Console.WriteLine("The difference is: " + (a - b));
                    break;
                case "*":
                    Console.WriteLine("The product is: " + (a * b));
                    break;
                case "/":
                    Console.WriteLine("The quotient is: " + (a / b));
                    break;
                default:
                    Console.WriteLine("Invalid Operation");
                    break;
            }
            Console.ReadKey();
        }
    }
}
