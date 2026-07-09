namespace HotelCrownePlaza.Domain.Entities;

public class Folio
{
    public int Id { get; private set; }

    public int ReservacionId { get; private set; }

    public DateTime FechaApertura { get; private set; }

    public decimal SaldoTotal { get; private set; }

    public Reservacion Reservacion { get; private set; }

    protected Folio() { }

    public Folio(int reservacionId)
    {
        if (reservacionId <= 0)
            throw new ArgumentException("La reservación es obligatoria.");

        ReservacionId = reservacionId;
        FechaApertura = DateTime.Now;
        SaldoTotal = 0;
    }
}