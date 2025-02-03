using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlogWebApp.Server.Models;

namespace BlogWebApp.Server.Data
{
    public class BlogWebAppContext : DbContext
    {
        public BlogWebAppContext (DbContextOptions<BlogWebAppContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BusinessContactDetails>().HasData(
                new BusinessContactDetails
                {
                    BusinessContactId = 1,
                    BusinessName = "On A Whim Studios",
                    BusinessEmail = "I Aint Giving you that (;",
                    BusinessPhone = "(360) 360-3600",
                    BusinessAddress = "1600 Pennsylvania Avenue NW, Washington, DC 20500"
                },
                new BusinessContactDetails
                {
                    BusinessContactId = 2,
                    BusinessName = "Toast LLC.",
                    BusinessEmail = "jesse@toast.llc",
                    BusinessPhone = "(360) 555-5555",
                    BusinessAddress = "1600 Pennsylvania Avenue NW, Washington, DC 20500"
                },
                new BusinessContactDetails
                {
                    BusinessContactId = 2,
                    BusinessName = "Bogus Industries",
                    BusinessEmail = "Bogus@whatevenisthelimitforthelengthoftheemaildomainidontreallyknow.idk",
                    BusinessPhone = "(360) 555-5555",
                    BusinessAddress = "1600 Pennsylvania Avenue NW, Washington, DC 20500"
                }
            );

            modelBuilder.Entity<FeedbackData>().HasData();
        }

        public DbSet<BlogWebApp.Server.Models.BusinessContactDetails> BusinessContactDetails { get; set; } = default!;
        public DbSet<BlogWebApp.Server.Models.DynamicContent> DynamicContent { get; set; } = default!;
        public DbSet<BlogWebApp.Server.Models.FeedbackData> FeedbackData { get; set; } = default!;
        public DbSet<BlogWebApp.Server.Models.StaticContent> StaticContent { get; set; } = default!;
    }
}
