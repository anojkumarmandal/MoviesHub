using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesHub.Datatypes
{
    public class Movie
    {

        public string MovieId { get; set; }


        public string Name { get; set; }


        public int YearOfRelease { get; set; }


        public string Poster { get; set; }


        public string ProducerId { get; set; }

        public List<Actor> Actors { get; set; }
    }
}
