using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc_10._01._2024.Models
{
    public class Task
    {
        [Key]
        public int TaskId { get; set; }

        [Required(ErrorMessage = "Please enter a task title.")]
        [StringLength(100, ErrorMessage = "The title cannot exceed 100 characters.")]
        public string Title { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please enter a description of the task.")]
        public string Description { get; set; }

        [Display(Name = "Is Complete")]
        public bool IsComplete { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Due Date")]
        public DateTime DueDate { get; set; }

        // Foreign key for the user who owns the task
        [ForeignKey("User")]
        public string UserId { get; set; }

        // Navigation property for Entity Framework to link user to tasks
        public virtual ApplicationUser User { get; set; }
    }
}
