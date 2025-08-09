using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BurguerByte.Models.Entities
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Nome { get; set; }

        [Required, StringLength(20)]
        public string Telefone { get; set; }

        [Required, StringLength(255)]
        public string Endereco { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }
    }
}
