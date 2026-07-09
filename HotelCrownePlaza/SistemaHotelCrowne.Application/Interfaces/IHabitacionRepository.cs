using System.Collections.Generic;
using System.Threading.Tasks;
using SistemaHotelCrowne.Domain.Entities;
using SistemaHotelCrowne.Domain.Enums;

namespace SistemaHotelCrowne.Application.Interfaces
{
    public interface IHabitacionRepository : IRepositoryBase<Habitacion>
    {
        // Permite buscar habitaciones según su estado actual (Disponible, Ocupada, Mantenimiento)
        Task<IReadOnlyList<Habitacion>> GetByEstadoAsync(EstadoHabitacion estado);
    }
}