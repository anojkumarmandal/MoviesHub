using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MoviesHub.Models
{
    [Serializable]
    public class Movie
    {
        [Required(AllowEmptyStrings = false)]
        public string MovieId { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false)]
        public int YearOfRelease { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Poster { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string ProducerId { get; set; }

        public List<Actor> Actors { get; set; }
    }
}