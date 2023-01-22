using System;
using System.Collections.Generic;
using System.Text;
using LeagueOfLegends.Domain;

namespace LeagueOfLegends.Persistance.Manage
{
    class PlayerManage
    {
        DBBroker dbInstance;
        public PlayerManage()
        {
            dbInstance = DBBroker.obtenerAgente();
        }
        public void addPlayer(Player player)
        {
            dbInstance.modificar("INSERT INTO PLAYERS VALUES("+player.idPlayer+",'"+player.nickName+"','"+player.name+"','"+player.surname+
                "','"+player.role+"','"+player.type+"',"+player.idTeam+","+player.idCountry+")");
        }
        public void deleteAllPlayers()
        {
            dbInstance.modificar("DELETE * FROM PLAYERS");
        }
    }
}
