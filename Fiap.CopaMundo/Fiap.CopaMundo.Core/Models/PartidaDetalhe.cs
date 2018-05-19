using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.CopaMundo.Core.Models
{
    [Table("PartidaDetalhe")]
    public class PartidaDetalhe : EntidadeDominio
    {
        [StringLength(10)]
        public string Formacao { get; set; }

        public bool Vencedor { get; set; }

        public short GolsMarcados { get; set; }

        public short QuantidadeSubstituicoes { get; set; }

        public int PartidaId { get; set; }

        [ForeignKey("PartidaId")]
        public Partida Partida { get; set; }

        public int SelecaoId { get; set; }

        [ForeignKey("SelecaoId")]
        public Selecao Selecao { get; set; }

        [InverseProperty("PartidaDetalhe")]
        public ICollection<JogadorPartidaDetalhe> Jogadores { get; set; }
    }
}