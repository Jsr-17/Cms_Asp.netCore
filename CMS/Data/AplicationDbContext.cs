using CMS.Models;
using Microsoft.EntityFrameworkCore;

namespace CMS.Data
{
    public class AplicationDbContext:DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<DataUser> DataUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
               new User { User_Id = 1, Email = "usuario1@example.com", Name = "Usuario 1", Age = 25, UserName = "user1", Password = "password1", Data_Id = 1 },
                new User { User_Id = 2, Email = "usuario2@example.com", Name = "Usuario 2", Age = 30, UserName = "user2", Password = "password2", Data_Id = 2 },
                new User { User_Id = 3, Email = "usuario3@example.com", Name = "Usuario 3", Age = 35, UserName = "user3", Password = "password3", Data_Id = 3 },
                new User { User_Id = 4, Email = "usuario4@example.com", Name = "Usuario 4", Age = 40, UserName = "user4", Password = "password4", Data_Id = 4 }
                );
            modelBuilder.Entity<DataUser>().HasData(
                new DataUser { Data_Id = 1, Title = "Título 1", Description = "Descripción 1", CreatedDate = DateTime.Now, Image = "imagen1.jpg" },
                new DataUser { Data_Id = 2, Title = "Título 2", Description = "Descripción 2", CreatedDate = DateTime.Now, Image = "imagen2.jpg" },
                new DataUser { Data_Id = 3, Title = "Título 3", Description = "Descripción 3", CreatedDate = DateTime.Now, Image = "imagen3.jpg" },
                new DataUser { Data_Id = 4, Title = "Título 4", Description = "Descripción 4", CreatedDate = DateTime.Now, Image = "imagen4.jpg" }
                );
        }
    }
}
