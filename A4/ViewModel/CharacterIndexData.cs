using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using A4.Models;

namespace A4.ViewModel
{
    public class CharacterIndexData
    {

        public IEnumerable<Character> Characters { get; set; }
        public IEnumerable<CharacterVersion> CharacterVersions { get; set; }
    }
}