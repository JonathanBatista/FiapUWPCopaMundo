using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.CopaMundo.Core.Models
{
    
    public abstract class EntidadeDominio
    {
        [Key, Column(Order = 0)]
        public int Id { get; set; }
    }
}
