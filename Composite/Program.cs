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
            Employee teamLead = new TeamLead("Emp C", 70000);
            teamLead.Add(empA);
            teamLead.Add(empB);
            Console.WriteLine(teamLead.GetEmployeeData());
            Console.ReadKey();
        }
    }
}
