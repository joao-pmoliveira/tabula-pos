using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TabulaDB.Models
{
    public class Receipt
    {
        public int Id { get; set; }
        public ICollection<ReceiptProduct> ReceiptProducts { get; } = new List<ReceiptProduct>();
        public int ReceiptStatusId { get; set; }
        public ReceiptStatus ReceiptStatus { get; set; } = null!; 
        public int TableId { get; set; }
        public Table Table { get; set; } = null!;
        
        //TimeStamps
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedAt { get; set; }
    }
}
