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

            Employee employee = new Employee();
            Employee developer = new Employee();

            employee.employeeNameInternal = "x";
            employee.employeeNameProtectedInternal = "x";
            employee.employeeNamePublic = "x";
            //employee.employeeNameProtected = "x"; - ??
            //employee.employeeNameRivateProtected = "x"; - ??

            employee.EmployeeDataInternal();
            employee.EmployeeDataProtectedInternal();
            employee.EmployeeDataPublic();
            //Developer.EmployeeDataProtected(); - ??
            //Employee.EmployeeDataPrivateProtected(); - ??
        }
    }
}
