﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentApp.Data;
using StudentApp.Model;

namespace StudentApp.Pages.Course
{
    public class CreateModel : PageModel
    {
        private readonly StudentApp.Data.StudentAppContext _context;

        public CreateModel(StudentApp.Data.StudentAppContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Courses Courses { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Courses.Add(Courses);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
