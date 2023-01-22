using System;
using System.Collections.Generic;
using System.Text;
using LeagueOfLegends.Persistance.Manage;

namespace LeagueOfLegends.Domain
{
    class Player
    {
        public static int maxId = 1;
        public int idPlayer { get; set; }
        public String nickName { get; set; }
        public String name { get; set; }
        public String surname { get; set; }
        public String role { get; set; }
        public String type { get; set; }
        public int idTeam { get; set; }
        public int idCountry { get; set; }
        public PlayerManage manage { get; set; }

        public Player(string nickName, string name, string surname, string role, string type, int idTeam, int idCountry)
        {
            this.idPlayer = maxId;
            maxId+=1;
            this.nickName = nickName;
            this.name = name;
            this.surname = surname;
            this.role = role;
            this.type = type;
            this.idTeam = idTeam;
            this.idCountry = idCountry;
            this.manage = new PlayerManage();
        }

        public Player()
        {
            this.manage = new PlayerManage();
        }

        public void addPlayer()
        {
            manage.addPlayer(this);
        }
        public void deleteall()
        {
            manage.deleteAllPlayers();
        }
    }
}
