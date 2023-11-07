using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var isb = new Expertion();

                Console.WriteLine(isb.isBallance("(slam)"));

                var stack = new MyStack<int>();
            }
            catch (IndexOutOfRangeException)
            {

                Console.WriteLine("is stack empty");
            }


            Console.ReadLine();

        }
    }
}
