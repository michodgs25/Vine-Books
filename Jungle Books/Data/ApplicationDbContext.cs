using Jungle_Books.Models;
using Microsoft.EntityFrameworkCore;

namespace Jungle_Books.Data;

public class ApplicationDbContext :DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<Models.Category> Categories { get; set; }
}
