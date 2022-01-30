
using develop.Services;
using Microsoft.EntityFrameworkCore;
using RestApiFiles.Models;

namespace RestApiFiles.Data
{
    public class FilesDbContext: DbContext
    {
        public FilesDbContext(DbContextOptions<FilesDbContext> options) : base(options)
        {
            
        }
        
        public DbSet<File>Files { get; set; }
        public DbSet<Dev>Devs { get; set; }
        public DbSet<Prod>Prods { get; set; }

    }
}