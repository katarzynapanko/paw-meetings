using System.ComponentModel.DataAnnotations;

namespace PetsFile.Application.Authentication
{
    public class LoginModel
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
