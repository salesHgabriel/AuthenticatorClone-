namespace Clone.Microsoft.Authenticator.Models
{
    public class Conta
    {
        public Conta(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public string Nome { get; set; }
        public string Email { get; set; }
    }
}