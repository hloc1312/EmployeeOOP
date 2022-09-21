using Employee_OOP_2;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Employee employee;
        List<Employee> listEmployees = new List<Employee>();
        Team team;
        List<Team> listTeam = new List<Team>();

        int typeProgram;
        do
        {
            Console.Write(
               "\n0. Add new member or team or member into team\n" +
               "1. Remove mmeber\n" +
               "2. Show total salary\n" +
               "3. Show the manager name with the most members\n" +
               "4. Show team not enough 4 position\n" +
               "5. Show list member or team" +
               "\n6. Exit");
            Console.Write("\n Input type: ");
            typeProgram = int.Parse(Console.ReadLine());
            switch (typeProgram)
            {
                //Chọn thêm member hoặc team
                case 0:
                    {
                        Console.WriteLine("\n0. Add member\n1.Add team\n2.Add member into team");
                        int type = Int32.Parse(Console.ReadLine());
                        switch (type)
                        {
                            case 0:
                                {
                                    int typeMember;
                                    Console.WriteLine("\nChoose type member: \n0. Designer\n1. Developer\n2. Manager\n3. Tester");
                                    typeMember = int.Parse(Console.ReadLine());
                                    switch (typeMember)
                                    {
                                        case 0:
                                            {
                                                employee = new Designer();
                                                int _employeeID;
                                                while (true)
                                                {
                                                    try
                                                    {
                                                        Console.Write("EmployeeCode: ");
                                                        _employeeID = int.Parse(Console.ReadLine());
                                                        Regex regex = new Regex(@"^[0-9]+$");
                                                        //Console.WriteLine(regex.IsMatch(_teamID.ToString()));
                                                        if (regex.IsMatch(_employeeID.ToString()))
                                                        {
                                                            break;
                                                        }

                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.WriteLine("Error is: " + e);
                                                    }

                                                }

                                                int index = listEmployees.FindIndex(item => item.employeeCode == _employeeID);
                                                if (index == -1)
                                                {
                                                    employee.employeeCode = _employeeID;
                                                    employee.Nhap();
                                                    employee.Xuat();
                                                    listEmployees.Add(employee);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("EmployeeID exit");
                                                }

                                                break;
                                            }
                                        case 1:
                                            {
                                                employee = new Developer();

                                                int _employeeID;
                                                while (true)
                                                {
                                                    try
                                                    {
                                                        Console.Write("EmployeeCode: ");
                                                        _employeeID = int.Parse(Console.ReadLine());
                                                        Regex regex = new Regex(@"^[0-9]+$");
                                                        //Console.WriteLine(regex.IsMatch(_teamID.ToString()));
                                                        if (regex.IsMatch(_employeeID.ToString()))
                                                        {
                                                            break;
                                                        }

                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.WriteLine("Error is: " + e);
                                                    }

                                                }

                                                int index = listEmployees.FindIndex(item => item.employeeCode == _employeeID);
                                                if (index == -1)
                                                {
                                                    employee.employeeCode = _employeeID;
                                                    employee.Nhap();
                                                    employee.Xuat();
                                                    listEmployees.Add(employee);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("EmployeeID exit");
                                                }
                                                break;
                                            }
                                        case 2:
                                            {
                                                employee = new Manager();
                                                int _employeeID;
                                                while (true)
                                                {
                                                    try
                                                    {
                                                        Console.Write("EmployeeCode: ");
                                                        _employeeID = int.Parse(Console.ReadLine());
                                                        Regex regex = new Regex(@"^[0-9]+$");
                                                        //Console.WriteLine(regex.IsMatch(_teamID.ToString()));
                                                        if (regex.IsMatch(_employeeID.ToString()))
                                                        {
                                                            break;
                                                        }

                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.WriteLine("Error is: " + e);
                                                    }

                                                }

                                                int index = listEmployees.FindIndex(item => item.employeeCode == _employeeID);
                                                if (index == -1)
                                                {
                                                    employee.employeeCode = _employeeID;
                                                    employee.Nhap();
                                                    employee.Xuat();
                                                    listEmployees.Add(employee);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("EmployeeID exit");
                                                }
                                                break;
                                            }
                                        case 3:
                                            {
                                                employee = new Tester();
                                                int _employeeID;
                                                while (true)
                                                {
                                                    try
                                                    {
                                                        Console.Write("EmployeeCode: ");
                                                        _employeeID = int.Parse(Console.ReadLine());
                                                        Regex regex = new Regex(@"^[0-9]+$");
                                                        //Console.WriteLine(regex.IsMatch(_teamID.ToString()));
                                                        if (regex.IsMatch(_employeeID.ToString()))
                                                        {
                                                            break;
                                                        }

                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.WriteLine("Error is: " + e);
                                                    }

                                                }

                                                int index = listEmployees.FindIndex(item => item.employeeCode == _employeeID);
                                                if (index == -1)
                                                {
                                                    employee.employeeCode = _employeeID;
                                                    employee.Nhap();
                                                    employee.Xuat();
                                                    listEmployees.Add(employee);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("EmployeeID exit");
                                                }
                                                break;
                                            }
                                        default:
                                            Console.WriteLine("Please input again");
                                            break;





                                    }
                                    break;
                                }
                            case 1:
                                {
                                    team = new Team();
                                    int _teamID;
                                    while (true)
                                    {
                                        try
                                        {
                                            Console.Write("TeamID: ");
                                            _teamID = int.Parse(Console.ReadLine());
                                            Regex regex = new Regex(@"^[0-9]+$");
                                            //Console.WriteLine(regex.IsMatch(_teamID.ToString()));
                                            if (regex.IsMatch(_teamID.ToString()))
                                            {
                                                break;
                                            }

                                        }
                                        catch (Exception e)
                                        {
                                            Console.WriteLine("Error is: " + e);
                                        }

                                    }

                                    int index = listTeam.FindIndex(item => item.teamID == _teamID);
                                    if (index == -1)
                                    {
                                        team.teamID = _teamID;
                                        team.Nhap();
                                        team.Xuat();
                                        listTeam.Add(team);
                                    }
                                    else
                                    {
                                        Console.WriteLine("TeamID exit");
                                    }
                                    break;
                                }

                            case 2:
                                {
                                    Console.WriteLine("\n\nChon teamID: ");
                                    int teamID = int.Parse(Console.ReadLine());
                                    int indexTeam = listTeam.FindIndex(item => item.teamID == teamID);
                                    Console.WriteLine("\nNhap id nhan vien muon vao team: ");
                                    int employeeID = int.Parse(Console.ReadLine());
                                    int indexEmployee = listEmployees.FindIndex(item => item.GetID() == employeeID);
                                    if (indexTeam != -1)
                                    {
                                        if (indexEmployee != -1)
                                        {
                                            listEmployees[indexEmployee].teamID = listTeam[indexTeam].teamID;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Not found employeeID");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not found teamID");
                                    }
                                    break;
                                }
                            default:
                                Console.WriteLine("Please input again");
                                break;
                        }
                        break;
                    }

                //Xóa member hoặc team
                case 1:
                    {
                        Console.WriteLine("\n0. Remove member\n1.Remove team");
                        int type = Int32.Parse(Console.ReadLine());
                        switch (type)
                        {
                            case 0:
                                {
                                    Console.WriteLine("Choose employeeID remove: ");
                                    int id = int.Parse(Console.ReadLine());
                                    int indexEmployeeID = listEmployees.FindIndex(item => item.GetID() == id);
                                    if (indexEmployeeID != -1)
                                    {
                                        listEmployees.Remove(listEmployees[indexEmployeeID]);

                                    }
                                    break;
                                }
                            case 1:
                                {
                                    Console.WriteLine("Choose teamID remove: ");
                                    int id = int.Parse(Console.ReadLine());
                                    int indexTeamID = listEmployees.FindIndex(item => item.teamID == id);
                                    if (indexTeamID != -1)
                                    {
                                        listTeam.Remove(listTeam[indexTeamID]);

                                    }
                                    break;
                                }
                            default:
                                Console.WriteLine("Please input again");
                                break;
                        }
                        break;


                    }

                //Hiển thị danh sách lương
                case 2:
                    {
                        double total_salary = 0;
                        foreach (var e in listEmployees)
                        {
                            total_salary += e.Salary();
                        }
                        Console.WriteLine($"\n\nTotal Salary: {total_salary.ToString("N0")}");
                        break;
                    }

                //Hiển thị tên manager đông thành viên nhất
                case 3:
                    {
                        //Vòng lặp tìm team có số nhân viên lớn nhất
                        int teamMax = 0;
                        int idMax = 0;
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
                        int tempIdMax = 0;
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
                        break;
                    }

                //Hiển thị tên manager không đủ 4 vị trí
                case 4:
                    {
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
                                    if (listEmployees[j].position == "Designer")
                                    {
                                        totalDesgin++;
                                    }
                                    if (listEmployees[j].position == "Developer")
                                    {
                                        totalDevelop++;
                                    }
                                    if (listEmployees[j].position == "Manager")
                                    {
                                        totalManager++;
                                    }
                                    if (listEmployees[j].position == "Tester")
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
                        break;
                    }

                //Hiển thị danh sách member hoặc team
                case 5:
                    {
                        Console.WriteLine("\n0. Show list member\n1. Show list team");
                        int type = Int32.Parse(Console.ReadLine());
                        switch (type)
                        {
                            case 0:
                                {
                                    Console.WriteLine("\nList member");
                                    foreach (var member in listEmployees)
                                    {
                                        member.Xuat();
                                    }
                                    break;
                                }
                            case 1:
                                {
                                    Console.WriteLine("\nList team");
                                    foreach (var teamMember in listTeam)
                                    {
                                        teamMember.Xuat();
                                    }
                                    break;
                                }
                            default:
                                Console.WriteLine("Please input again");
                                break;
                        }
                        break;
                        break;
                    }
                case 6:
                    {
                        break;
                    }
                default:
                    Console.WriteLine("Please input again");
                    break;
            }


        } while (typeProgram != 6);
    }
}






