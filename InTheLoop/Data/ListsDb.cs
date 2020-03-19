using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InTheLoop.Models;

namespace InTheLoop.Data
{
    public class ListsDb
    {

        /// <summary>
        /// Adds a single List object to the database.
        /// </summary>
        /// <param name="l">The list to be added to the database.</param>
        /// <param name="context">The database context to connect to the Db</param>
        /// <returns></returns>
        public static async Task<List> Add(List l, ApplicationDbContext context)
        {
            context.Add(l);
            await context.SaveChangesAsync();
            return l;
        }
    }
}
