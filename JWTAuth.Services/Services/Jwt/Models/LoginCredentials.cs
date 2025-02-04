﻿using System.ComponentModel.DataAnnotations;

namespace JWTAuth.Core.Services.Jwt.Models
{
    public class LoginCredentials
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "O nome de usuário é obrigatório")]
        public string Username { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória")]
        public string Password { get; set; }
    }
}
