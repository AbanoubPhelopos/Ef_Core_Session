using Ef_Core_Application.Models;
using Microsoft.EntityFrameworkCore;

namespace Ef_Core_Application.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options
                .UseSqlServer("Server=DESKTOP-TFU0IME\\SQLEXPRESS;" +
                                    "Database=EfCore;Trusted_Connection=True;" +
                                        "TrustedServerCertificate=true;");
        }

        public DbSet<Student> Students { get; set; }
    }
}
