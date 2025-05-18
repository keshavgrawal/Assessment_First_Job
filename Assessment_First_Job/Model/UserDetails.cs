using System.ComponentModel.DataAnnotations;

namespace Assessment_First_Job.Model
{
    public class UserDetails
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(25)]
        public string? Title { get; set; }
        [Required]
        [StringLength(100)]
        public string? Description { get; set; }
        public DateTime DueDate { get; set; }

        public bool IsComplete { get; set; }
    }
}
