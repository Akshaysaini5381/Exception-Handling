using System;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second, result = 0;
            Console.Write("Enter the first number :");
            first = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number :");
            second = int.Parse(Console.ReadLine());
            /*
             *  first type 1
             *  
                        try
                        {

                        result = first / second;
                        Console.WriteLine(result);
                        }
                        catch (DivideByZeroException )
                        {
                            Console.WriteLine(o);

                        }
            */
            /* 
             *  second type 2
              try
             {

                 result = first / second;
                 Console.WriteLine(result);
             }
             catch (DivideByZeroException o)
             {
                 Console.WriteLine(o.Message);

             }*/


            try
            {

                result = first / second;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException o)
            {
                Console.WriteLine("hello");

            }
        }
    }
}
