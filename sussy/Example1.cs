using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example1
{
    class Program
    {
        public static void Start()
        {
           throw new InvalidProgramException(System_.Error as string);
        }
    }

    class System_
    {
        private static string actualrun = payload.run();

        public static object Error;
        
    }

    class payload
    {
        public static string run()
        {
            Console.Write("floppa");
            Console.ReadLine();
            return "";
        }
    }

}
