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
        
        // Adds a DbSet for the ListAssociations table.
        public DbSet<ListAssociation> ListAssociations { get; set; }

        public DbSet<FriendsAssociation> FriendsAssociations { get; set; }
    }
}
