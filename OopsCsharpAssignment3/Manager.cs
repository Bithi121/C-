using System;
using System.Collections.Generic;
using System.Text;

namespace OopsCsharpAssignment3
{
    class Manager : Employee, Interface1
    {
        double PetrolAllowance;
        double foodAllowance;
        double otherAllowance;
        double grosssalary;

        public void ManagerGROSSSALARY()
        {
            PetrolAllowance = 0.08 * Salary;
            foodAllowance = 0.13 * Salary;
            otherAllowance = 0.03 * Salary;
            grosssalary = Salary + hra + ta + da + PetrolAllowance + foodAllowance + otherAllowance;

            Console.WriteLine("GrossSallary is" + grosssalary);
        }

        public override void CalculateSalary()
        {
            Double gs = grosssalary - (PetrolAllowance + foodAllowance + otherAllowance);
            pf = 0.1 * gs;
            Console.WriteLine("PF is:" + pf);
            tds = 0.18 * gs;
            Console.WriteLine("TDS is:" + tds);
            NetSalary = gs - (pf + tds);
            Console.WriteLine("NetSalary is:" + NetSalary);
        }

        public Manager(int EmpNo, string EmpName, double Salary) : base(EmpNo, EmpName, Salary)
        {
         
        }
        public new void display()
        {
            Console.WriteLine("The employee id is:" + EmpNo);
            Console.WriteLine("The employee name is:" + EmpName);
            Console.WriteLine("The employee salary is:" + Salary);
      
        }
    }
}
