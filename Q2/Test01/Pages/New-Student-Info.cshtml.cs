using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using Test01.Data;
using Test01.Model;

namespace Test01.Pages
{
    public class New_Student_InfoModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public Students Student { get; set; }

        public New_Student_InfoModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }
       

        public async Task<IActionResult> OnPost(Students Student)
        {           
            if (ModelState.IsValid)
            {
                await _db.Students.AddAsync(Student);
                await _db.SaveChangesAsync();
                return RedirectToPage("./Student-Information-Page");
            }
            return Page();
          
                    
                
        }
    }
}
