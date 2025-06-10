namespace PortfolioVitorDuraes.Models
{
    public class Projeto
    {
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public List<string> Tecnologias { get; set; } = new();
        public string? LinkGitHub { get; set; }
        public string? LinkDemo { get; set; }
        public string? Imagem { get; set; }
        public DateTime DataCriacao { get; set; }
        public bool EmDestaque { get; set; }
        public string? GithubUrl { get; set; }
    }





}

