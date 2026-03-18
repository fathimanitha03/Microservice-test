using System;
using System.Collections.Generic;
using System.Text;
using TaxiApp.AuthService.Domain.Entities;



namespace TaxiApp.AuthService.Application.Interfaces;

public interface IUserRepository
{
    Task<User?> GetByEmailAsync(string email);
    Task AddAsync(User user);
    Task SaveChangesAsync();
}