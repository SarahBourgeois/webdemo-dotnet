namespace MVC_WebSite.Models.EDM
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BDD : DbContext
    {
        public BDD()
            : base("name=BDD4")
        {
        }

        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Item)
                .WithRequired(e => e.User1)
                .HasForeignKey(e => e.user)
                .WillCascadeOnDelete(false);
        }
    }
}
