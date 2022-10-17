using Employee_OOP_2;
using shortid;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Company company = new Company();

        Action action;

        string typeProgram;
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
            Console.Write("\n Input number: ");
            typeProgram = Console.ReadLine();
            action = (Action)Enum.Parse(typeof(Action), typeProgram);
            switch (action)
            {
                //Chọn thêm member hoặc team
                case Action.ADD_MEMBER:
                    {
                        Console.WriteLine("\n0. Add member\n1.Add team\n2.Add member into team");
                        string type =Console.ReadLine();
                        Action_Add_Member actionMember;
                        actionMember = (Action_Add_Member)Enum.Parse(typeof(Action_Add_Member), type);
                        switch (actionMember)
                        {
                            case Action_Add_Member.ADD_MEMBER_1:
                                {
                                    int typeMember;
                                    Console.WriteLine("\nChoose type member: \n0. Designer\n1. Developer\n2. Manager\n3. Tester");
                                    typeMember = int.Parse(Console.ReadLine());
                                    switch (typeMember)
                                    {
                                        case 0:
                                            {
                                                company.CreateDesigner();
                                                break;
                                            }
                                        case 1:
                                            {
                                                company.CreateDeveloper();
                                                break;
                                            }
                                        case 2:
                                            {
                                                company.CreateManager();
                                                break;
                                            }
                                        case 3:
                                            {
                                                company.CreateTester();
                                                break;
                                            }
                                        default:
                                            Console.WriteLine("Please input again");
                                            break;
                                    }
                                    break;
                                }
                            case Action_Add_Member.ADD_TEAM:
                                {
                                    company.CreateTeam();
                                    break;
                                }

                            case Action_Add_Member.ADD_MEMBER_INTO_TEAM:
                                {
                                    company.AddMemberToTeam();
                                    break;
                                }
                            default:
                                Console.WriteLine("Please input again");
                                break;
                        }
                        break;
                    }

                //Xóa member hoặc team
                case Action.REMOVE_MEMBER:
                    {
                        Console.WriteLine("\n0. Remove member\n1.Remove team");
                        int type = Int32.Parse(Console.ReadLine());
                        switch (type)
                        {
                            case 0:
                                {
                                    company.RemoveEmployee();
                                    break;
                                }
                            case 1:
                                {
                                    company.RemoveTeam();
                                    break;
                                }
                            default:
                                Console.WriteLine("Please input again");
                                break;
                        }
                        break;


                    }

                //Hiển thị danh sách lương
                case Action.SHOW_TOTAL_SALARY:
                    {
                        company.GetSalary();
                        break;
                    }

                //Hiển thị tên manager đông thành viên nhất
                case Action.SHOW_MANAGER_MOST_MEMBER:
                    {
                        company.GetMemberMore();
                        break;
                    }

                //Hiển thị tên manager không đủ 4 vị trí
                case Action.SHOW_TEAM_NOT_ENOUGH:
                    {
                        company.GetManagerEnoughPosition();
                        break;
                    }

                //Hiển thị danh sách member hoặc team
                case Action.SHOW_LIST_MEMBER_OR_TEAM:
                    {
                        Console.WriteLine("\n0. Show list member\n1. Show list team");
                        int type = Int32.Parse(Console.ReadLine());
                        switch (type)
                        {
                            case 0:
                                {
                                    company.GetListMember();
                                    break;
                                }
                            case 1:
                                {
                                    company.GetListTeam();
                                    break;
                                }
                            default:
                                Console.WriteLine("Please input again");
                                break;
                        }
                        break;
                    }
                case Action.EXIT:
                    {
                        break;
                    }
                default:
                    Console.WriteLine("Please input again");
                    break;
            }
        } while (typeProgram != Action.EXIT.ToString());
    }
}
enum Action {
    ADD_MEMBER,
    REMOVE_MEMBER,
    SHOW_TOTAL_SALARY,
    SHOW_MANAGER_MOST_MEMBER,
    SHOW_TEAM_NOT_ENOUGH,
    SHOW_LIST_MEMBER_OR_TEAM,
    EXIT
}

enum Action_Add_Member
{
    ADD_MEMBER_1,
    ADD_TEAM,
    ADD_MEMBER_INTO_TEAM
}







