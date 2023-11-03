using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMethodsExcercises.Entities
{
    public class Person
    {
     
        public string FirstName { get; set; }
        public string Lastname { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            Lastname = lastName;
        }


    }
}
