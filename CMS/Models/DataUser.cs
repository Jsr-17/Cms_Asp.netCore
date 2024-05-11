using System.ComponentModel.DataAnnotations;

namespace CMS.Models
{
    public class DataUser
    {
        [Key]
        public int Data_Id { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }

        public string Description { get; set; }
        public DateTime CreatedDate { get; set;}
        public string Image { get; set;}
    }
}