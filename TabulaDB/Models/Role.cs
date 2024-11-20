namespace TabulaDB.Models
{
    public class Role
    {
        public int Id {get; set; }
        [Column(TypeName = "varchar(255)"]
        public string Name { get; set; }
        public ICollection<User> Users { get; } = new List<User>();
        
        //TimeStamps
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedAt { get; set; }
    }
}
