using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.HR
{
    public class Manger : Employee
    {
        public Manger(string first, string last, string em, DateTime db, double rate) : base(first,  last, em, db, rate)
        {

        }
        public void attendManagementMeeting()
        {
            NumberOfHourWork += 10;
            Console.WriteLine($"Manager {FirstName} {LastName} is attending the meeting Email.");
        }
        public override double RecieveWage()
        {
            Wage = NumberOfHourWork * HourlyWage;
            Console.WriteLine($"wage for {NumberOfHourWork} hours of work is  {Wage}");
            NumberOfHourWork = 0;
            return Wage;

        }
        public override void GiveBonus()
        {
            if(NumberOfHourWork > 5)
            {
                Console.WriteLine($"{FirstName} {LastName} you recieved bonus of Rs 500");
            }
            else
            {
                Console.WriteLine($"{FirstName} {LastName} you recieved bonus of Rs 300");
            }
        }
    }
}
