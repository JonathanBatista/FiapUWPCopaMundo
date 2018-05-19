using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.CopaMundo.Core.Models
{
    [Table("Configuracao")]
    public class Configuracao : EntidadeDominio
    {
        public bool Notificar { get; set; }

        public int SelecaoId { get; set; }

        [ForeignKey("SelecaoId")]
        public Selecao Selecao { get; set; }

        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }
    }
}