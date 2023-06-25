using System.ComponentModel.DataAnnotations;

namespace Test01.Model
{
    public class Courses
    {
       
            [Key]
            public int CourseID { get; set; }
            [Required]
            public string? Name { get; set; }
            [Required]
            public string? LecturerName { get; set; }
        
    }
}

