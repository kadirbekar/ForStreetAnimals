namespace WeAreTogether.Entities.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Animal> Animal { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Districts> Districts { get; set; }
        public virtual DbSet<KindOfAnimal> KindOfAnimal { get; set; }
        public virtual DbSet<Management> Management { get; set; }
        public virtual DbSet<ManagementFood> ManagementFood { get; set; }
        public virtual DbSet<ManagementPhone> ManagementPhone { get; set; }
        public virtual DbSet<ManagementShelter> ManagementShelter { get; set; }
        public virtual DbSet<ManagementType> ManagementType { get; set; }
        public virtual DbSet<PhoneType> PhoneType { get; set; }
        public virtual DbSet<ResponsibleOfManagement> ResponsibleOfManagement { get; set; }
        public virtual DbSet<Shelter> Shelter { get; set; }
        public virtual DbSet<ShelterOfUser> ShelterOfUser { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserPhone> UserPhone { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cities>()
                .HasMany(e => e.Shelter)
                .WithRequired(e => e.Cities)
                .HasForeignKey(e => e.CityId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cities>()
                .HasMany(e => e.Management)
                .WithRequired(e => e.Cities)
                .HasForeignKey(e => e.CityId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cities>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Cities)
                .HasForeignKey(e => e.CityId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Districts>()
                .HasMany(e => e.Shelter)
                .WithRequired(e => e.Districts)
                .HasForeignKey(e => e.DistrictId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Districts>()
                .HasMany(e => e.Management)
                .WithRequired(e => e.Districts)
                .HasForeignKey(e => e.DistrictId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Districts>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Districts)
                .HasForeignKey(e => e.DistrictId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KindOfAnimal>()
                .HasMany(e => e.Animal)
                .WithRequired(e => e.KindOfAnimal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Management>()
                .HasMany(e => e.ManagementShelter)
                .WithRequired(e => e.Management)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Management>()
                .HasMany(e => e.ManagementFood)
                .WithRequired(e => e.Management)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Management>()
                .HasMany(e => e.ManagementPhone)
                .WithRequired(e => e.Management)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ManagementPhone>()
                .Property(e => e.PhoneNumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ManagementType>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<ManagementType>()
                .HasMany(e => e.Management)
                .WithRequired(e => e.ManagementType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhoneType>()
                .HasMany(e => e.ManagementPhone)
                .WithRequired(e => e.PhoneType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhoneType>()
                .HasMany(e => e.UserPhone)
                .WithRequired(e => e.PhoneType)
                .HasForeignKey(e => e.PhoneId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Shelter>()
                .HasMany(e => e.Animal)
                .WithRequired(e => e.Shelter)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Shelter>()
                .HasMany(e => e.ManagementShelter)
                .WithRequired(e => e.Shelter)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Shelter>()
                .HasMany(e => e.ShelterOfUser)
                .WithRequired(e => e.Shelter)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.IdentityNumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ManagementFood)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.ResponsibleUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ShelterOfUser)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserPhone)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserPhone>()
                .Property(e => e.PhoneNumber)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
