using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaHotelCrowne.Domain.Exceptions
{
    internal class ReservacionNotFoundException
    {
        public ReservacionNotFoundException(Guid id)
            : base($"No se encontró ninguna reservación activa con el ID: {id}.");
    }
}
