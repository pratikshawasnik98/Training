using System;

namespace BaseClassConstructor
{
    class Token
    {
        protected  Token (String Name)
        {
            Console.WriteLine("Base Class Constructor = Name : " + Name);
        }
    }
    class CommentToken:Token
    {
        public CommentToken(String Name): base(Name)
        {
            Console.WriteLine("Derived class Constructor + Name :" +Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CommentToken cmttoken = new CommentToken("ABC");
            Console.ReadKey();
        }
    }
}
