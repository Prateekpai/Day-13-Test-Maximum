using System;
namespace FindMaxNumber
{
    public class Program
    {
        public static void Main()
        {

            double N1 = 56.63;

            double N2 = 78.26;

            double N3 = 98.12;


            if (N1 >= N2 && N1 >= N3)
            {
                Console.WriteLine(N1 + " is Max");

            }
            if (N2 >= N1 && N2 >= N3)
            {
                Console.WriteLine(N2 + " is Max");
            }
            if (N3 >= N1 && N3 >= N2)
            {
                Console.WriteLine(N3 + " is Max");
            }


        }
    }
}
