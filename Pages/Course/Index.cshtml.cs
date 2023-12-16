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
    public class IndexModel : PageModel
    {
        private readonly StudentApp.Data.StudentAppContext _context;

        public IndexModel(StudentApp.Data.StudentAppContext context)
        {
            _context = context;
        }

        public IList<Courses> Courses { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Courses = await _context.Courses.ToListAsync();
        }
    }
}
