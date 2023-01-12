using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFast
{
    internal class ImutableClass
    {
        public readonly string name ;

        public int Age { get; }
        public ImutableClass(string name,int age)
        {
            this.name = name;
            this.Age = age;
        }
    }
}
