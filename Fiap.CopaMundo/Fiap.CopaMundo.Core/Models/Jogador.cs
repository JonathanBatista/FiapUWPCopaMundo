using Fiap.CopaMundo.Core.Enum;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.CopaMundo.Core.Models
{
    [Table("Jogador")]
    public class Jogador : EntidadeDominio
    {
        [StringLength(50)]
        public string Nome { get; set; }

        public TipoPosicao PosicaoFavorita { get; set; }

        public short Idade { get; set; }

        public decimal Altura { get; set; }

        public short QuantidadeGols { get; set; }

        public int SelecaoId { get; set; }

        [ForeignKey("SelecaoId")]
        public Selecao Selecao { get; set; }

        [InverseProperty("Jogador")]
        public ICollection<JogadorPartidaDetalhe> Partidas { get; set; }
    }
}