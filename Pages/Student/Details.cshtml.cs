using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentApp.Data;
using StudentApp.Model;

namespace StudentApp.Pages.Student
{
    public class DetailsModel : PageModel
    {
        private readonly StudentApp.Data.StudentAppContext _context;

        public DetailsModel(StudentApp.Data.StudentAppContext context)
        {
            _context = context;
        }

        public Students Students { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var students = await _context.Students.FirstOrDefaultAsync(m => m.StudentKey == id);
            if (students == null)
            {
                return NotFound();
            }
            else
            {
                Students = students;
            }
            return Page();
        }
    }
}
