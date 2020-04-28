using System;
using Microsoft.EntityFrameworkCore;

namespace Instagrames.Models
{
    public class InstaDb : DbContext
    {
        public InstaDb(DbContextOptions<InstaDb> options) : base(options)
        {
        }

        public DbSet<Post> Posts {get;set;}
        public DbSet<User> Users {get;set;}
        public DbSet<Comment> Comments {get;set;}
    }
}