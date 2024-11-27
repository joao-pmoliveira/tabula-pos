using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TabulaDB.Models
{
    [Table("product_categories")]
    [Index(nameof(Name), IsUnique = true)]
    public class ProductCategory
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string Name { get; set; } = string.Empty;
        public ICollection<Product> Products = new List<Product>();

        //TimeStamps
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedAt { get; set; }
    }
}
