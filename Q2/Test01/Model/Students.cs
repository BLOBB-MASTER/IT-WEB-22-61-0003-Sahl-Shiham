using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test01.Model
{
    public class Students

    {
        [Key]
        public int StudentID { get; set; }
        [Required]
        [StringLength(50)]
        public string? NAME { get; set; }
        [Required]
        [StringLength(50)]
        public string? City { get; set; }

        [Required]
        [Display(Name = "Courses")]
        public  int CourseId { get; set; }

        [ForeignKey("CourseID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual Courses Course { get; set; }
    }
}

