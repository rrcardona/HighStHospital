using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStHospitalProject
{
    class Surgeon:Employee
    {
        private string specialtyArea;
        

        public Surgeon(string employeeName, int employeeNumber, string specialtyArea, bool isWorking)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.specialtyArea = specialtyArea;
            this.isWorking = isWorking;
            
        }
        public override void PrintStatus()
        {
              
            Console.Write(employeeName + "\t");
            Console.Write(EmployeeNumber + "\t");
            Console.Write(specialtyArea + "\t" + "\t");
            Console.Write(isWorking + "\n");
        }
        public override void DisplayWorking()
        {
            if(isWorking ==true)
            {
                Console.WriteLine(employeeName + " is operating now");
            }
        }

    }
}
