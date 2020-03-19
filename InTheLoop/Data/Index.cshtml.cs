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
    public class IndexModel : PageModel
    {
        private readonly InTheLoop.Data.ApplicationDbContext _context;

        public IndexModel(InTheLoop.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<List> List { get;set; }

        public async Task OnGetAsync()
        {
            List = await _context.Lists.ToListAsync();
        }
    }
}
