using System;
using System.Collections.Generic;
using System.Text;

namespace OopsCsharpAssignment3
{
    class Class1
    {
        public static void Main(string[] args)
        {
            //Employee emp = new Employee(100,"Bithi",10000);
            //emp.display();
            //emp.GROSSCALCULATE();
              // emp.CalculateSalary();
            //Employee emp1 = new Manager(100, "Bithi", 10000);
            //emp1.display();
           
            //emp1.CalculateSalary();
       Manager m1 = new Manager(100, "Bithi", 10000);
            m1.ManagerGROSSSALARY();
            m1.CalculateSalary();


            //emp = new Manager(101, "Bithi", 20000);


        }
        


    }
}
