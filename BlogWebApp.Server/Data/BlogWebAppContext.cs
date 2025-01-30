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

        public DbSet<BlogWebApp.Server.Models.BusinessContactDetails> BusinessContactDetails { get; set; } = default!;
        public DbSet<BlogWebApp.Server.Models.DynamicContent> DynamicContent { get; set; } = default!;
        public DbSet<BlogWebApp.Server.Models.FeedbackData> FeedbackData { get; set; } = default!;
        public DbSet<BlogWebApp.Server.Models.StaticContent> StaticContent { get; set; } = default!;
    }
}
