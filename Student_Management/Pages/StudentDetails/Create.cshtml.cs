using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Student_Management.Business;
using Student_Management.Data;

namespace Student_Management.Pages.StudentDetails
{
    public class CreateModel : PageModel
    {
        private readonly Student_Management.Data.Student_ManagementContext _context;

        public CreateModel(Student_Management.Data.Student_ManagementContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Student_Details Student_Details { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Student_Details.Add(Student_Details);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
