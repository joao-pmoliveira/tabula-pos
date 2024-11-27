using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TabulaDB.Models
{
    [Index(nameof(Name), IsUnique = true)]
    public class Role
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string Name { get; set; } = string.Empty;
        public ICollection<User> Users { get; } = new List<User>();

        //TimeStamps
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedAt { get; set; }
    }
}
