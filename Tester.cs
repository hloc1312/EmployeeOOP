using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_OOP_2
{
    internal class Tester : Employee
    {
        public Tester()
        {
            position = "Tester";
        }
        public Tester(int _employeeCode, string _name, int _baseSalary, double _levelNumber, DateTime _onboardDate, int _teamID)
        {
            this.employeeCode = _employeeCode;
            this.name = _name;
            this.baseSalary = _baseSalary;
            this.levelNumber = _levelNumber;
            this.onboardDate = _onboardDate;
            this.position = "Tester";
            this.teamID = _teamID;

        }
        //protected override double Salary()
        //{
        //    var workingDay = GetDay();
        //    double totalSalary = (double)(baseSalary * workingDay * levelNumber);
        //    return totalSalary;
        //}
    }
}
