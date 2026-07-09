using HotelCrownePlaza.Domain.Enums;

namespace HotelCrownePlaza.Domain.Entities;

public class Reservacion
{
    public int Id { get; private set; }

    public int ClienteId { get; private set; }

    public int HabitacionId { get; private set; }

    public DateTime FechaEntrada { get; private set; }

    public DateTime FechaSalida { get; private set; }

    public EstadoReservacion Estado { get; private set; }

    public Cliente Cliente { get; private set; }

    public Habitacion Habitacion { get; private set; }

    protected Reservacion() { }

    public Reservacion(
        int clienteId,
        int habitacionId,
        DateTime fechaEntrada,
        DateTime fechaSalida)
    {
        if (clienteId <= 0)
            throw new ArgumentException("Cliente inválido.");

        if (habitacionId <= 0)
            throw new ArgumentException("Habitación inválida.");

        if (fechaSalida <= fechaEntrada)
            throw new ArgumentException("La fecha de salida debe ser mayor que la fecha de entrada.");

        ClienteId = clienteId;
        HabitacionId = habitacionId;
        FechaEntrada = fechaEntrada;
        FechaSalida = fechaSalida;

        Estado = EstadoReservacion.Confirmada;
    }

    public void RegistrarCheckIn()
    {
        if (Estado != EstadoReservacion.Confirmada)
            throw new InvalidOperationException(
                "Solo las reservaciones confirmadas pueden realizar check-in.");

        Estado = EstadoReservacion.InHouse;
    }

    public void Cancelar()
    {
        Estado = EstadoReservacion.Cancelada;
    }
}