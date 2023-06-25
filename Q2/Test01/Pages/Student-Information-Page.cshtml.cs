using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Test01.Data;
using Test01.Model;

namespace Test01.Pages
{
    public class Student_Information_PageModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IEnumerable<Courses> Categories1 { get; set; }
        public IEnumerable<Students> Categories { get; set; }
        
        public Student_Information_PageModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Categories1 = _db.Courses;
            Categories = _db.Students;
        } 
    }
}
