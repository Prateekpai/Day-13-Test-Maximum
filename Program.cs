using System;
namespace FindMaxNumber
{
    public class Program
    {
        public static void Main()
        {

            string N1 = "Apple";

            string N2 = "Banana";

            string N3 = "Orange";


            if (N1.CompareTo(N2)>0 && N1.CompareTo(N3) > 0)
            {
                Console.WriteLine(N1 + " is Max");

            }
            if (N2.CompareTo(N1) >0 && N2.CompareTo(N3) > 0)
            {
                Console.WriteLine(N2 + " is Max");
            }
            if (N3.CompareTo(N1) > 0 && N3.CompareTo(N2)>0)
            {
                Console.WriteLine(N3 + " is Max");
            }


        }
    }
}
