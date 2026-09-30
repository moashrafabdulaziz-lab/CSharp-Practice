namespace Simple_Calculator_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            char operation = ' ';

            Console.WriteLine("Frist Number:");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid Value.. Enter an Integer Num");
            }

            Console.WriteLine("Operation:");
            while (!char.TryParse(Console.ReadLine(), out operation))
            {
                Console.WriteLine("Invalid Value..");
            }

            Console.WriteLine("Second Number:");
            while (!double.TryParse(Console.ReadLine(), out num2) || (operation == '/' || operation == '%') && num2 == 0)
            {
                Console.WriteLine("Invalid Value.. Enter a Number Not Equal Zero");
            }

            switch (operation)
            {
                case '+':
                    Console.WriteLine($"Result = {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"Result = {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"Result = {num1 * num2}");
                    break;
                case '/':
                    Console.WriteLine($"Result = {num1 / num2}");
                    break;
                case '%':
                    Console.WriteLine($"Result = {num1 % num2}");
                    break;
                default:
                    Console.WriteLine($"Invalid Result.. Enter a Valid Operator");
                    break;
            }
        }
    }
}
