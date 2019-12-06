using System.Collections.Generic;
using System.Threading.Tasks;
using backend.Domains;

namespace backend.Interfaces
{
    public interface ITelefone
    {
        Task<List<Telefone>> Listar();
        Task<Telefone> BuscarPorID(int id);
        Task<Telefone> Salvar(Telefone telefone);
        Task<Telefone> Alterar(Telefone telefone);
        Task<Telefone> Excluir(Telefone telefone);
    }
}