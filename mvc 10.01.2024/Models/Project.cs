namespace mvc_10._01._2024.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
