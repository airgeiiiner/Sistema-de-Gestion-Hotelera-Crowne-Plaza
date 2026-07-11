using System.Threading.Tasks;
using SistemaHotelCrowne.Domain.Entities;

namespace SistemaHotelCrowne.Application.Interfaces
{
    public interface IClienteRepository : IRepositoryBase<Cliente>
    {
        // Busca a un cliente en el hotel por su documento (Cédula o Pasaporte)
        Task<Cliente> GetByDocumentoAsync(string documento);
    }
}