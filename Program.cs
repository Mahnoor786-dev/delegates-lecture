using System;
namespace Program
{
    delegate int MathOperation(int a, int b);
    delegate void ForAnonymousDelegate();
    delegate int ForAnonymousDelegate2(int a);
    class Operations
    {
        public static int Add(int a, int b)
        {
            Console.WriteLine("\nSum: "+ (a + b));
            return a+ b;
        }
        public static int Subtract(int a, int b)
        {
            Console.WriteLine("\nDifference:  " + (a - b));
            return a- b;
        }
        public static int Multiply(int a, int b)
        {
            Console.WriteLine("\nProduct: "+ (a * b));
            return a* b;
        }
        public static int Divide(int a, int b)
        {
            Console.WriteLine("\nDivision: "+ (a / b));
            return a/b;
        }
    }



    //----------------------------  1. UNICAST DELEGATES.. -------------------------------------
    /*
    public class HelloWorld
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first numbers:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int b = int.Parse(Console.ReadLine());
            
          // ---------------- (i)
            // STRAIGHT FORWARD USAGE OF DELEGATE
            // MathOperation op = Operations.Multiply; //instantiate delegate with Multiply function reference
            // int result = op(a, b);
           
          // ---------------- (ii)
            //delegates with if conditions.. as we can't embed an instantiation in an if statement, declare delegate outside
            MathOperation op = null;
            if(a>b)
                op=Operations.Divide;
            else if(b>a)
                op=Operations.Multiply;
            else
                op=Operations.Add;

            op(a,b);

        }
    }
   */

    //----------------------------  1. MULTICAST DELEGATES.. -------------------------------------

    public class HelloWorld
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first numbers:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int b = int.Parse(Console.ReadLine());

            MathOperation op = Operations.Subtract;
            op+=Operations.Add;
            op+=Operations.Multiply;
            op+=Operations.Divide;
            int result = op(a,b);
            Console.WriteLine("last call result:" + result);

            Console.WriteLine("\n\n=====ANONYMOUS FUNCTIONS WITH DELEGATES====");
            //anynomous method  (that uses function body instead of reference to a pre defined function)
            //-------(i)   UNICAST DELEGATE USING ANONYMOUS FUNCTION
            ForAnonymousDelegate del1 = delegate
            {
                Console.WriteLine("Hey! anynomous method there. I am void");
            };
            del1();

            ForAnonymousDelegate2 del2 = delegate (int a)
            {
                Console.WriteLine("Hey! anynomous method there. I return int and take an int which is: "+ a);
                return a;
            };
            int anonymousResult = del2(5);

            //-------(ii)  MULTICAST DELEGATE USING ANONYMOUS FUNCTION

            ForAnonymousDelegate Multidel = delegate
            {
                Console.WriteLine("Hey! anynomous method there. I am first reference to it");
            };
            Multidel += delegate
            {
                Console.WriteLine("Hey! anynomous method there.  I am second reference to it");
            };
            Multidel();



        }
    }
}