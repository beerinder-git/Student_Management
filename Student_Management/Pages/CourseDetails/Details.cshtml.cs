﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Student_Management.Business;
using Student_Management.Data;

namespace Student_Management.Pages.CourseDetails
{
    public class DetailsModel : PageModel
    {
        private readonly Student_Management.Data.Student_ManagementContext _context;

        public DetailsModel(Student_Management.Data.Student_ManagementContext context)
        {
            _context = context;
        }

        public Course_Details Course_Details { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Course_Details = await _context.Course_Details.FirstOrDefaultAsync(m => m.course_ID == id);

            if (Course_Details == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
