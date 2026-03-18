using System;
using System.Collections.Generic;
using System.Text;
using TaxiApp.AuthService.Domain.Entities;

namespace TaxiApp.AuthService.Application.Interfaces;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}
