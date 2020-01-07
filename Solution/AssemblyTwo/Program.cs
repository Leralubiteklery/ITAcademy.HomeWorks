using AssemblyOne;
using System;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            Console.WriteLine(Employee.companyNamePublic);
            Console.WriteLine(Employee.companyNameInternal);
            Console.WriteLine(Employee.companyNameProtectedInternal);
            Console.WriteLine(Employee.companyNamePrivate);
            Console.WriteLine(Employee.companyNameProtected);
            Console.WriteLine(Employee.companyNamePrivateProtected);

            employee.employeeNamePublic = "test";
            employee.employeeNameInternal = "test";
            employee.employeeNameProtectedInternal = "test";
            employee.employeeNamePrivate = "test";
            employee.employeeNameProtected = "test";
            employee.employeeNamePrivateProtected = "test";

            employee.EmployeeDataPublic();
            employee.EmployeeDataInternal();
            employee.EmployeeDataProtectedInternal();
            employee.EmployeeDataProtected();
            employee.EmployeeDataPrivate();
            employee.EmployeeDataPrivateProtected();

        }
    }
}
