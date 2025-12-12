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

            Console.WriteLine(sum); // write sum to console
            Console.WriteLine(difference); // write difference to console
            Console.WriteLine(product); // write product to console
            
            // division & modulus operations
            int c = 32; // initialized an int variable
            int d = 6; // initialized an int variable

            int quotient = c / d; // initialized quotient variable to demonstrate division operator
            int remainder = c % d; // initialized remainder variable to demonstrate modulus operator

            Console.WriteLine(quotient); // write quotient to console
            Console.WriteLine(remainder); // write remainder to console
        }
    }
}
