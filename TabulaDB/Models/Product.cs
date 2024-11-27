using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TabulaDB.Models
{
    [Index(nameof(Name), IsUnique = true)]
    public class Product
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string Name { get; set; } = string.Empty;
        [Column(TypeName = "decimal(6, 2)")]
        public float Price { get; set; }
        public int ProductCategoryId { get; set; }
        public ProductCategory Category { get; set; } = null!;
        public ICollection<ReceiptProduct> ReceiptProduct { get; } = new List<ReceiptProduct>();

        //TimeStamps
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedAt { get; set; }
    }
}
