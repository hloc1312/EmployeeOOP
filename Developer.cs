﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_OOP_2
{
    internal class Developer : Employee
    {
        public Developer()
        {
            position = "Developer";
        }
        public Developer(string _employeeCode, string _name, int _baseSalary, double _levelNumber, DateTime _onboardDate, string _teamID)
        {
            this.employeeCode = _employeeCode;
            this.name = _name;
            this.baseSalary = _baseSalary;
            this.levelNumber = _levelNumber;
            this.onboardDate = _onboardDate;
            this.position = "Developer";
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
