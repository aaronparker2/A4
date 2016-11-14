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
        public DbSet<Character> Characters { get; set; }//converts to database sets 
        public DbSet<CharacterVersion> CharacterVersions { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)//manually add this to the database context
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//remove pluralizations

           // modelBuilder.Entity<Character>().HasMany(c => c.CharacterVersions)
           ////many to many relationship for mapping tables
           //.Map(t => t.MapLeftKey("ID")
           //.MapRightKey("CharacterID")
           ////.ToTable("CourseInstructor")
           //);  //fluid API allows for more control

            //once this is added the seed is no good because many things have not been added
        }



    }
}
