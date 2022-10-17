using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Employee_OOP_2
{
    internal class Team
    {
        public string  teamID{ get; set; }
        public string name{ get; set; }
        public Team()
        {
            
        }
        public Team(string _teamID, string _name)
        {
            this.teamID = _teamID;

            this.name = _name;
        }
        public void Nhap()
        {
       
            while (true)
            {
                try
                {
                    Console.Write("\nName: ");
                    name = Console.ReadLine();
                    Regex regex = new Regex(@"^[a-zA-Z]+[- ']{0,1}[a-zA-Z]+$");
                    //Console.WriteLine("Regex: "+regex.IsMatch(name));
                    if (regex.IsMatch(name))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please input letter");
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Error is: "+ e);
                }
            }
            
            
        }
        public void Xuat()
        {
            Console.WriteLine($"TeamID: {teamID} - Name: {name}");
        }

      
      

       
    }
}
