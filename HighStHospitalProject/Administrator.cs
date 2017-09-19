using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStHospitalProject
{
    class Administrator:Employee
    {
        private string department;

        public Administrator(string employeeName, int employeeNumber, string department, bool isWorking)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;
            this.isWorking = isWorking;
        }
        public override void PrintStatus()
        {
            Console.Write(employeeName + "\t");
            Console.Write(EmployeeNumber + "\t");
            Console.Write(department + "\t");
            Console.Write(isWorking + "\n");
        }
       
    }
}
