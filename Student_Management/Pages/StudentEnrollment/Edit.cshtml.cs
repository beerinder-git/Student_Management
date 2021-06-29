using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Student_Management.Business;
using Student_Management.Data;

namespace Student_Management.Pages.StudentEnrollment
{
    public class EditModel : PageModel
    {
        private readonly Student_Management.Data.Student_ManagementContext _context;

        public EditModel(Student_Management.Data.Student_ManagementContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Student_Enrollment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Student_EnrollmentExists(Student_Enrollment.student_Enrollment_ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool Student_EnrollmentExists(int id)
        {
            return _context.Student_Enrollment.Any(e => e.student_Enrollment_ID == id);
        }
    }
}
