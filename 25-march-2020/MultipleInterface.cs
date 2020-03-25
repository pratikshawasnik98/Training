using System;

namespace MultipleInterface
{
    //implicity Interface
    interface IToken
    {
        string Name();
    }
    interface IVisitable
    {
        void Accept(String n);
    }
    class Token:IToken,IVisitable
    {
        public string Name()
        {
            return "Hello from name";
        }
        public void Accept(string n )
        {
            Console.WriteLine("Name " + n);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Token token = new Token();
            Console.WriteLine(token.Name());

            token.Accept("ABC");
            Console.ReadKey();
        }
    }
}
