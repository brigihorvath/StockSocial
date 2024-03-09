using Microsoft.EntityFrameworkCore;
using SocialStock.Models;

namespace SocialStock.Data;

public class ApplicationDbContext : DbContext
{
    // we also need to pass the dbcontext options to the base class
    public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {
        
    }
    
    public DbSet<Stock> Stocks { get; set; }
    
    public DbSet<Comment> Comments { get; set; }
    
    
   
}