using System;
using InTheLoop.Models;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InTheLoop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Add a aDbSet for the FreindsAssociation Table in the Database]]>
        /// </summary>
        public DbSet<FriendsAssociation> FriendsAssociation { get; set; }
    }
}
