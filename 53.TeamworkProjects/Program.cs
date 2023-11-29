using System;
using System.Collections.Generic;
using System.Linq;

namespace _53.TeamworkProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());

            Dictionary<string, Team> teams = new Dictionary<string, Team>();

            // CREATE
            for (int i = 0; i < numberOfTeams; i++)
            {
                string[] registerInput = Console.ReadLine().Split("-").ToArray();

                string creatorName = registerInput[0];
                string teamName = registerInput[1];

                // Condition: If a user tries to create a team more than once
                if (teams.ContainsKey(teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                // Condition: A creator of a team cannot create another team
                if (teams.Values.Any(team => team.UserCreator == creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                    continue;
                }

                // Create the team and add it to the dictionary
                Team team = new Team(creatorName, teamName);
                Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                teams.Add(teamName, team);
            }

            string input = Console.ReadLine();

            // MODIFY
            while (input != "end of assignment")
            {
                string[] joinInput = input.Split("->").ToArray();

                string memberWannaBe = joinInput[0];
                string joinTeamName = joinInput[1];

                // Condition: If а user tries to join a non-existent team
                if (!teams.ContainsKey(joinTeamName))
                {
                    Console.WriteLine($"Team {joinTeamName} does not exist!");
                }
                // Condition: A member of a team cannot join another team
                else if (teams.Values.Any(team => team.Members.Contains(memberWannaBe) || team.UserCreator == memberWannaBe))
                {
                    Console.WriteLine($"Member {memberWannaBe} cannot join team {joinTeamName}!");
                }
                else
                {
                    // Add the member to the team
                    teams[joinTeamName].Members.Add(memberWannaBe);
                }

                input = Console.ReadLine();
            }

            // PRINT
            foreach (var team in teams
                .Where(team => team.Value.Members.Count > 0)
                .OrderByDescending(team => team.Value.Members.Count)
                .ThenBy(team => team.Key))
            {
                Console.WriteLine(team.Key);
                Console.WriteLine("- " + team.Value.UserCreator);

                foreach (string member in team.Value.Members.OrderBy(m => m))
                {
                    Console.WriteLine("-- " + member);
                }
            }

            Console.WriteLine("Teams to disband: ");
            foreach (var team in teams
                .Where(team => team.Value.Members.Count == 0)
                .OrderBy(team => team.Key))
            {
                Console.WriteLine(team.Key);
            }
        }
    }

    class Team
    {
        public string UserCreator { get; }
        public string TeamName { get; }
        public List<string> Members { get; }

        public Team(string userCreator, string teamName)
        {
            UserCreator = userCreator;
            TeamName = teamName;
            Members = new List<string>();
        }
    }
}
