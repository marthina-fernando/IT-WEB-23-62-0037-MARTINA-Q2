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
    public class DetailsModel : PageModel
    {
        private readonly StudentApp.Data.StudentAppContext _context;

        public DetailsModel(StudentApp.Data.StudentAppContext context)
        {
            _context = context;
        }

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
    }
}
