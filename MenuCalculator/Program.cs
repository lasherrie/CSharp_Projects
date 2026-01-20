namespace MenuCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool runProgram = true;

                while (runProgram) //repeat until user decides to exit
                {
                    Console.WriteLine("===== Calculator Menu ====="); //menu header
                    Console.WriteLine("1. Addition"); //menu options
                    Console.WriteLine("2. Subtraction");
                    Console.WriteLine("3. Multiplication");
                    Console.WriteLine("4. Division");
                    Console.Write("Select an option (1-4): "); //prompt user for choice

                    int choice = Convert.ToInt32(Console.ReadLine()); //read user choice

                    Console.Write("Enter first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    switch (choice) //perform operation based on user choice Ex.If user chooses 1, perform addition
                    {
                        case 1:
                            Console.WriteLine("Result: " + (num1 + num2));
                            break;

                        case 2:
                            Console.WriteLine("Result: " + (num1 - num2));
                            break;

                        case 3:
                            Console.WriteLine("Result: " + (num1 * num2));
                            break;

                        case 4:
                            if (num2 != 0)
                            {
                                Console.WriteLine("Result: " + (num1 / num2));
                            }
                            else
                            {
                                Console.WriteLine("Cannot divide by zero!");
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid choice!");
                            break;
                    }

                    Console.Write("Do you want to continue? (y/n): ");
                    string answer = Console.ReadLine();

                    if (answer.ToLower() != "y") //check if user wants to continue
                    {
                        runProgram = false; //exit loop if user chooses 'n'
                    }

                    Console.WriteLine(); 
                }

                Console.WriteLine("Program Ended. Goodbye!");
            }
        }

    }
