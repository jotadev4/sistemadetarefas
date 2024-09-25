namespace gerenciamentodetarefas.Models
{
    public class UsuarioModel
    { // estrutura que vai printar na API
        public int Id { get; set; }
        public string? Nome { get; set; } // usuario pode ter numero
        public string? Email { get; set; }

    }
}
