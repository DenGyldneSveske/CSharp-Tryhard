using System.Runtime.ConstrainedExecution;

namespace PrintTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInput = GetInput();
            TreeConstruct(userInput);
        }


        public static int GetInput()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        public static void PrintTree(int input)
        {
            for (int i = 1; i <= input; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        public static void TreeConstruct(int number)
        {
            for(int i = 1; i <= number; i++)
            {
                PrintTree(i);
            }
        }
    }
}





/*Skriv en metode, der tager et heltal som argument, og printer følgende: (her kaldt
med 5) 
*
**
***
****
*****
Lav metoden der skriver det ud i omvendt rækkefølge, f.eks. fra 5 og ned til 1 
stjerne. */