using Blazored.LocalStorage;
using InternetPoint.Models;

namespace InternetPoint.Services
{
    public class UserStateService
    {
        public static Action<CancellationToken?> OnUnauthorized { get; set; }

        public Action<CancellationToken?> OnSignOut { get; set; }
        public Action<CancellationToken?> OnSignIn { get; set; }

        public bool IsAuthenticated => _user != null;
        public bool IsAdmin => _user?.IsAdmin ?? false;

        private ILocalStorageService _localStorageService;

        private User _user { get; set; }

        public UserStateService(ILocalStorageService localStorageService)
        {
            _localStorageService = localStorageService;
        }

        public async Task InitUserStateAsync()
        {
            _user = await GetUserAsync(default);
        }

        public async Task<User> GetUserAsync(CancellationToken cancellationToken)
        {
            var user = await _localStorageService.GetItemAsync<User>("user");
            return user;
        }

        public async Task SignInAsync(User user, CancellationToken cancellationToken = default)
        {
            await _localStorageService.SetItemAsync("user", user);
            _user = user;
            OnSignIn?.Invoke(cancellationToken);
        }

        public async Task SignOutAsync(CancellationToken cancellationToken = default)
        {
            _user = null;
            await _localStorageService.RemoveItemAsync("user", cancellationToken);
            OnSignOut?.Invoke(cancellationToken);
        }

        public int GetUserId()
        {
            return _user?.Id ?? 0; // Возвращает Id пользователя или 0, если пользователь не аутентифицирован
        }

        public User GetCurrentUser()
        {
            return _user; // Возвращает текущего пользователя
        }
    }
}
