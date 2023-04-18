using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordScrambler
{
    class Program
    {

        //readOnly vs Constant
        public const string myString = "Hey There";
        //public static readonly string myOtherString = "Hey there again";
        public readonly string myOtherString = "Hey there again";

        public readonly Person myPerson = new Person("A", "B");
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine(myString);
            Console.WriteLine(program.myPerson.FirstName);

        }
    }
}
