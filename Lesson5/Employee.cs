using Lesson5_Wpf001.Control;
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
        public Department Department { get; set; }
        public Gender Gender { get; set; }

        public Employee(string fio, string mail, Department department, Gender gender)
        {
            Mail = mail;
            FIO = fio;
            Department = department;
            Gender = gender;
        }
    }
}
