using TestASPWebApi.Models;

namespace TestASPWebApi.Interfaces
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetAll();

        Task<Client> GetById(int id);

        Task<Client> Create(Client client);
    }
}
