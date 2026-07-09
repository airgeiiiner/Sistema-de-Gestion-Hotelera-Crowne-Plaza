using HotelCrownePlaza.Domain.Enums;

namespace HotelCrownePlaza.Domain.Entities;

public class Habitacion
{
    public int Id { get; private set; }

    public string Numero { get; private set; }

    public TipoHabitacion Tipo { get; private set; }

    public EstadoHabitacion Estado { get; private set; }

    protected Habitacion() { }

    public Habitacion(
        string numero,
        TipoHabitacion tipo)
    {
        if (string.IsNullOrWhiteSpace(numero))
            throw new ArgumentException("El número es obligatorio.");

        Numero = numero;
        Tipo = tipo;
        Estado = EstadoHabitacion.Disponible;
    }

    public void Ocupar()
    {
        Estado = EstadoHabitacion.Ocupada;
    }

    public void Liberar()
    {
        Estado = EstadoHabitacion.Disponible;
    }

    public void EnviarAMantenimiento()
    {
        Estado = EstadoHabitacion.EnMantenimiento;
    }
}