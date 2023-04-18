using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordScrambler
{
    class ProgramLearn
    {

        //VALUE TYPES AND REFERENCE TYPES
        static void Main(string[] args)
        {
            int a = 10;
            ChangeNumber(a);
            Console.WriteLine(a);
        }
        static void ChangeNumber(int a)
        {
            a = 90;
        }
    }
}
