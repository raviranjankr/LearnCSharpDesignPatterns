using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee empA = new TeamMember("Emp A", 50000);
            Employee empB = new TeamMember("Emp B", 40000);
            TeamLead teamLead = new TeamLead();
            teamLead.Add(empA);
            teamLead.Add(empB);               
            Console.WriteLine($"Total List of Employee reporting to TeamLead {teamLead.GetEmployeeData()}");
            teamLead.Remove(empA);
            Console.WriteLine($"Now Total List of Employee  reporting to TeamLead {teamLead.GetEmployeeData()}");
            Console.ReadKey();
        }
    }
}
