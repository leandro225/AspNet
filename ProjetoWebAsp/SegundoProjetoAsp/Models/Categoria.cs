using System.ComponentModel.DataAnnotations;

namespace SegundoProjetoAsp.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }

        [Required, StringLength(30)]
        public string Nome { get; set; }

        public bool Ativo { get; set; }
    }
}