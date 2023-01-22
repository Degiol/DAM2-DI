using System;
using System.Collections.Generic;
using System.Text;
using LeagueOfLegends.Domain;

namespace LeagueOfLegends.Persistance.Manage
{
    class CountryManage
    {
        public DBBroker dbInstance;
        public CountryManage()
        {
            dbInstance = DBBroker.obtenerAgente();
        }
        public void addCountry(Country country)
        {
            dbInstance.modificar("INSERT INTO MYDB.COUNTRY VALUES ("+country.name+",'"+country.name+"')");
        }
        public void deleteCountries()
        {
            dbInstance.modificar("DELETE * FROM MYDB.COUNTRY");
        }
    }
}
