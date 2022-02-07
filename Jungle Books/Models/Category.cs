using System.ComponentModel.DataAnnotations;

namespace Jungle_Books.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        //ange(1, 100, ErrorMessage = "Name must be between 1 and 100 only!!")]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        [Required]
       //Range(5, 500, ErrorMessage ="Description must be between 5 and 500 only!!")]
        public string Description { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;  
    }
}