namespace TabulaDB.Models
{
    public class User
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string Username { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; } = null!;
        public ICollection<Log> Logs { get; } = new List<Log>();

        //TimeStamps
        [DatabaseGenerated(DatabaseGenerated.Identity)]
        public DateTime CreatedAt { get; }
        [DatabaseGenerated(DatabaseGenerated.Computed)]
        public DateTime? UpdatedAt { get; set; }
        
    }
}
