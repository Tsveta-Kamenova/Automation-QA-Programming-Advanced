namespace _53.TeamworkProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());

            List<Team> teams = new();

            for (int i = 0; i < numberOfTeams; i++)
            {
                string[] registerInput = Console.ReadLine().Split("-").ToArray();

                string firstUserName = registerInput[0];
                string firstTeamName = registerInput[1];

                foreach (Team team in teams)
                {
                    if (team.UserCreator == firstUserName)
                    {
                        Console.WriteLine($"{firstUserName} cannot create another team!");
                        continue;
                    }

                    if (team.TeamName.Contains(firstTeamName))
                    {
                        Console.WriteLine($"Team {firstTeamName} was already created!");
                        continue;
                    }

                    Team currentTeam = new Team(firstUserName, firstTeamName);

                    teams.Add(currentTeam);
                }
            }

            string input = Console.ReadLine();

            while(input != "end of assignment")
            {
                string[] joinInput = input.Split("->").ToArray();

                string memberWannaBe = joinInput[0];
                string joinTeam = joinInput[1];

                foreach (Team team in teams)
                {
                    if (team.UserCreator == memberWannaBe)
                    {
                        Console.WriteLine($"Member {memberWannaBe} cannot join team {joinTeam}!");
                        continue;
                    }

                    if (team.TeamName == joinTeam && team.UserCreator != memberWannaBe)
                    {
                        Team currentTeam = new Team(memberWannaBe, joinTeam);

                        teams.Add(currentTeam);
                    }
                }

                input = Console.ReadLine();
            }


        }
    }
}