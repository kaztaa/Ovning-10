using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name can't be longer than 100 characters.")]
        public required string Name { get; set; }

        [Range(1, 10000, ErrorMessage = "Price must be between 1 and 10,000.")]
        public required int Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime Orderdate { get; set; }

        [Required(ErrorMessage = "Category is required.")]
        public required string Category { get; set; }

        [StringLength(50, ErrorMessage = "Shelf can't be longer than 50 characters.")]
        public required string Shelf { get; set; }

        [Range(0, 100, ErrorMessage = "Count must be between 0 and 100.")]
        public required int Count { get; set; }

        [StringLength(500, ErrorMessage = "Description can't be longer than 500 characters.")]
        public required string Description { get; set; }



    }
}
