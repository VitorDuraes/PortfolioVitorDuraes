using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioVitorDuraes.Models
{
    public class Habilidade
    {
        public string Nome { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
        public int NivelProficiencia { get; set; } // 1-5
        public string? Icone { get; set; }
    }
}