    using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.CopaMundo.Core.Models
{
    [Table("Tabela")]
    public class Tabela : EntidadeDominio
    {
        public short Pontuacao { get; set; }

        public short Jogos { get; set; }

        public short Vitorias { get; set; }

        public short Derrotas { get; set; }

        public short Empates { get; set; }

        public decimal SaldoGols { get; set; }
    }
}