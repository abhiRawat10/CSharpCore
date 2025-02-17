namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter the first number");
            int a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the second number");
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Operation");
            //string operation = Console.ReadLine();

            while (true)
            {
                string operation = Console.ReadLine();

                int b = Convert.ToInt32(Console.ReadLine());

                int t = 0;

                switch (operation)
                {
                    case "+":
                        t = a + b;
                        break;
                    case "-":
                        t = a - b;
                        break;
                    case "*":
                        t = a * b;
                        break;
                    case "/":
                        t = a / b;
                        break;
                    default:
                        Console.WriteLine("Invalid Operation");
                        break;
                }
                Console.WriteLine("current total "+t);
                a = t;
            }
        }
    }
}
