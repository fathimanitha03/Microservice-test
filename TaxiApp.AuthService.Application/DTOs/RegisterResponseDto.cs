using System;
using System.Collections.Generic;
using System.Text;

namespace TaxiApp.AuthService.Application.DTOs
{
    public class RegisterResponseDto
    {
        public Guid Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
    }
}
