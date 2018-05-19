
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.CopaMundo.Core.Models
{
    [Table("Selecao")]
    public class Selecao : EntidadeDominio
    {
        [StringLength(25)]
        public string Pais { get; set; }

        [StringLength(50)]
        public string Bandeira { get; set; }

        public bool Eliminado { get; set; }

        public int GrupoId { get; set; }

        [ForeignKey("GrupoId")]
        public Grupo Grupo { get; set; }

        public int TabelaId { get; set; }

        [ForeignKey("TabelaId")]
        public Tabela Tabela { get; set; }

        [InverseProperty("Selecao")]
        public ICollection<Jogador> Jogadores { get; set; }

        [InverseProperty("Selecao")]
        public ICollection<PartidaDetalhe> Partidas { get; set; }

        [InverseProperty("Selecao")]
        public ICollection<Configuracao> Configuracoes { get; set; }

    }
}
