using System;
using System.Collections.Generic;

namespace efMvcToons.Models.Toons
{
    public partial class Countries
    {
        public Countries()
        {
            Provinces = new HashSet<Provinces>();
        }

        public string CountryName { get; set; }
        public string CapitalCity { get; set; }
        public int AreaSqKm { get; set; }
        public string ContinentName { get; set; }

        public virtual Continents ContinentNameNavigation { get; set; }
        public virtual ICollection<Provinces> Provinces { get; set; }
    }
}
