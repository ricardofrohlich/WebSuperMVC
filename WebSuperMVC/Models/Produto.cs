using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSuperMVC.Models
{
    public class Produto
    {
        [Key] //definindo a chave primária
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Campo obrigatório")] //definindo que o campo é obrigatório
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")] //definindo o tamanho máximo do campo
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")] //definindo que o campo é obrigatório
        [Range(0.01, 9999.99, ErrorMessage = "Valor inválido")] //definindo o valor mínimo e máximo do campo
        [Column(TypeName = "decimal(10,2)")] //definindo o tipo do campo no banco de dados
        public decimal Preco { get; set; }
    }
}
