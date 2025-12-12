namespace OperatorExercise
{
    public class Program
    {
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
            
            
        }
    }
}
