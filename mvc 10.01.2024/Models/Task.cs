namespace mvc_10._01._2024.Models
{
    public class Task
    {
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int? UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
