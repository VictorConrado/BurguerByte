using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BurguerByte.Models.Entities
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(150)]
        public string Nome { get; set; }

        [StringLength(500)]
        public string Descricao { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }

        [StringLength(255)]
        public string ImagemUrl { get; set; }

        public bool Disponivel { get; set; }

        //FK
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        public ICollection<PedidoItem> ProdutoItens { get; set; }



    }
}
