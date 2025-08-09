using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BurguerByte.Models.Entities
{
    public class Pedido
    {

        [Key]
        public int Id { get; set; }

        public DateTime DataPedido { get; set; }

        [Required, StringLength(50)]
        public string Status { get; set; } // "Em preparo", "Entregue", etc.

        [Column(TypeName = "decimal(18,2)")]
        public decimal Total { get; set; }

        // FK
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public ICollection<PedidoItem> Itens { get; set; }
    }
}
