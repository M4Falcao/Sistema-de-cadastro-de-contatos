using System.ComponentModel.DataAnnotations;

namespace SistemaDeContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do contato")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o Email do contato")]
        [EmailAddress(ErrorMessage = "O email informado não é valido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite o celular do contato")]
        [Phone(ErrorMessage = "O celualar informado não é valido")]
        public string Celular { get; set; }

    }
}
