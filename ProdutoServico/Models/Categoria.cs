using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProdutoServico.Models
{
    [Table("Categoria")]
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Column("Nome_categoria")]
        public string CatName { get; set; }
        [Column("Product_Id")]
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public List<Produto> Produto { get; set; }
    }
}
