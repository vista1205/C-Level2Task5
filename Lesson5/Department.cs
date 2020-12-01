using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public class Department
    {
        public string NameDep { get; set; }
        public Department (string nameDep)
        {
            NameDep = nameDep;
        }
        public override string ToString()
        {
            return NameDep;
        }
    }
}
