using System;

namespace binomial_coefficient_table
{
    class binomialCoefficient
    {
        /*public void binomialCoeff(float n1,float k1)
        {
            if(k1 == 0 || k1 == n1)
               // return 1;
            n1 - 1, k1 - 1 + n1 - 1, k1;
            Console.WriteLine()
        }
        */
        public static int binomialCoeff(int n, int k)
        {
            int[] C = new int[k + 1];

            // nC0 is 1 
            C[0] = 1;

            for (int i = 1; i <= n; i++)
            {
                // Compute next row of pascal  
                // triangle using the previous 
                // row 
                for (int j = Math.Min(i, k);
                                  j > 0; j--)
                    C[j] = C[j] + C[j - 1];
            }
            return C[k];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a value of n:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value of k:");
            int k= int.Parse(Console.ReadLine());

            Console.WriteLine("Value of C(" + n+ "," + k + ") is "+ binomialCoefficient.binomialCoeff(n, k));
            
        }
    }
}
