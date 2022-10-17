using shortid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_OOP_2
{
    internal class Company
    {
        public Employee employee;
        public List<Employee> listEmployees = new List<Employee>();
        public Team team;
        public List<Team> listTeam = new List<Team>();
        public void CreateDesigner()
        {
            employee = new Designer();
            string _employeeID;
            _employeeID = ShortId.Generate();
            employee.employeeCode = _employeeID;
            employee.Nhap();
            Console.WriteLine("Add Employee Success !");
            employee.Xuat();
            listEmployees.Add(employee);
        }

        public void CreateDeveloper()
        {
            employee = new Developer();
            string _employeeID;
            _employeeID = ShortId.Generate();
            employee.employeeCode = _employeeID;
            employee.Nhap();
            Console.WriteLine("Add Employee Success !");
            employee.Xuat();
            listEmployees.Add(employee);
        }

        public void CreateManager()
        {
            employee = new Manager();
            string _employeeID;
            _employeeID = ShortId.Generate();
            employee.employeeCode = _employeeID;
            employee.Nhap();
            Console.WriteLine("Add Employee Success !");
            employee.Xuat();
            listEmployees.Add(employee);
        }


        public void CreateTester()
        {
            employee = new Tester();
            string _employeeID;
            _employeeID = ShortId.Generate();
            employee.employeeCode = _employeeID;
            employee.Nhap();
            Console.WriteLine("Add Employee Success !");
            employee.Xuat();
            listEmployees.Add(employee);
        }

        public void CreateTeam()
        {
            team = new Team();
            string _teamID;
            _teamID = ShortId.Generate();
            team.teamID = _teamID;
            team.Nhap();
            Console.WriteLine("Add Team Success !");
            team.Xuat();
            listTeam.Add(team);
        }

        public void AddMemberToTeam()
        {
            Console.WriteLine("\n\nList team: ");
            foreach (var e in listTeam)
            {
                e.Xuat();
            }
            Console.Write("\n\nSelect teamID: ");
            string teamID = Console.ReadLine();
            int indexTeam = listTeam.FindIndex(item => item.teamID == teamID);


            Console.WriteLine("\n\nList employee: ");
            foreach (var e in listEmployees)
            {
                e.Xuat();
            }
            Console.Write("\n\nSelect employeeID: ");
            string employeeID = Console.ReadLine();
            int indexEmployee = listEmployees.FindIndex(item => item.employeeCode == employeeID);

            if (indexTeam != -1)
            {
                if (indexEmployee != -1)
                {
                    Console.WriteLine($"Add Success Employee ${listEmployees[indexEmployee].employeeCode} Into Team ${listTeam[indexTeam].teamID}");
                    listEmployees[indexEmployee].teamID = listTeam[indexTeam].teamID;
                }
                else
                {
                    Console.WriteLine("Not Found Employee");
                }
            }
            else
            {
                Console.WriteLine("Not Found Team");
            }
        }

        public void RemoveEmployee()
        {
            bool flag = true;

            do
            {
                Console.WriteLine("\n\nList employee: ");
                foreach (var e in listEmployees)
                {
                    e.Xuat();
                }
                Console.Write("Choose employeeID remove: ");
                string id = Console.ReadLine();
                int indexEmployeeID = listEmployees.FindIndex(item => item.GetID() == id);
                if (indexEmployeeID != -1)
                {
                    Console.WriteLine($"Remove Success Employee ${listEmployees[indexEmployeeID].employeeCode}");
                    listEmployees.Remove(listEmployees[indexEmployeeID]);
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Not Found Employee");
                }

            } while (flag == true);
        }

        public void RemoveTeam()
        {
            bool flag = true;
            do
            {
                Console.WriteLine("\n\nList team: ");
                foreach (var e in listTeam)
                {
                    e.Xuat();
                }
                Console.Write("Choose teamID remove: ");
                string id = Console.ReadLine();
                int indexTeamID = listTeam.FindIndex(item => item.teamID == id);
                if (indexTeamID != -1)
                {
                    Console.WriteLine($"Remove Success Team ${listTeam[indexTeamID].teamID}");
                    listTeam.Remove(listTeam[indexTeamID]);
                    flag=false;
                }
                else
                {
                    Console.WriteLine("Not Found Team");
                }
            } while (flag == true);
        }

        public void GetSalary()
        {
            double total_salary = 0;
            foreach (var e in listEmployees)
            {
                total_salary += e.Salary();
            }
            Console.WriteLine($"\n\nTotal Salary: {total_salary.ToString("N0")}VNĐ");
        }

        public void GetMemberMore()
        {
            //Vòng lặp tìm team có số nhân viên lớn nhất
            int teamMax = 0;
            string idMax = "";
            string nameMax = "";
            for (int i = 0; i < listTeam.Count; i++)
            {
                int total = 0;
                for (int j = 0; j < listEmployees.Count; j++)
                {
                    if (listEmployees[j].teamID == listTeam[i].teamID)
                    {
                        total++;
                    }
                }
                if (teamMax < total)
                {
                    teamMax = total;
                    idMax = listTeam[i].teamID;
                    nameMax = listTeam[i].name;

                }

            }
            Console.WriteLine($"Show the manager name with the most members: TeamID: {idMax} - Name: {nameMax}");

            //Vòng lặp tìm team có cùng số nhân viên lớn nhất

            int temp = teamMax;
            string tempIdMax ;
            string tempNameMax = "";
            for (int i = 0; i < listTeam.Count; i++)
            {
                int total = 0;
                for (int j = 0; j < listEmployees.Count; j++)
                {
                    if (listEmployees[j].teamID == listTeam[i].teamID)
                    {
                        total++;
                    }
                }
                if (temp == total && listTeam[i].teamID != idMax)
                {
                    tempIdMax = listTeam[i].teamID;
                    tempNameMax = listTeam[i].name;

                    Console.WriteLine($"Show the manager name with the most members: TeamID: {tempIdMax} - Name: {tempNameMax}");

                }
            }
        }

        public void GetManagerEnoughPosition ()
        {
            Position p;
            for (int i = 0; i < listTeam.Count; i++)
            {
                int totalDesgin = 0;
                int totalDevelop = 0;
                int totalManager = 0;
                int totalTester = 0;
                for (int j = 0; j < listEmployees.Count; j++)
                {

                    if (listTeam[i].teamID == listEmployees[j].teamID)
                    {
                        if (listEmployees[j].position == Position.Designer.ToString())
                        {
                            totalDesgin++;
                        }
                        if (listEmployees[j].position == Position.Developer.ToString())
                        {
                            totalDevelop++;
                        }
                        if (listEmployees[j].position == Position.Manager.ToString())
                        {
                            totalManager++;
                        }
                        if (listEmployees[j].position == Position.Tester.ToString())
                        {
                            totalTester++;
                        }

                    }
                }
                if (totalDesgin == 0 || totalDevelop == 0 || totalManager == 0 || totalTester == 0)
                {
                    Console.WriteLine($"Show team not enough 4 position: TeamID: {listTeam[i].teamID} Name: {listTeam[i].name}");
                }
            }
        }

        public void GetListMember ()
        {
            Console.WriteLine("\nList member");
            foreach (var member in listEmployees)
            {
                member.Xuat();
            }
        }

        public void GetListTeam()
        {
            Console.WriteLine("\nList team");
            foreach (var teamMember in listTeam)
            {
                teamMember.Xuat();
            }
        }
    }
}
enum Position { 
    Designer,
    Developer,
    Manager,
    Tester
}

