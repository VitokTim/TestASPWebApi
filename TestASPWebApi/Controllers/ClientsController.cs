using Microsoft.AspNetCore.Mvc;
using TestASPWebApi.DTOs;
using TestASPWebApi.Interfaces;
using TestASPWebApi.Models;

namespace TestASPWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientsController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientsController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public async Task<IEnumerable<ClientResponseDto>> GetClients()
        {
            return await _clientService.GetAll();
        }

        [HttpPost]
        public async Task<IActionResult> CreateClient(CreateClientDto dto)
        {
            var createdClient = await _clientService.Create(dto);

            return Ok(createdClient);
        }
    }
}
