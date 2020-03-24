using System;

namespace pattern
{
    class Program
    {
        static void Main(string[] args)
        {/*
            for(int i=0;i<4;i++)
            {
                Console.Write(" * ");
                for (int j = 1; j < 3; j++)
                {
                    if (i == 1 || i == 2 || i==3)
                    {
                        if (j == 1 || j == 2)
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        Console.Write(" * ");
                    }

                }
                    /*
                    if(i==1 && i==2 && i==3)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(" * ");
                    }
                    for (int j = 1; j < 10; j++)
                    {
                        if (i == 2 || j == 2  || i==3 || j == 3)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }*/
                    //    Console.Write(" % ");
                    //}
                    Console.WriteLine();
            //}


            for (int i = 0; i <4; i++)
            {
                Console.Write(" * ");
                for (int j = 1; j <= 18; j++)
                {
                    //
                    if (i == 1 || i == 2 || i == 3)
                    {
                        if (j == 1 || j == 2)
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        Console.Write(" * ");
                    }
                    if (j == 4 || j==3)
                    {
                        Console.Write("*");
                    }
            }
                Console.WriteLine();
            }



                Console.ReadKey();
        }
    }
}
