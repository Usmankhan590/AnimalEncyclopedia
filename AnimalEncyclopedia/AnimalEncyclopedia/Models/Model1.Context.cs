//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnimalEncyclopedia.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Database1Entities : DbContext
    {
        public Database1Entities()
            : base("name=Database1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<card> cards { get; set; }
        public virtual DbSet<research> researches { get; set; }
        public virtual DbSet<Doct> Docts { get; set; }
        public virtual DbSet<Amphibian> Amphibians { get; set; }
        public virtual DbSet<Animal> Animals { get; set; }
        public virtual DbSet<Bird> Birds { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
    }
}
