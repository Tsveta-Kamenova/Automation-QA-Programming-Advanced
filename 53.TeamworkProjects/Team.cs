using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53.TeamworkProjects
{
    public class Team
    {
        public Team(string userCreator, string teamName, List<string> members) 
        {
            UserCreator = userCreator;
            TeamName = teamName;
        }

        public string UserCreator { get; set; }

        public string TeamName { get; set; }
        
        public List<string> Members { get; set; }

        public void CreateTeam(string name, string team)
        {
            UserCreator = name;
            TeamName = team;
        }

        public void JoinTeam(string name, string team)
        {

        }

    }
}
