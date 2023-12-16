using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentApp.Data;
using StudentApp.Model;

namespace StudentApp.Pages.Course
{
    public class DeleteModel : PageModel
    {
        private readonly StudentApp.Data.StudentAppContext _context;

        public DeleteModel(StudentApp.Data.StudentAppContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Courses Courses { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courses = await _context.Courses.FirstOrDefaultAsync(m => m.CourseKey == id);

            if (courses == null)
            {
                return NotFound();
            }
            else
            {
                Courses = courses;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courses = await _context.Courses.FindAsync(id);
            if (courses != null)
            {
                Courses = courses;
                _context.Courses.Remove(Courses);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
