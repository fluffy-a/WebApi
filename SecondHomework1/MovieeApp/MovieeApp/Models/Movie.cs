using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieeApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Genre Genre { get; set; }
        public string Duration { get; set; } // Usually it's TimeSpan type this property 
        public List<Artist> Artists { get; set; }
    }
}
