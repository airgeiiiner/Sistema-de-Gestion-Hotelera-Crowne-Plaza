namespace HotelCrownePlaza.Domain.Entities;

public class Cliente
{
    public int Id { get; private set; }

    public string Nombre { get; private set; }

    public string Apellido { get; private set; }

    public string Documento { get; private set; }

    public string Telefono { get; private set; }

    public string Correo { get; private set; }

    protected Cliente() { }

    public Cliente(
        string nombre,
        string apellido,
        string documento,
        string telefono,
        string correo)
    {
        if (string.IsNullOrWhiteSpace(nombre))
            throw new ArgumentException("El nombre es obligatorio.");

        if (string.IsNullOrWhiteSpace(apellido))
            throw new ArgumentException("El apellido es obligatorio.");

        if (string.IsNullOrWhiteSpace(documento))
            throw new ArgumentException("El documento es obligatorio.");

        Nombre = nombre;
        Apellido = apellido;
        Documento = documento;
        Telefono = telefono;
        Correo = correo;
    }
}