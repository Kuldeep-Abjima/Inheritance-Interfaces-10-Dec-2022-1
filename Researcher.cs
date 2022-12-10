using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.HR
{
    public class Researcher : Employee
    {
        public Researcher(string first, string last, string em, DateTime db, double rate) :base( first, last, em, db, rate)
        {
            
        }
        public void researchNewPieTaste(int researchHour)
        {
            NumberOfHourWork += researchHour;
            Console.WriteLine($"{FirstName} {LastName} is invented the new Pie Taste");
        }
        public override double RecieveWage()
        {
            Wage = NumberOfHourWork * HourlyWage;
            Console.WriteLine($"wage for {NumberOfHourWork} hours of work is  {Wage}");
            NumberOfHourWork = 0;
            return Wage;

        }

    }
    public class JuniorResearcher : Researcher
    {
        public JuniorResearcher(string first, string last, string em, DateTime db, double rate) : base( first, last, em, db,rate)
        {

        }
    }
}
