using System;

namespace dotNET_Lab1
{
    class Architect: Employee
    {
        public Architect(string fname, string lname, DateTime sdate, DateTime edate, double sal)
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
            return "Hello architect";
        }

    }
}
