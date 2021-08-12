using System.ComponentModel.DataAnnotations;

namespace webapi.Models
{
    public class Category
    {
        [Key]
        public int Id {get;set;}

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(30, ErrorMessage ="Campo deve conter no máximo 30 caracteres")]
        [MinLength(3, ErrorMessage ="Campo deve conter no mínimo 3 caracteres")]
        public string Title {get;set;}
    }
}