using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BurguerByte.Models.Entities
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Nome { get; set; }

        [StringLength(255)]
        public string Descricao { get; set; }


        [ValidateNever]
        public ICollection<Produto> Produtos { get; set; }

        public Categoria()
        {
            Produtos = new HashSet<Produto>();
        }
    }
}
