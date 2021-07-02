using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example2
{
    class Program
    {
        public static void Start()
        {

            Stringcollection.Name = "we love floppa";
            Console.WriteLine(Stringcollection.Name);
            Console.ReadLine();

        }
    }
    class Stringcollection
    {
        private static string name;
        public static string Name
        {
            get
            {
                test.run();
                return name;
            }
            set
            {
                test.run();
                name = value;
            }
        }
    }

    class test
    {
        public static string run()
        {
            Console.Write("floppa");
            Console.ReadLine();
            return "";
        }
    }

}
