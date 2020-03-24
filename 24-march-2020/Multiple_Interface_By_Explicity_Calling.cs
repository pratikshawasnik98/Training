using System;

namespace Multiple_Interface_By_Explicity_Calling
{
    //explicit Interface
    interface IToken
    {
        void Name();
    }
    interface IVisitable
    {
        void Accept(String n);
    }
    class Token : IToken, IVisitable
    {
        void IToken.Name()
        {
            Console.WriteLine("Hello");
            //return "Hello from name";
        }
        /*string IVisitable.Name()
        {
            Console.WriteLine("Hey");
        }*/
        void IVisitable.Accept(string n)
        {
            Console.WriteLine("Name " + n);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IToken token = new Token();
            //Console.WriteLine(token.Name());
            token.Name();

            //token.Accept("ABC");
            Console.ReadKey();
        }
    }
}
