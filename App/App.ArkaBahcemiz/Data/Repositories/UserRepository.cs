using App.ArkaBahcemiz.Models.DTOs;
using App.ArkaBahcemiz.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace App.ArkaBahcemiz.Data.Repositories
{
    public class UserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserByEmail(User user)
        {
            // Veritabanında email'e göre kullanıcıyı bul
            var result = await _context.Users.FirstOrDefaultAsync(u => u.Email == user.Email);

            // Eğer kullanıcı bulunursa geri dön
            if (result != null)
            {
                if (result.PasswordHashed != user.PasswordHashed)
                {
                    return null;
                }
                return result;

            }

            // Eğer kullanıcı bulunamazsa, null dön
            return null;
        }
    }
}
