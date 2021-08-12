using System.ComponentModel.DataAnnotations;

namespace webapi.Models
{
    public class Product
    {
        [Key]
        public int Id {get;set;}

        [Required(ErrorMessage ="Campo obrigatório")]
        [MinLength(3, ErrorMessage ="Campo deve conter no mínimo 3 caracteres")]
        [MaxLength(60, ErrorMessage = "Campo deve conter no máximo 60 caracteres")]
        public string Name {get;set;}


        [MaxLength(1024, ErrorMessage = "Campo deve conter no máximo 1024 caracteres")]
        public string Description {get;set;}


        [Required(ErrorMessage ="Campo obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "preço deve ser maior que zero")]
        public decimal Price {get;set;}


        [Required(ErrorMessage ="Campo obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage ="Categoria inválida")]
        public int CategoryId {get;set;}

        public Category Category {get;set;}

    }
}