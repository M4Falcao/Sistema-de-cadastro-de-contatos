using Microsoft.EntityFrameworkCore;
using SistemaDeContatos.Models;

namespace SistemaDeContatos.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
