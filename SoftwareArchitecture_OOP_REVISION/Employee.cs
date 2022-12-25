using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareArchitecture_OOP_REVISION
{
    public class Employee
    {
        //State
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime EmployeeDateOfBirth { get; set; }
        public int DaysOffAvailable { get; set; }

        // Let's build a few constuctors
        // (Remember overloading?)
        public Employee()
        {

        }

        public Employee(int employeeId, 
            string employeeName, 
            DateTime employeeDateOfBirth, 
            int daysOffAvailable)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            EmployeeDateOfBirth = employeeDateOfBirth;
            DaysOffAvailable = daysOffAvailable;
        }



        //Behavior
        public string RequestLeave(int requestedDays)
        {
            string decision = "Request rejected";
            if(requestedDays > 0 && DaysOffAvailable >= requestedDays)
            {
                DaysOffAvailable -= requestedDays;
                decision = "Request approved";
            }
            return decision;
        }

        public string EmployeeReport()
        {
            return $"Employee ID: {EmployeeId}\n" +
                $"Employee Name: {EmployeeName}\n" +
                $"Date Of Birth: {EmployeeDateOfBirth.ToShortDateString()}";
        }
    }
}
