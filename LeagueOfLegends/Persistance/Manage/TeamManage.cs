using System;
using System.Collections.Generic;
using System.Text;
using LeagueOfLegends.Domain

namespace LeagueOfLegends.Persistance.Manage
{
    class TeamManage
    {
        public DBBroker dbInstance;
        public TeamManage()
        {
            dbInstance = DBBroker.obtenerAgente();
        }
        public void addTeam(Team team)
        {
            dbInstance.modificar("INSERT INTO MYBD.TEAM VALUES("+team.id+",'"+team.teamName+"','"+team.imageSrc+"')");
        }
        public void deleteAllTeams()
        {
            dbInstance.modificar("DELETE * FROM TEAM");
        }
    }
}
