using System;
using System.Collections.Generic;

namespace efMvcToons.Models.Toons
{
    public partial class Movies
    {
        public Movies()
        {
            Actors = new HashSet<Actors>();
        }

        public int MovieId { get; set; }
        public string Name { get; set; }
        public string DirectorFirstName { get; set; }
        public string DirectorLastName { get; set; }
        public int Year { get; set; }
        public string Rating { get; set; }

        public virtual ICollection<Actors> Actors { get; set; }
    }
}
