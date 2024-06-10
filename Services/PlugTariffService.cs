using InternetPoint.Models;
using InternetPoint.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

public class PlugTariffService
{
    private readonly UserDbContext _context;
    private readonly UserStateService _userStateService;
    private readonly NavigationManager _navigationManager;

    public PlugTariffService(UserDbContext context, UserStateService userStateService, NavigationManager navigationManager)
    {
        _context = context;
        _userStateService = userStateService;
        _navigationManager = navigationManager;
    }

    public async Task Plug(ServiceInfo serviceInfo)
    {
        if (_userStateService.IsAuthenticated)
        {
            var order = new Order();
            order.ServiceId = serviceInfo.ServiceID;
            order.UserId = _userStateService.GetUserId();
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
        }
        else
        {
            _navigationManager.NavigateTo("/customer-form");
        }
    }

}
