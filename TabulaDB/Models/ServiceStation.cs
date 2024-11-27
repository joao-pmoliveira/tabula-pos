using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TabulaDB.Models
{
    [Table("service_stations")]
    [Index(nameof(Name), IsUnique = true)]
    public class ServiceStation
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string Name { get; set; } = string.Empty;

        public ICollection<Receipt> Receipts { get; } = new List<Receipt>();

        //TimeStamps
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedAt { get; set; }
    }
}
