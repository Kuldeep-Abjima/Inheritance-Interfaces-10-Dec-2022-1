 using System;
using Practice1.HR;

namespace Practice1
{
    public class practice{
        static void Main (string[] args)
        {
            Console.WriteLine("Creating the employee");
            Console.WriteLine("--------------------\n");
            
            Manger kuldeep = new Manger("kuldeep", "Singh", "ksingh2243@gmail.com", new DateTime(2001, 12, 04), 25);
            IEmployee Aman = new Manger("Aman", "Sing", "A@Gmail.com", new DateTime(2001, 12, 11), 25);
            JuniorResearcher tony = new JuniorResearcher("tony", "stark", "starktony@Stark.com", new DateTime(2002, 12, 04),65);
            Manger Test = kuldeep;

            kuldeep.DisplayEmployeeDetails();
            kuldeep.PerformWork();
            kuldeep.PerformWork();
            kuldeep.PerformWork();
            kuldeep.PerformWork();
            kuldeep.PerformWork();
            kuldeep.PerformWork();
            kuldeep.RecieveWage();
            kuldeep.GiveBonus();





            tony.researchNewPieTaste(15);
            tony.RecieveWage();



            Aman.DisplayEmployeeDetails();
            Aman.PerformWork();
            Aman.PerformWork();
            Aman.PerformWork();
            Aman.PerformWork();
            Aman.PerformWork();
            Aman.GiveBonus();

            
            
            Console.ReadLine();
        }

    }
}