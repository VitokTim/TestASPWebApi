using Microsoft.EntityFrameworkCore;
using TestASPWebApi.Data;
using TestASPWebApi.Interfaces;
using TestASPWebApi.Models;

namespace TestASPWebApi.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly AppDbContext _context;

        public ClientRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Client>> GetAll()
        {
            return await _context.Clients.ToListAsync();
        }

        public async Task<Client> GetById(int id)
        {
            return await _context.Clients.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Client> Create(Client client)
        {
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();

            return client;
        }
    }
}
