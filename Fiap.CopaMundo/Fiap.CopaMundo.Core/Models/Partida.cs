using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.CopaMundo.Core.Models
{
    [Table("Partida")]
    public class Partida : EntidadeDominio
    {
        public string Estadio { get; set; }

        public DateTime Horario { get; set; }

        public int GrupoId { get; set; }

        [ForeignKey("GrupoId")]
        public Grupo Grupo { get; set; }

        [InverseProperty("Partida")]
        public ICollection<PartidaDetalhe> Detalhes { get; set; }
    }
}