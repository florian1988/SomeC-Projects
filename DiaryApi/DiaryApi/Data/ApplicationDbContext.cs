using DiaryApi.Models;
using Microsoft.EntityFrameworkCore;


namespace DiaryApi.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<DiaryEntry> DiaryEntries { get; set; }
    
}