using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordScrambler
{
    class Program
    {

        //VALUE TYPES AND REFERENCE TYPES
        static void Main(string[] args)
        {
            Person person = new Person("Nitesh", "Kumar");
            Person newPerson = person ?? new Person("Default", "Person");
            Console.WriteLine(newPerson.FirstName + " " + newPerson.LastName);

        }
    }
}
