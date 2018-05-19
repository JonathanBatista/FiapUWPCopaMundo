using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.CopaMundo.Core.Models
{
    [Table("Grupo")]
    public class Grupo : EntidadeDominio
    {

        [StringLength(1)]
        public string Identificador { get; set; }

        [InverseProperty("Grupo")]
        public ICollection<Selecao> Selecoes { get; set; }

        [InverseProperty("Grupo")]
        public ICollection<Partida> Partidas { get; set; }
    }
}