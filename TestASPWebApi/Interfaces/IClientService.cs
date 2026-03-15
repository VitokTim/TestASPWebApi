using TestASPWebApi.DTOs;
using TestASPWebApi.Models;

namespace TestASPWebApi.Interfaces
{
    public interface IClientService
    {
        Task<IEnumerable<ClientResponseDto>> GetAll();

        Task<ClientResponseDto> GetById(int id);

        Task<ClientResponseDto> Create(CreateClientDto dto);
    }
}
