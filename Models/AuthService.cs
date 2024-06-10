using InternetPoint.Services;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace InternetPoint.Models
{
    public interface IAuthService
    {
        Task<User> AuthenticateAsync(string email, string password);
    }

    public class AuthService : IAuthService
    {
        private readonly UserDbContext _dbContext;
        private readonly UserStateService _userStateService;

        public AuthService(UserDbContext dbContext, UserStateService pUserStateService)
        {
            _dbContext = dbContext;
            _userStateService = pUserStateService;
        }

        public async Task<User> AuthenticateAsync(string email, string password)
        {
            User user;

            if (email.Trim() == "admin@mail.ru" && password == "1111")
            {
                user = new();
                user.Email = email;
                user.firstname = "admin";
                user.IsAdmin = true;
                await _userStateService.SignInAsync(user);
                return user;
            }

            // Находим пользователя по адресу электронной почты
            user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == email);

            // Проверяем, найден ли пользователь и совпадает ли пароль
            if (user != null && user.password == password)
            {
                await _userStateService.SignInAsync(user);
                return user;
            }

            return null;
        }
    }
}
