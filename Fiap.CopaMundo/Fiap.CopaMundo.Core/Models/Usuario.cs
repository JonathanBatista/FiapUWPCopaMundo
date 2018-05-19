using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.CopaMundo.Core.Models
{
    [Table("Usuario")]
    public class Usuario : EntidadeDominio
    {
        [StringLength(10)]
        public string Login { get; set; }

        [StringLength(50)]
        public string NomeExibicao { get; set; }

        [InverseProperty("Usuario")]
        public ICollection<Configuracao> Configuracoes { get; set; }
    }
}