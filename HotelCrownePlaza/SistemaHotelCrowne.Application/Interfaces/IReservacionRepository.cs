using System.Collections.Generic;
using System.Threading.Tasks;
using SistemaHotelCrowne.Domain.Entities;

namespace SistemaHotelCrowne.Application.Interfaces
{
    public interface IReservacionRepository : IRepositoryBase<Reservacion>
    {
        // Obtiene todas las reservaciones que ha hecho un cliente en su historial
        Task<IReadOnlyList<Reservacion>> GetByClienteIdAsync(int clienteId);

        // Verifica si una habitación específica ya está ocupada en un rango de fechas
        Task<bool> IsHabitacionOcupadaAsync(int habitacionId, System.DateTime fechaInicio, System.DateTime fechaFin);
    }
}