namespace NumberComparison
{
    internal class Program //the box holding the program
    {
        static void Main(string[] args) //the starting point of the program
        { //anything inside these curly braces is part of the Main method and runs when the program starts
            Console.WriteLine("Enter your first number:"); //asks the user for their first number
            int num1 = Convert.ToInt32(Console.ReadLine()); //reads the user's input and converts it to an integer
            
            Console.WriteLine("Enter your second number:"); //asks the user for their second number
            int num2 = Convert.ToInt32(Console.ReadLine()); //reads the user's input and converts it to an integer

            if (num1 == num2) //checks if the two numbers are equal
            {
                Console.WriteLine(num1 + " and " + num2 + " are equal "); //if they are equal, it prints this message
            }
            else //if the numbers are not equal
            {
                Console.WriteLine(num1 + " and " + num2 + " are not equal "); //if they are not equal, it prints this message
            }
        }
    }
}
