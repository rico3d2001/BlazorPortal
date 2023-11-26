using System.ComponentModel.DataAnnotations;

namespace BlazorPortal.ViewModel
{
    public class UserLogin
    {
        const string EMAIL_TOKEN_ATIVO = "89836650";

        [Required(ErrorMessage = "O e-mail é obrigatório")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "A senha é obrigatória")]
        public string Password { get; set; } = string.Empty;
        public string EmailTokenAtivo { get; set; } = string.Empty;
    }
}
