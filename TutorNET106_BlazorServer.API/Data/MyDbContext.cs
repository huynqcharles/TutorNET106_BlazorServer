using Microsoft.EntityFrameworkCore;
using Shared;
using System.Net.Http.Headers;

namespace TutorNET106_BlazorServer.API.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<FileUpload> FileUploads { get; set; }
    }
}
