using System;
using System.Collections.Generic;
using System.Text;
using LeagueOfLegends.Persistance.Manage

namespace LeagueOfLegends.Domain
{
    class Team
    {
        public int id;
        public String teamName { get; set; }
        public String imageSrc { get; set; }
        public TeamManage manage { get; set; }
        public Team(int id, String teamName, String imageSrc)
        {
            this.id = id;
            this.teamName = teamName;
            this.imageSrc = imageSrc;
            this.manage = new TeamManage();
        }

        public Team()
        {
            this.manage = new TeamManage();
        }

        public void addTeam()
        {
            manage.addTeam(this);
        }
        public void deleteAll()
        {
            manage.deleteAllTeams();
        }
    }
}
