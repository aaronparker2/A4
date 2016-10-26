using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A4.Models
{
    public class HeroIdentity
    {
        [Key]
        public string CharacterName { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string IdentityName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        //CharacterName  	TrueIdentity 	EMail 

    }
}