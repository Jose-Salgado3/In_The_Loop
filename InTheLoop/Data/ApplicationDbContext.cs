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
        
        //DbSet for FriendsAssociation table to be added
        public DbSet<FriendsAssociation> FriendsAssociations { get; set; }
        
        //DbSet for List table to be added.
        public DbSet<List> Lists { get; set; }


        public DbSet<ListItem> ListItems { get; set; }
    }
}
