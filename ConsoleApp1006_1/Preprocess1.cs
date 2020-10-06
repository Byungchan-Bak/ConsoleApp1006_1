using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1006_1
{
    class Preprocess1
    {
        static void Main()
        {
#if REAL
            string name = Console.ReadLine();
            string pwd = Console.ReadLine();
#endif
#if DEBUG
            string name = "홍길동";
            string pwd = "1234";
#endif
            Trace.WriteLine(name);
            Console.Read();
        }
    }
}
