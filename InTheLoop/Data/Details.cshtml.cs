using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InTheLoop.Models;

namespace InTheLoop.Data
{
    public class DetailsModel : PageModel
    {
        private readonly InTheLoop.Data.ApplicationDbContext _context;

        public DetailsModel(InTheLoop.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public List List { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            List = await _context.Lists.FirstOrDefaultAsync(m => m.ListId == id);

            if (List == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
