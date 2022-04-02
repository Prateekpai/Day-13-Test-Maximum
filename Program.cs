using System;
namespace FindMaxNumber
{
    public class Program
    {
        public static void Main ()
        {

            int N1 = 56;

            int N2 = 68;

            int N3 = 78;
            

            if (N1>=N2 && N1>=N3)
            {
                Console.WriteLine(N1 + " is Max");
                
            }
            if (N2>=N1 && N2>=N3)
            {
                Console.WriteLine(N2 + " is Max");
            }
            if (N3>=N1 && N3>=N2)
            {
                Console.WriteLine(N3 + " is Max");
            }
            

        }
    }
}
