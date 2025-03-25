using Core.Data.Configuration;
using Domain;
using Domain.Entities;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Core.Data
{
    public class libraryContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies()
                .UseSqlServer("Data Source=.;Initial Catalog=Library2;Integrated Security=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BookConfiguration).Assembly);
            modelBuilder.Ignore<BaseEntity>();

        }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Communication> Communications { get; set; }
        public DbSet<CommunicationType> CommunicationTypes { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Proof> Proofs { get; set; }
        public DbSet<FormBorrow> FormBorrows { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Role> Roles { get; set; }



    }
}
