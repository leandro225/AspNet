

using System.ComponentModel.DataAnnotations;

namespace ProjetoWebAsp.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }

        [Display (Name = "Titulo")]//propriedade nome mostre titulo
        [Required(ErrorMessage ="!!! Campo Obrigatorio !!! ")] // faz a validacao torna o campo obrigatotio
        public string Nome { get; set; }

        public bool Ativo { get; set; }

    }
}