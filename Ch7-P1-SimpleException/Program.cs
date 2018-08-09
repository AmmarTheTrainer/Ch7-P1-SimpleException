using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch7_P1_SimpleException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Exception Example *****");

            Console.WriteLine("=> Creating a car and stepping on it!");
            Car myCar = new Car(" Suzuki FX ", 20);
            myCar.CrankTunes(true);

            try
            {
                for (int i = 0; i < 10; i++)
                    myCar.Accelerate(10);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n*** Error! ***");

                Console.WriteLine("\nMember name: {0}", e.TargetSite);
                Console.WriteLine("Class defining member: {0}", e.TargetSite.DeclaringType);
                Console.WriteLine("Member type: {0}", e.TargetSite.MemberType);

                Console.WriteLine("\nMessage: {0}", e.Message);
                Console.WriteLine("Source: {0}", e.Source);

                Console.WriteLine("\n Stack < StackTrace Property > : {0}", e.StackTrace);
            }

            // The error has been handled, processing continues with the next statement.
            Console.WriteLine("\n***** Out of exception logic *****");

            Console.ReadLine();
        }
    }
}
