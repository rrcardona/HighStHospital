using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStHospitalProject
{
    class Employee
    {
        protected string employeeName;
        protected int employeeNumber;
        protected bool isWorking;


        public string EmployeeName
        {
            get { return this.employeeName; }
        }
        public int EmployeeNumber
        {
            get { return this.employeeNumber; }
        }
        public bool IsWorking
        {
            get { return this.isWorking; }
           
        }

        public Employee()
        {

        }
        public Employee(string employeeName, int employeeNumber, bool isWorking)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.isWorking = isWorking;
        }

        public virtual void PrintStatus()
        {
            
        }
        public virtual void DisplayWorking()
        {

        }
    }



}
