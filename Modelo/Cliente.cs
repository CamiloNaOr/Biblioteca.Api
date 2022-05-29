using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Api.Modelo
{
    public class Cliente
    {
        [Key]
        public string NombreCliente { get; set; }
        public string NombreEmpresa { get; set; }
        public int Compras { get; set; }
        public int Credito { get; set; }
        public string Descripcion { get; set; }
    }
}
