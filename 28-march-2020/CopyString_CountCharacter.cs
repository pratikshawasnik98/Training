using System;

namespace CopyString_CountCharacter
{
    class CopyString
    {
        public string copyStringName;
        public void copy(string name)
        {
            copyStringName = name;
                Console.WriteLine("Print copy Name : " + copyStringName);
                Console.WriteLine("Print the character is to be copied : " + copyStringName.Length);
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string stringName;
             Console.WriteLine("Enter a string ");
              stringName = Console.ReadLine();
            CopyString copyObj = new CopyString();
            copyObj.copy(stringName);
            Console.ReadKey();
        }
    }
}
