using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.HR
{
     public class StoreManger : Employee
    {
        public StoreManger(string first, string last, string em, DateTime db) : base(first, last, em, db)
        {

        }
        public override double RecieveWage()
        {
            Wage = NumberOfHourWork * HourlyWage;
            Console.WriteLine($"wage for {NumberOfHourWork} hours of work is  {Wage}");
            NumberOfHourWork = 0;
            return Wage;

        }
    }
}
