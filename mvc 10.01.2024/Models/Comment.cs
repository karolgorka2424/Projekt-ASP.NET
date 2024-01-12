namespace mvc_10._01._2024.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public int TaskId { get; set; }
        public virtual User User { get; set; }
        public virtual Task Task { get; set; }
    }
}
