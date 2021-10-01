using System;

namespace dotNET_Lab1
{
    class Manager : Employee
    {
        public Manager(string fname, string lname, DateTime sdate, DateTime edate, double sal)
        {
            Id = Guid.NewGuid();
            FirstName = fname;
            LastName = lname;
            StartDate = sdate;
            EndDate = edate;
            Salary = sal;
        }

        public override string Salutation()
        {
            return "Hello manager";
        }
    }
}
