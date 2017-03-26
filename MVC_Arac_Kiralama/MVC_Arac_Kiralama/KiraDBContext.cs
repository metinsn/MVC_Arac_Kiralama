namespace MVC_Arac_Kiralama
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class KiraDBContext : DbContext
    {
        public KiraDBContext()
            : base("name=KiraDB")
        {
        }
        public virtual DbSet<Models.Musteri> Musteri { get; set; }
        public virtual DbSet<Models.Model> Model { get; set; }
        public virtual DbSet<Models.Marka> Marka { get; set; }
        public virtual DbSet<Models.Kira> Kira { get; set; }
        public virtual DbSet<Models.Arac> Arac { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

    }

}