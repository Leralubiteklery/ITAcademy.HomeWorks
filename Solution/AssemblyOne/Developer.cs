using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    class Developer : Employee
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Employee.companyNameInternal);
            Console.WriteLine(Employee.companyNamePrivateProtected);
            Console.WriteLine(Employee.companyNameProtected);
            Console.WriteLine(Employee.companyNameProtectedInternal);
            Console.WriteLine(Employee.companyNamePublic);
            //Console.WriteLine(Employee.companyNamePrivate); cannot access private member from another class

            Employee employee = new Employee();

            employee.employeeNameInternal = "x";
            employee.employeeNameProtectedInternal = "x";
            employee.employeeNamePublic = "x";
            //employee.employeeNamePrivate = "x"; cannot access private member from another class

            employee.EmployeeDataInternal();
            employee.EmployeeDataProtectedInternal();
            employee.EmployeeDataPublic();
            //employee.EmployeeDataPrivate(); cannot access private member from another class

            static void ShowProtected()
            {
                Employee employee = new Employee();
                //employee.employeeNameProtected = "x"; ??
                //employee.employeeNameRivateProtected = "x"; ??

                //employee.EmployeeDataProtected(); 
                //employee.EmployeeDataPrivateProtected(); ??
            }
        }
    }
}
