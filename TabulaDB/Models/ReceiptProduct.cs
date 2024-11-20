using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TabulaDB.Models
{
    [Table("receipt_products")]
    public class ReceiptProduct
    {
        public int Id { get; set; }
        public int ReceiptId { get; set; }
        public Receipt Receipt { get; set; } = null!;
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

        //TimeStamps
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedAt { get; set; }
    }
}
