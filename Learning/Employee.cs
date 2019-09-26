using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Employee : BaseClass
    {
        private string surname;

        public Employee(string employeeName, string surname, int employeeId)
        {
            this.Name = employeeName;
            this.surname = surname;
            this.Id = employeeId;
        }
    }
}
