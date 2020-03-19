using System;
using System.Collections.Generic;
using InTheLoop.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using InTheLoop.Models;

namespace InTheLoop.Data
{
    public static class ListsDb
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

        public static async Task<List> GetListById(int id, ApplicationDbContext context)
        {
            List l = await (from list in context.Lists
                            where list.ListId == id
                            select list).SingleOrDefaultAsync();
            return l;
        }

        /// <summary>
        /// Deletes the List from the database if the ListId matches the ListId passed.
        /// </summary>
        /// <param name="id">ListId to be checked </param>
        /// <param name="context">Database context</param>
        /// <returns></returns>
        public static async Task DeleteByListId(int id, ApplicationDbContext context)
        {
            //Create List object with id wanting to be removed
            List l = new List()
            {
                ListId = id
            };

            context.Entry(l).State = EntityState.Deleted;
            await context.SaveChangesAsync();
        }
    }
}
