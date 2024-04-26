using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProdutoServico.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        [Column("Product_Name")]
        public string ProductName { get; set; } = string.Empty;
        [Column("Product_Price")]
        public float Price { get; set; } = 0;
        public ICollection<Categoria> Categorias { get; set; }
    }
}
