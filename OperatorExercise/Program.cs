namespace OperatorExercise
{
    public class Program
    {
        public static double AreaOfCircle(double radius) // Create a public method, that takes a return type of double, and returns the area of a circle taking user input
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static void PrintAreaOfCircle()
        {
            Console.WriteLine("Please enter the circles radius:"); // write a message to the user, requesting they enter the radius of a circle
            double radius = double.Parse(Console.ReadLine()); // create prompt for user input
            Console.WriteLine($"This area of a circle with a radius of {radius} is {AreaOfCircle(radius)}"); // using string interpolation, print users input of radius, call AreaOfCircle method with radius argument
        }
        
        static void Main(string[] args)
        {
            // arithmetic operations
            int a = 17; // initialized an integer variable
            int b = 4; // initialized an integer variable

            int sum = a + b; // initialized sum variable to demonstrate addition operator
            int difference = a - b; // intialized difference variable to demonstrate subtraction operator
            int product = a * b; //initialized product variable to demonstrate multiplication variable

            Console.WriteLine($"{a} + {b} equals {sum}"); // write sum to console
            Console.WriteLine($"{a} - {b} equals {difference}"); // write difference to console
            Console.WriteLine($"{a} * {b} equals {product}"); // write product to console
            
            // division & modulus operations
            int c = 32; // initialized an int variable
            int d = 6; // initialized an int variable

            int quotient = c / d; // initialized quotient variable to demonstrate division operator
            int remainder = c % d; // initialized remainder variable to demonstrate modulus operator

            Console.WriteLine($"{c} / {d} equals {quotient}"); // write quotient to console
            Console.WriteLine($"{c} % {d} is {quotient} remainder  {remainder}"); // write remainder to console

            PrintAreaOfCircle(); // call method

        }
    }
}
