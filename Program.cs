namespace calculator
{
    internal class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static int Divide(int a, int b)
        {
            return a / b;
        }
        public static void Calculator()
        {
            Console.WriteLine("Enter first number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operation (+, -, *, /):");
            string operation = Console.ReadLine() ?? "";
            if(string.IsNullOrEmpty(operation) || (operation != "+" && operation != "-" && operation != "*" && operation != "/"))
            {
                Console.WriteLine("Invalid operation.");
                return;
            }
            Console.WriteLine("Enter second number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                switch (operation)
                {
                    case "+":
                        Console.WriteLine($"Result: {Add(firstNumber, secondNumber)}");
                        break;
                    case "-":
                        Console.WriteLine($"Result: {Subtract(firstNumber, secondNumber)}");
                        break;
                    case "*":
                        Console.WriteLine($"Result: {Multiply(firstNumber, secondNumber)}");
                        break;
                    case "/":
                        if (secondNumber == 0)//fix: handle division by zero 
                        {
                            Console.WriteLine("Cannot divide by zero.");
                            return;
                        }
                        Console.WriteLine($"Result: {Divide(firstNumber, secondNumber)}");
                        break;
                }
                Console.WriteLine("Do you want to perform another calculation? (y/n)");
                string answer = Console.ReadLine() ?? "";
                if (answer.ToLower() != "y")
                {
                    break;
                }
                Calculator();
            }
        }
        static void Main(string[] args)
        {
            Calculator();
        }
    }
}
