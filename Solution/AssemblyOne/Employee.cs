using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    public class Employee
    {
        public const string companyNamePublic = "FBI";
        protected const string companyNameProtected = "FBI";
        internal const string companyNameInternal = "FBI";
        protected internal const string companyNameProtectedInternal = "FBI";
        private const string companyNamePrivate = "FBI";
        private protected const string companyNamePrivateProtected = "FBI";

        public string employeeNamePublic;
        protected string employeeNameProtected;
        internal string employeeNameInternal;
        protected internal string employeeNameProtectedInternal;
        private string employeeNamePrivate;
        private protected string employeeNamePrivateProtected;

        public void EmployeeDataPublic()
        {
            Console.WriteLine(employeeNamePrivate);
        }

        protected void EmployeeDataProtected()
        {
            Console.WriteLine(employeeNamePublic);
        }

        internal void EmployeeDataInternal()
        {
            Console.WriteLine(employeeNamePublic);
        }

        protected internal void EmployeeDataProtectedInternal()
        {
            Console.WriteLine(employeeNameProtectedInternal);
        }

        private void EmployeeDataPrivate()
        {
            Console.WriteLine(companyNamePrivate);
        }

        private protected void EmployeeDataPrivateProtected()
        {
            Console.WriteLine(companyNameInternal);
        }
    }
}
