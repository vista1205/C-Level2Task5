using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public class Employee
    {
        public string FIO { get; set; }
        public string Mail { get; set; }
        Department Department { get; set; }

        public Employee(string fio, string mail, Department department)
        {
            Mail = mail;
            FIO = fio;
            Department = department;
        }
    }
}
