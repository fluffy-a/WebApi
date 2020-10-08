
using MovieeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieeApp
{
    public static class StaticDb
    {
        public static List<Movie> Movies = new List<Movie>()
        {
            new Movie()
            {
                Id = 1,
                Name = "Ten things I hate about you",
                Genre = Genre.Romance,           
                Duration = "20:20:00",
                Artists = MovieOneArtists()
             },
            new Movie()
            {
                Id = 2,
                Name = "The Man from U.N.C.L.E.",
                Genre= Genre.Action,
                Duration = "99:99:99",
                Artists = MovieTwoArtists()
            }
        };

        public static List<Artist> MovieOneArtists()
        {
            return new List<Artist>()
             {
                new Artist()
                {
                   Id = 1,
                   FirstName="Heath",
                   LastName = "Ledger"
                },
                new Artist()
                {
                    Id = 2,
                   FirstName="Julia",
                   LastName = "Stiles"
                },
                 new Artist()
                {
                     Id = 3,
                   FirstName="Joseph",
                   LastName = "Gordon-Levit"
                },
            };
        }

        public static List<Artist> MovieTwoArtists()
        {
            return new List<Artist>()
             {
                new Artist()
                {
                    Id = 1,
                    FirstName="Henry",
                    LastName = "Cavill"
                },
                new Artist()
                {
                    Id = 2,
                    FirstName="Armie",
                    LastName = "Hammer"
                },
                new Artist()
                {
                    Id = 3,
                    FirstName="Alicia",
                    LastName = "Vikander"
                },
            };
        }
    }
}
