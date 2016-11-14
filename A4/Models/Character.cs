using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A4.Models
{
    public class Character
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]//turns off Identity
        public int ID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Required]
        
        public string CharacterName { get; set; }

        public DateTime ReleaseDate { get; set; }
        [StringLength(100, MinimumLength = 3)]
        public string ComicName { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public string Description { get; set; }
        
        public virtual ICollection<CharacterVersion> CharacterVersion { get; set; }
        //public virtual ICollection<Complement> Complement { get; set; }
    }

}