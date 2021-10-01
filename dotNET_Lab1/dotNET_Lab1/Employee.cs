using System;

namespace dotNET_Lab1
{
    internal abstract class Employee
    {
        protected Guid Id { get; set; }
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected DateTime StartDate { get; set; }
        protected DateTime EndDate { get; set; }
        protected double Salary { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public bool IsActive()
        {
            if (DateTime.Compare(EndDate, StartDate) >= 0)
            {
                return true;
            }
            else return false;
        }

        public abstract string Salutation();
        //am ales ca Salutation sa fie metoda abstracta, pentru ca Employee este folosita ca base class pentru Manager si Architect
        //si clasa Employee nu are nevoie de o defenitie a acestei metode
    }
}