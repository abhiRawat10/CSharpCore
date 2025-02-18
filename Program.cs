namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Press C to exit at any point \n");
            Console.WriteLine("Enter the first number");
            int a = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                string temp= Console.ReadLine();
                char operation = temp[0];
                if (operation == 'c' || operation == 'C') break; //exit logic

                string tempb = Console.ReadLine();//taking no.

                //checking if the input is a number
                if (int.TryParse(tempb,out int b)){

                    int t = 0;

                    switch (operation)
                    {
                        case '+':
                            t = a + b;
                            break;
                        case '-':
                            t = a - b;
                            break;
                        case '*':
                            t = a * b;
                            break;
                        case '/':
                            t = a / b;
                            break;
                        default:
                            Console.WriteLine("Invalid Operation");
                            break;
                    }
                    Console.WriteLine("current total " + t);
                    a = t;
                }

                //if c or C char is entered exit the loop
                else
                {
                    if(tempb[0] == 'c' || tempb[0] == 'C') break; //exit logic
                    Console.WriteLine("Invalid Input");
                    break;
                }

                
            }
        }
    }
}
