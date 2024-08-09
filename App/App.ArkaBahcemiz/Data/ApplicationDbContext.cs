using App.ArkaBahcemiz.Models.Entities;
using Microsoft.EntityFrameworkCore;
using App.ArkaBahcemiz.Models.DTOs;


namespace App.ArkaBahcemiz.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<App.ArkaBahcemiz.Models.DTOs.UserDTO> UserDTO { get; set; } = default!;

    }
}
