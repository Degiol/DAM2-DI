using System;
using LeagueOfLegends.Domain;

namespace LeagueOfLegends
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will clear all the database and insert sample data");
            Filldata();
        }

        private static void Filldata()
        {
            delteData();
            string[] CountriesName = { "Spain", "Portugal","United Kingdom","France","Germany","Italy","Poland","Denamark","Grece","Hungary" };
            for (int i = 1; i <= 10; i++)
            {
                Country country = new Country(1, CountriesName[i]);
                country.addCountry();
            }
            for(int i = 1; i <= 50; i++)
            {
                string tName = "Team " + i;
                string src = "/images/default.jpg";
                Team team = new Team(i,tName,src);
                team.addTeam();

            }
            for (int i = 1; i <= 50; i++)
            {
                Random r = new Random();
                int reservePlayers = r.Next(7, 11);
                int totalPlayers = 5 + reservePlayers;
                for(int j = 1; j<= totalPlayers; j++)
                {
                    String nickname = "nick" + j;
                    String name = giveRandomName();
                    String surname = giveRandomSurname();
                    String role = giverRandomRole();
                    String type;
                    if (j <= 5)
                        type = "Starter";
                    else
                        type = "Reserve";
                    int idCountry = giveRandomCountry();
                    Player player = new Player(nickname,name,surname,role,type,i,idCountry);
                    player.addPlayer();
                }
            }
        }

        private static void delteData()
        {
            Player deleteP = new Player();
            Team deleteT = new Team();
            Country deleteC = new Country();
            deleteP.deleteall();
            deleteT.deleteAll();
            deleteC.deleteAll();
        }

        private static int giveRandomCountry()
        {
            Random r = new Random();
            return r.Next(1, 11);
        }

        private static string giverRandomRole()
        {
            String[] Roles={"top","jungle","mid","adc","support"};
            Random r = new Random();
            return Roles[r.Next(0, (Roles.Length + 1))];
        }

        private static string giveRandomSurname()
        {
            string[] playersSurname = { "Smith", "Johnson", "Williams", "Brown", "Miller", "Davis", "Wilson", "Anderson", "Moore", "Jackson", "Lewis", "Walker", "Hill", "Green" };
            Random R = new Random();
            return playersSurname[R.Next(0, (playersSurname.Length + 1))];
        }

        private static string giveRandomName()
        {
            string[] playersName = { "Marc", "Anna", "Michel", "Sinead", "Michael", "Eric", "Peter", "Clerc", "Brian", "Emma", "Charlotte", "Liam", "Noah" };
            Random R = new Random();
            return playersName[R.Next(0, (playersName.Length + 1))];
        }
    }
}
