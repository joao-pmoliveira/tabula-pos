namespace TabulaDB.Models
{
    public class Log
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string? Description { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        //TimeStamps
        [DatabaseGenerated(DatabaseGenerated.Identity)]
        public DateTime CreatedAt { get; }
    }
}
