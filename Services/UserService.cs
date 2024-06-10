﻿using InternetPoint.Models;
using Microsoft.EntityFrameworkCore;

public class UserService
{
    private readonly UserDbContext _context;

    public UserService(UserDbContext context)
    {
        _context = context;
    }

    public async Task<User> GetUserByIdAsync(int userId)
    {
        return await _context.Users
                             .FirstOrDefaultAsync(u => u.Id == userId);
    }

    public async Task UpdateUserAsync(User user)
    {
        _context.Users.Update(user);
        await _context.SaveChangesAsync();
    }
}
