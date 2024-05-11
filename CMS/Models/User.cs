using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMS.Models
{
    public class User
    {
        
        [Required]
        public string Email { get; set; }

        [Key]
        public int User_Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public string UserName { get; set; }
        [MinLength(8)]
        public string Password { get; set; }

        public int Data_Id { get; set; }

        [ForeignKey("Data_Id")]
        public DataUser Data { get; set; }

        internal class UserConfiguration : IEntityTypeConfiguration<User>
        {
            public void Configure( EntityTypeBuilder<User> builder)
            {
                builder.HasIndex(u => u.Email).IsUnique();
                builder.HasIndex(u=>u.UserName).IsUnique();
            }


        }

    }
}
