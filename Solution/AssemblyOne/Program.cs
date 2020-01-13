using System;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            Console.WriteLine(Employee.companyNameInternal);
            Console.WriteLine(Employee.companyNameProtectedInternal);
            Console.WriteLine(Employee.companyNamePublic);
            Console.WriteLine(Employee.companyNamePrivate);
            Console.WriteLine(Employee.companyNameProtected);
            Console.WriteLine(Employee.companyNamePrivateProtected);


            employee.employeeNameInternal = "test";
            employee.employeeNameProtectedInternal = "test";
            employee.employeeNamePublic = "test";
            employee.employeeNamePrivate = "test";
            employee.employeeNameProtected = "test";
            employee.employeeNamePrivateProtected = "test";


            employee.EmployeeDataInternal();
            employee.EmployeeDataProtectedInternal();
            employee.EmployeeDataPublic();
            employee.EmployeeDataProtected();
            employee.EmployeeDataPrivate();
            employee.EmployeeDataPrivateProtected();
        }
    }
}
