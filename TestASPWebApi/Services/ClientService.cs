using TestASPWebApi.DTOs;
using TestASPWebApi.Interfaces;
using TestASPWebApi.Models;

namespace TestASPWebApi.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<IEnumerable<ClientResponseDto>> GetAll()
        {
            var clients = await _clientRepository.GetAll();

            return clients.Select(c => new ClientResponseDto
            {
                Id = c.Id,
                Name = c.Name,
                Email = c.Email
            });
        }

        public async Task<ClientResponseDto> GetById(int id)
        {
            var client = await _clientRepository.GetById(id);

            if (client == null)
                return null;

            return new ClientResponseDto
            {
                Id = client.Id,
                Name = client.Name,
                Email = client.Email
            };
        }

        public async Task<ClientResponseDto> Create(CreateClientDto dto)
        {
            var client = new Client
            {
                Name = dto.Name,
                Email = dto.Email
            };

            var createdClient = await _clientRepository.Create(client);

            return new ClientResponseDto
            {
                Id = createdClient.Id,
                Name = createdClient.Name,
                Email = createdClient.Email
            };
        }
    }
}
