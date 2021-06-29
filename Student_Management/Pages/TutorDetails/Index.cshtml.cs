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
    public class IndexModel : PageModel
    {
        private readonly Student_Management.Data.Student_ManagementContext _context;

        public IndexModel(Student_Management.Data.Student_ManagementContext context)
        {
            _context = context;
        }

        public IList<Tutor_Details> Tutor_Details { get;set; }

        public async Task OnGetAsync()
        {
            Tutor_Details = await _context.Tutor_Details.ToListAsync();
        }
    }
}
