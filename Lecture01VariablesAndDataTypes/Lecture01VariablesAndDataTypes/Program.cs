using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture01VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {


            // print statement
            Console.WriteLine( "Salam Alikum" );
            Console.WriteLine( "Salam Alikum" );
            Console.WriteLine( "Salam Alikum" );
            Console.WriteLine( "Salam Alikum" );
            Console.WriteLine( "Salam Alikum" );
            Console.WriteLine( "Salam Alikum" );
            Console.WriteLine( "Salam Alikum" );



            //print statement without line break
            Console.Write("Hibaa");
            Console.WriteLine(" adnan");


            //string data type 
            //datatype variablename ="";
            string str = "ammarah asif";
            Console.Write(str);


            //initialization and  declaration

            //declare
            string str1 ;

            //initialization
           

            //initialization + declaration

            string str2 = "ammarah asif";



            int amm = 1234;

            if (amm%2==0)
            {
                str1 = "even";
               
            }
            else
            {
                str1 = "odd";
            }
            Console.Write(amm + str1);









            Console.ReadKey();
        }
    }
}
