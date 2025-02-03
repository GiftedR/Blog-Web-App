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
                    BusinessContactId = 3,
                    BusinessName = "Bogus Industries",
                    BusinessEmail = "Bogus@whatevenisthelimitforthelengthoftheemaildomainidontreallyknow.idk",
                    BusinessPhone = "(360) 555-5555",
                    BusinessAddress = "1600 Pennsylvania Avenue NW, Washington, DC 20500"
                }
            );

            modelBuilder.Entity<DynamicContent>().HasData(
                new DynamicContent
                {
                    DynamicContentID = 1,
                    Title = "Big First Post",
                    Description = "Juan Post",
                    Author = "Dr. Meowdy",
                    Body = "This is a test of the first post made from the seeded data (:",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                new DynamicContent
                {
                    DynamicContentID = 2,
                    Title = "What kind of Post is this?",
                    Description = "I dont really know what the post is or whatever.",
                    Author = "Not You",
                    Body = "This is another sample post of stuff. Idk, I making a post while I be snacking.",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                }
            );

            modelBuilder.Entity<FeedbackData>().HasData(
                new FeedbackData
                {
                    FeedbackID = 1,
                    FeedbackName = "Design",
                    FeedbackDescription = "This design sucks. It doesnt exist!",
                    FeedbackEmail = "stuff@fauxemail.com"
                },
                new FeedbackData
                {
                    FeedbackID = 2,
                    FeedbackName = "Server",
                    FeedbackDescription = "Why Am I getting an error 418?",
                    FeedbackEmail = "coffee@teapot.com"
                }
            );

            modelBuilder.Entity<StaticContent>().HasData(
                new StaticContent
                {
                    StaticContentID = 1,
                    Name = "Wireframe",
                    Content = "Awesome Layout Content!",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                new StaticContent
                {
                    StaticContentID = 2,
                    Name = "Scrum Bible",
                    Content = "Have you read the Scrum Manifesto?",
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                }
            );
        }

        public DbSet<BlogWebApp.Server.Models.BusinessContactDetails> BusinessContactDetails { get; set; } = default!;
        public DbSet<BlogWebApp.Server.Models.DynamicContent> DynamicContent { get; set; } = default!;
        public DbSet<BlogWebApp.Server.Models.FeedbackData> FeedbackData { get; set; } = default!;
        public DbSet<BlogWebApp.Server.Models.StaticContent> StaticContent { get; set; } = default!;
    }
}
