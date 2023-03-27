using SistemaDeContatos.Models;

namespace SistemaDeContatos.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel Adicionar(ContatoModel contato);
        List<ContatoModel> BuscarTodos();

        ContatoModel BuscarPorId(int id);

        ContatoModel Editar(ContatoModel contato);

        bool Excluir(int id);

    }
}
