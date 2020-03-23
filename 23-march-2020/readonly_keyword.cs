using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readonly_keyword
{
    class Program
    {/*// readonly keyword value change without construtor
        static void Main(string[] args)
        {
            simple s = new simple();
            string str = s.cname;
            Console.WriteLine("Name : " + str);
            Console.ReadKey();
        }
    }
    public class simple
    {
        public readonly string cname = "amit";

    }*/
     /*without readonly keyword value change without construtor
         static void Main(string[] args)
         {
             simple s = new simple();

             string str = s.cname;
             Console.WriteLine("Name : " + str);
             s.cname = "sumit";
             Console.WriteLine("Name : " + s.cname);
             Console.ReadKey();
         }
     }
     public class simple
     {
         public string cname = "amit";

     }*/
     /*// readonly keyword value change with construtor
        static void Main(string[] args)
        {

            simple s = new simple();
            string str = s.cname;
            Console.WriteLine("Name : " + str);
            Console.ReadKey();
        }
    }
    public class simple
    {
        public readonly string cname = "amit";
        
        public simple()//constructor
        {
            Console.WriteLine("Name :" + cname);
            cname = "abc";
        }
    }*/
       /*//with readonly keyword value change with get proerty
        static void Main(string[] args)
        {
            simple s = new simple();

            string str = s.customer_name;
            Console.WriteLine("Name : " + str);
            Console.ReadKey();
        }
    }
    public class simple
    {
        private string cname = "amit";
        public string customer_name
        {
            get
            {
                return cname;
            }
        }

    }*/
    //with readonly keyword value change with get & set proerty
        static void Main(string[] args)
{
student s = new student();
            Console.WriteLine("Enter roll number : ");
            s.roll_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter student Name : ");
            s.student_name = (Console.ReadLine());
            
            Console.WriteLine("Roll Number :  " + s.roll_no +  "\nStudent Name :" + s.student_name);
            Console.ReadKey();
    }
    }
    public class student 
{
        private int rno;
        private string sname;
        public int roll_no
    {
        get
        {
            return rno;
        }
            set
            {
                rno = value; ;
            }
        }
        public string student_name
        {
            get
            {
                return sname;
            }
            set
            {
                sname = value; ;
            }
        }
    }
}
