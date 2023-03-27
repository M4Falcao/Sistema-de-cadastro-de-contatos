using SistemaDeContatos.Data;
using SistemaDeContatos.Models;

namespace SistemaDeContatos.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;

        public ContatoRepositorio(BancoContext bancoContext)
        {
            this._bancoContext = bancoContext;
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }

        public ContatoModel BuscarPorId(int id)
        {
           return _bancoContext.Contatos.FirstOrDefault(b => b.Id == id);
        }

        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }

        public ContatoModel Editar(ContatoModel contato)
        {
            ContatoModel dbContato = this.BuscarPorId(contato.Id);

            if (dbContato == null) throw new Exception("Não existe niguem com esse id");

            dbContato.Nome= contato.Nome;
            dbContato.Email= contato.Email;
            dbContato.Celular = contato.Celular;

            _bancoContext.Contatos.Update(dbContato);
            _bancoContext.SaveChanges();

            return dbContato;
        }

        public bool Excluir(int id)
        {
            ContatoModel dbContato = this.BuscarPorId(id);

            if (dbContato == null) throw new Exception("Não existe niguem com esse id");

            _bancoContext.Contatos.Remove(dbContato);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
