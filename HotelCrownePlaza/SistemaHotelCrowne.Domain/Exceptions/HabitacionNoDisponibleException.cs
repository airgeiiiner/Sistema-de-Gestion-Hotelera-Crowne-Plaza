using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaHotelCrowne.Domain.Exceptions
{
    public class HabitacionNoDisponibleException : Exception
    {
        public HabitacionNoDisponibleException(string tipoHabitacion, DateTime fecha)
            : base($"La habitación de tipo '{tipoHabitacion}' no está disponible para la fecha {fecha.ToShortDateString()}.");
    }
}
