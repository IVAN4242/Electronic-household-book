using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Electronic_household_book
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<AnimalsSet> AnimalsSet { get; set; }
        public virtual DbSet<LandsSet> LandsSet { get; set; }
        public virtual DbSet<LPHSet> LPHSet { get; set; }
        public virtual DbSet<MembersSet> MembersSet { get; set; }
        public virtual DbSet<TechnicSet> TechnicSet { get; set; }
        public virtual DbSet<UsersSet> UsersSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnimalsSet>()
                .HasMany(e => e.LPHSet)
                .WithRequired(e => e.AnimalsSet)
                .HasForeignKey(e => e.Animals_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LandsSet>()
                .HasMany(e => e.LPHSet)
                .WithRequired(e => e.LandsSet)
                .HasForeignKey(e => e.Lands_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LPHSet>()
                .HasMany(e => e.MembersSet)
                .WithRequired(e => e.LPHSet)
                .HasForeignKey(e => e.LPH_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LPHSet>()
                .HasMany(e => e.TechnicSet)
                .WithRequired(e => e.LPHSet)
                .HasForeignKey(e => e.LPH_Id)
                .WillCascadeOnDelete(false);
        }
    }
}
