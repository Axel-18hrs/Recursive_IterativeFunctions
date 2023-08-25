using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Recursive_IterativeFunctions
{
    internal class Program
    {
        static void Iterative_Factorial(int n)
        {
            int result = 1;
            foreach(int i in Enumerable.Range(1, n))
            {
                result *= i; 
            }
            Console.WriteLine("\n" + result);
        }

        static int Recursive_Factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;  
            }
            else
            {
                return n * Recursive_Factorial(n - 1);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("// Choose an option:" +
                "\n[1]: iterative factorial" +
                "\n[2]: recursive factorial\n");

            int choice = int.Parse(Console.ReadLine());

            Console.Clear();
            if(choice == 1 ) 
            { 
                Console.WriteLine("Enter a number: ");
                int num = int.Parse(Console.ReadLine());
                Iterative_Factorial(num);
            }

            if(choice == 2 )
            {
                Console.WriteLine("Enter a number: ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("\n" + Recursive_Factorial(num));
            }
            Console.ReadKey();
        }
    }
}
