using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InTheLoop.Models;

namespace InTheLoop.Data
{
    public class ListsDb
    {

        public static async Task<List> Add(List l, ApplicationDbContext context)
        {
            context.Add(l);
            await context.SaveChangesAsync();
            return l;
        }
    }
}
