using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStHospitalProject
{
    class Nurse:Employee
    {
    
        private int numberOfPatients;

        public Nurse (string employeeName, int employeeNumber, bool isWorking, int numberOfPatients)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.isWorking = isWorking;
            this.numberOfPatients = numberOfPatients;
        }
        public override void PrintStatus()
        {
            Console.Write(employeeName + "\t");
            Console.Write(EmployeeNumber + "\t");
            Console.Write(numberOfPatients + "\t" + "\t");
            Console.Write(isWorking + "\n");
        }
        public override void DisplayWorking()
        {
            if (isWorking == true)
            {
                Console.WriteLine(employeeName + " has " + numberOfPatients + " patients");
            }
        }

    }
}
