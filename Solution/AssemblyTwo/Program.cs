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
            //Console.WriteLine(Employee.companyNameInternal); cannot acces from another assembly
            //Console.WriteLine(Employee.companyNameProtectedInternal); cannot access from another assembly unless its class is derived from containg class
            //Console.WriteLine(Employee.companyNamePrivate); cannot access private member from another class
            //Console.WriteLine(Employee.companyNameProtected); cannot access unless its class is derived from containg class
            //Console.WriteLine(Employee.companyNamePrivateProtected); cannot access unless its class is derived from containg class

            employee.employeeNamePublic = "test";
            //employee.employeeNameInternal = "test"; cannot acces from another assembly
            //employee.employeeNameProtectedInternal = "test"; annot access from another assembly unless its class is derived from containg class
            //employee.employeeNamePrivate = "test"; cannot access private member from another class
            //employee.employeeNameProtected = "test"; cannot access unless its class is derived from containg class
            //employee.employeeNamePrivateProtected = "test"; cannot access unless its class is derived from containg class

            employee.EmployeeDataPublic();
            //employee.EmployeeDataInternal(); cannot acces from another assembly
            //employee.EmployeeDataProtectedInternal(); annot access from another assembly unless its class is derived from containg class
            //employee.EmployeeDataProtected(); cannot access unless its class is derived from containg class
            //employee.EmployeeDataPrivate(); cannot access private member from another class
            //employee.EmployeeDataPrivateProtected(); cannot access unless its class is derived from containg class

        }
    }
}
