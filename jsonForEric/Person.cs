using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsonForEric
{
    class Person
    {
        public string FName { get; set; }
        public int Age { get; set; }
        public bool IsMale { get; set; }

        public Person(string fName, int age, bool isMale)
        {
            this.FName = fName;
            this.Age = age;
            this.IsMale = isMale;
        }
    }
}
