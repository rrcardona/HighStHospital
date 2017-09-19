using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStHospitalProject
{
    class Doctor:Employee
    {
        private string specialtyArea;

        public Doctor (string employeeName, int employeeNumber, string specialtyArea, bool isWorking)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.specialtyArea = specialtyArea;
            this.isWorking = isWorking;

        }
        public override void PrintStatus()
        {
            Console.Write(this.employeeName + "\t");
            Console.Write(this.employeeNumber + "\t");
            Console.Write(this.specialtyArea + "\t" + "\t");
            Console.Write(this.isWorking + "\n");
        }

    }
}
