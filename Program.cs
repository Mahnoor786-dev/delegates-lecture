using System;
namespace Program
{
    delegate int MathOperation(int a, int b);
    class MathOperation
    {
        public int Add(int a, int b)
        {
            Console.WriteLine("\nSum: "+ a + b);
            return a+ b;
        }
        public int Subtract(int a, int b)
        {
            Console.WriteLine("\Difference: "+ a - b);
            return a- b;
        }
        public int Multiply(int a, int b)
        {
            Console.WriteLine("\nProduct: "+ a + b);
            return a* b;
        }
        public int Add(int a, int b)
    }

    public class HelloWorld
    {


        public static void Main(string[] args)
        {
            
        }
    }
}