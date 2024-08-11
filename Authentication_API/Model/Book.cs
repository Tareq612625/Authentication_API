using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Authentication_API.Model
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Title { get; set; }

        [Required]
        [StringLength(100)]
        public string? Author { get; set; }

        [Range(0, 10000)]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime? PublishedDate { get; set; }= DateTime.Now;
    }
}
