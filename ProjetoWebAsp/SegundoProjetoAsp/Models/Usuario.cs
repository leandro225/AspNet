using System.ComponentModel.DataAnnotations;

namespace SegundoProjetoAsp.Models
{
    public class Usuario
    {

        public int UsuarioID { get; set; }

        [Required, StringLength(30)]
        public string Nome { get; set; }

        public bool Ativo { get; set; }
    }
}