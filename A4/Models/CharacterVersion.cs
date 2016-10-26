using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A4.Models
{
    public class CharacterVersion
    {
             
        public int CharacterVersionID { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string Version { get; set; }
        
        public string CharacterName { get; set; }

        public virtual Character Character { get; set; }
    }
}