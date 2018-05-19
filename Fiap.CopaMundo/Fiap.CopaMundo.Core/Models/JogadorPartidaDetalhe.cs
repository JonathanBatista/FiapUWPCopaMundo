using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.CopaMundo.Core.Models
{
    [Table("JogadorPartidaDetalhe")]
    public class JogadorPartidaDetalhe : EntidadeDominio
    {
        [StringLength(3)]
        public string Posicao { get; set; }

        public short Gols { get; set; }

        public short NumeroCamisa { get; set; }

        public short CartaoAmarelo { get; set; }

        public short CartaoVermelho { get; set; }

        public bool Titular { get; set; }
        
        public int JogadorId { get; set; }

        [ForeignKey("JogadorId")]
        public Jogador Jogador { get; set; }
        
        public int PartidaDetalheId { get; set; }

        [ForeignKey("PartidaDetalheId")]
        public PartidaDetalhe PartidaDetalhe { get; set; }

        public int? SubstitutoId { get; set; }

        [ForeignKey("SubstitutoId")]
        public JogadorPartidaDetalhe Substituto { get; set; }
    }
}