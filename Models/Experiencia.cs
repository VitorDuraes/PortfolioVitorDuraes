using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioVitorDuraes.Models
{
    public class ExperienciaProfissional
    {
        public string Empresa { get; set; } = string.Empty;
        public string Cargo { get; set; } = string.Empty;
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public List<string> Responsabilidades { get; set; } = new();
        public string? Logo { get; set; }
    }

}