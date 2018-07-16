using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MoviesHub.Models
{
    [Serializable]
    public class Actor
    {
        [Required(AllowEmptyStrings =false)]
        public string ActorId { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false)]
        public char Sex { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DOB { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Bio { get; set; }
    }
}