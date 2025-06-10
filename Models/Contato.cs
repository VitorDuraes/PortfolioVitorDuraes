using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioVitorDuraes.Models
{
    public class Contato
    {
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Localizacao { get; set; } = string.Empty;
        public string? LinkedIn { get; set; }
        public string? GitHub { get; set; }
    }
}