using Microsoft.EntityFrameworkCore;

namespace Jungle_Books.Data;
    public class LoginRegistrationDbContext : DbContext
    {
        public LoginRegistrationDbContext(DbContextOptions<LoginRegistrationDbContext> options) : base(options)
        { 

        }
    public DbSet<Models.LoginRegistration> loginRegistrations { get; set; }
}