using System;
using System.Collections.Generic;
using System.Text;
using LeagueOfLegends.Persistance.Manage

namespace LeagueOfLegends.Domain
{
    class Country
    {
        public int idCountry { get; set; }
        public string name { get; set; }
        public CountryManage manage { get; set; }
        public Country(int idCountry, string name)
        {
            this.idCountry = idCountry;
            this.name = name;
            this.manage = new CountryManage();
        }

        public Country()
        {
            this.manage = new CountryManage();
        }

        public void addCountry()
        {
            manage.addCountry(this);
        }
        public void deleteAll()
        {
            manage.deleteCountries();
        }
    }
}
