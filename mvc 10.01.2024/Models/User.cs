namespace mvc_10._01._2024.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get;set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
