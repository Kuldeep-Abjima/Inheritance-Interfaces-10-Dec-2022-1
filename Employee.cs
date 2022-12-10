using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.HR
{
    public abstract class  Employee : IEmployee

    {

        private string firstName;
        private string lastName;
        private string email;

        private int numberOfHourWork;
        private double wage;
        private double hourlyWage;
        private DateTime birthday;

        public string FirstName
        {
            get
            {
                return firstName;

            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string Email
        {
            get
            {
                return email;

            }
            set
            {
                email = value;
            }
        }
        public int NumberOfHourWork
        {
            get
            {
                return numberOfHourWork;

            }
            set
            {
                numberOfHourWork = value;
            }
        }
        public double Wage
        {
            get
            {
                return wage;

            }
            set
            {
                if (value < 0)
                {
                    wage = 0;
                }
                else
                {
                    wage = value;
                };
            }
        }
        public double HourlyWage
        {
            get
            {
                return hourlyWage;
            }
            set
            {
                hourlyWage = value;
            }
        }
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }
        
        public Employee(string first, string last, string em, DateTime db, double rate)
        {
            FirstName = first;
            LastName = last;
            Email = em;
            Birthday = db;
            HourlyWage = rate;
        }
        public Employee(string first, string last, string em, DateTime db) : this(first, last, em, db, 0)
        {
        }
        public void PerformWork()
        {
            numberOfHourWork++;
            Console.WriteLine($"{FirstName}{LastName} is Working : ");
        }
        public void StopWork()
        {
            Console.WriteLine($"{FirstName}{LastName} is stop Working : ");
        }
        public virtual double RecieveWage()
        {
            Wage = NumberOfHourWork * HourlyWage;
            Console.WriteLine($"wage for {NumberOfHourWork} hours of work is  {Wage}");
            NumberOfHourWork = 0;
            return Wage;
        }
      
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\n firstName : {FirstName} \n lastName : {LastName} \n birthday : {Birthday.ToShortDateString()} \n email : {Email}");
        }
        public virtual void GiveBonus()
        {
            Console.WriteLine($"{FirstName} {LastName} is recievder generic Bonus of Rs 100");

        }

        public int CompareTo(object? obj)
        {
            var otherEmployee = (Employee)obj;
            if(FirstName == otherEmployee.FirstName)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
