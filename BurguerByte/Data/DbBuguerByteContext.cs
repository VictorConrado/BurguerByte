using BurguerByte.Data;
using BurguerByte.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BurguerByte.Data
{
    public class DbBuguerByteContext : DbContext
    {
        public DbBuguerByteContext(DbContextOptions<DbBuguerByteContext> options) : base(options) { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoItem> PedidoItens { get; set; }
    }
}
