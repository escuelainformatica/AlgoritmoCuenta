namespace WebApplication5.Models
{
    public interface ICuenta
    {
        int Estado { get; set; }
        string Nombre { get; set; }
        string Rut { get; set; }
        int Saldo { get; set; }
    }
}