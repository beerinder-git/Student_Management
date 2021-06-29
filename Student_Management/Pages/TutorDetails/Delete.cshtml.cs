using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Student_Management.Business;
using Student_Management.Data;

namespace Student_Management.Pages.TutorDetails
{
    public class DeleteModel : PageModel
    {
        private readonly Student_Management.Data.Student_ManagementContext _context;

        public DeleteModel(Student_Management.Data.Student_ManagementContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Tutor_Details Tutor_Details { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Tutor_Details = await _context.Tutor_Details.FirstOrDefaultAsync(m => m.tutor_ID == id);

            if (Tutor_Details == null)
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

            Tutor_Details = await _context.Tutor_Details.FindAsync(id);

            if (Tutor_Details != null)
            {
                _context.Tutor_Details.Remove(Tutor_Details);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
