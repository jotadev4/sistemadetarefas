using gerenciamentodetarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace gerenciamentodetarefas.Data
{
    public class SistemaTarefasDBContex : DbContext
    {
        public SistemaTarefasDBContex(DbContextOptions<SistemaTarefasDBContex> option)
            : base(option) 
        {
        }
        public DbSet <UsuarioModel> UsuarioModels { get; set; }
    }
}
