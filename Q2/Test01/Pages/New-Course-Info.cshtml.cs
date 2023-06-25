using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Test01.Data;
using Test01.Model;

namespace Test01.Pages
{
    public class New_Course_InfoModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public Courses Course { get; set; }

        public New_Course_InfoModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(Courses Course)
        {

            if (ModelState.IsValid)
            {
                await _db.Courses.AddAsync(Course);
                await _db.SaveChangesAsync();
                return RedirectToPage("./Student-Information-Page");
            }
            return Page();
        }
    }   
}
