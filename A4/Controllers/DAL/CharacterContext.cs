using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using A4.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace A4.DAL
{
    public class CharacterContext : DbContext
    {  //inherits from DbContext class

        public CharacterContext() : base("CharacterContext")//instantiate with connection string in WEB.Config
            { }
        public DbSet<Character> Character { get; set; }//converts to database sets 
        public DbSet<CharacterVersion> CharacterVersion { get; set; }
        public DbSet<HeroIdentity> HeroIdentity { get; set; }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)  //optional overriding method
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//
        //}


    }
}
