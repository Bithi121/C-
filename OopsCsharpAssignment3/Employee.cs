using System;
using System.Collections.Generic;
using System.Text;

namespace OopsCsharpAssignment3
{
    class Employee
    {
        public int EmpNo;
        public string EmpName;
        public double Salary, hra, ta, da, pf, tds, NetSalary, GrossSalary;

        public Employee(int EmpNo, string EmpName, double Salary)
        {
            if (EmpNo <= 0)
            {
                throw new Exception("EmpNo empty is ot allowed");

            }
            else
            {
                this.EmpNo = EmpNo;
            }
            if (string.IsNullOrEmpty(EmpName))
            {
                throw new Exception("EmpName empty is ot allowed");

            }
            else
            {
                this.EmpName = EmpName;
            }

            if (Salary <= 0)
            {
                throw new Exception("Salary empty is ot allowed");

            }
            else
            {
                this.Salary = Salary;
            }



        }
        public void HRACALCULATE()
        {
            if (Salary < 5000)
            {
                hra = 0.1 * Salary;

            }
            else if (Salary < 10000)
            {
                hra = 0.15 * Salary;
            }
            else if (Salary < 15000)
            {
                hra = 0.20 * Salary;
            }
            else if (Salary < 20000)
            {
                hra = 0.25 * Salary;
            }
            else
            {
                hra = 0.30 * Salary;
            }
            Console.WriteLine("HRA is:" + hra);
        }
        public void TACALCULATE()
        {
            if (Salary < 5000)
            {
                ta = 0.05 * Salary;

            }
            else if (Salary < 10000)
            {
                ta = 0.1 * Salary;
            }
            else if (Salary < 15000)
            {
                ta = 0.15 * Salary;
            }
            else if (Salary < 20000)
            {
                ta = 0.20 * Salary;
            }
            else
            {
                ta = 0.25 * Salary;
            }
            Console.WriteLine("TA is" + ta);
        }
        public void DACALCULATE()
        {
            if (Salary < 5000)
            {
                da = 0.15 * Salary;

            }
            else if (Salary < 10000)
            {
                da = 0.20 * Salary;
            }
            else if (Salary < 15000)
            {
                da = 0.25 * Salary;
            }
            else if (Salary < 20000)
            {
                da = 0.30 * Salary;
            }
            else
            {
                da = 0.35 * Salary;
            }
            Console.WriteLine("DA is:" + da);
        }
        public double GROSSCALCULATE()
        {
            GrossSalary = Salary + hra + ta + da;
            return GrossSalary;
        }
        public virtual void CalculateSalary()
        {
            pf = 0.1 * GrossSalary;
            Console.WriteLine("PF is:" + pf);
            tds = 0.18 * GrossSalary;
            Console.WriteLine("TDS is:" + tds);
            NetSalary = GrossSalary - (pf + tds);
            Console.WriteLine("NetSalary is:" + NetSalary);
        }
        public void display()
        {
            Console.WriteLine("The employee id is:" + EmpNo);
            Console.WriteLine("The employee name is:" + EmpName);
            Console.WriteLine("The employee salary is:" + Salary);
            Console.WriteLine("The employee Grosssalary is:" + GrossSalary);



        }
    }

}


  
