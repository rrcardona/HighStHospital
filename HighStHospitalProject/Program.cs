using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighStHospitalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("High St Hospital Employees:");
            Doctor newDoctor = new Doctor("Michael", 234, "Heart", false);
            Nurse newNurse = new Nurse("Nancy", 247, true,13);
            Administrator newAdministrator = new Administrator("Amy", 147, "Business", false);
            Surgeon newSurgeon = new Surgeon("Dr Kudi", 1, "Surgeon", true);
            Receptionist newReceptionist = new Receptionist("Rachel", 42, "Office", true);
            Janitor newJanitor = new Janitor("Jerry", 654, "Maintenance", true);

            newDoctor.PrintStatus();
            newNurse.PrintStatus();
            newAdministrator.PrintStatus();
            newSurgeon.PrintStatus();
            newReceptionist.PrintStatus();
            newJanitor.PrintStatus();
            Console.WriteLine();
            newNurse.DisplayWorking();
            newReceptionist.DisplayWorking();
            newJanitor.DisplayWorking();
            newSurgeon.DisplayWorking();

        }
    }
}
