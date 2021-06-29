using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Student_Management.Business;
using Student_Management.Data;

namespace Student_Management.Pages.StudentEnrollment
{
    public class DeleteModel : PageModel
    {
        private readonly Student_Management.Data.Student_ManagementContext _context;

        public DeleteModel(Student_Management.Data.Student_ManagementContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Student_Enrollment Student_Enrollment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student_Enrollment = await _context.Student_Enrollment.FirstOrDefaultAsync(m => m.student_Enrollment_ID == id);

            if (Student_Enrollment == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student_Enrollment = await _context.Student_Enrollment.FindAsync(id);

            if (Student_Enrollment != null)
            {
                _context.Student_Enrollment.Remove(Student_Enrollment);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
