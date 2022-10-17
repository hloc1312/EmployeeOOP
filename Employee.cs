using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Employee_OOP_2
{
    internal abstract class Employee
    {
        public string employeeCode;
        protected string name;
        protected int baseSalary;
        protected double levelNumber;
        protected DateTime onboardDate;
        public string teamID;
        public double Salary()
        {
            var workingDay = GetDay();
            double totalSalary = (double)(baseSalary * workingDay * levelNumber);
            return totalSalary;
        }

        public string position;

        public List<Employee> listEmployee;
        protected int GetDay()
        {
            DateTime dt2 = DateTime.Now;
            TimeSpan ts;
            ts = dt2 - onboardDate;
            return ts.Days;
        }

        public void Nhap()
        {
           

            while (true)
            {
                try
                {
                    Console.Write("\nName: ");
                    name = Console.ReadLine();
                    Regex regex = new Regex(@"^[a-zA-Z]+$");

                    if (regex.IsMatch(name))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please input letter");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error is: " + e);
                }
            }
            
            while (true)
            {
                try
                {
                    Console.Write("\nBase Salary: ");
                    baseSalary = int.Parse(Console.ReadLine());
                    Regex regex = new Regex("^[0-9]+$");
                    if (regex.IsMatch(baseSalary.ToString()))
                    {
                        break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error is: " + e);
                }

            }

            while (true)
            {
                try
                {
                    Console.Write("\nLevel Number: ");
                    levelNumber = double.Parse(Console.ReadLine());
                    Regex regex = new Regex(@"^\d*\.{0,1}\d+$");
                    if (regex.IsMatch(levelNumber.ToString()))
                    {
                        break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error is: " + e);
                }

            }
            while (true)
            {
                try
                {
                    Console.Write("\nOnboard date yyyy/mm/dd: ");
                    onboardDate = DateTime.Parse(Console.ReadLine());
                    //Regex regex = new Regex(@"(19|20|21)\d\d[-](0[1-9]|1[012])[-](0[1-9]|[12][0-9]|3[01])");
                    DateTime dt;
                    DateTime.TryParseExact(onboardDate.ToString(), "yyyy/MM/dd", null, System.Globalization.DateTimeStyles.None, out dt);
                    if ((dt == DateTime.MinValue))
                    {
                        break;
                    }
                 

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error is: " + e);
                }

            }

           
        }

        public void Xuat()
        {
           
            Console.WriteLine($"\nEmployee Code: {employeeCode} - Name: {name} - Base Salary: {baseSalary.ToString("N0")} - Level Number: {levelNumber} - Onboard date: {onboardDate} - Position: {position} - TeamID: {teamID}");
            
        }

        public string GetID()
        {
            return employeeCode;
        }
        
       
        
      
    }
}
