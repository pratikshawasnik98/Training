using System;
namespace divide_testing
{
    class Program
    {
        static void Main(string[] args)
        {
            divide obj = new divide();
            obj.solution(100,2);
            Console.ReadKey();  
        }
    }
    public class divide
    {
        public int solution(int a,int b)
        {
            int res;
            res = a / b;
            Console.WriteLine(res);
            return res;
        }
    }
}
