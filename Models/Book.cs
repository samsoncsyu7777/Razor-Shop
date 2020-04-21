using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SamsonBookStore.Models
{
    public class Book
    {
        public int ID { get; set; }
        [StringLength(200, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }
        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string Author { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(70)]
        public string Genre { get; set; }
        [Range(1,2000)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [Range(2,2000)]
        public int Page { get; set; }
    }
}
