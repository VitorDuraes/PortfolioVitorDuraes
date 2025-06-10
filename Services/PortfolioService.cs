using PortfolioVitorDuraes.Models;

namespace PortfolioVitorDuraes.Services
{
    public class PortfolioService
    {
        public Contato GetContato()
        {
            return new Contato
            {
                Nome = "Vitor Durães",
                Email = "vitordo09@hotmail.com",
                Telefone = "+55 (34) 99177-5784",
                Localizacao = "Uberlândia, Minas Gerais",
                LinkedIn = "linkedin.com/in/vitor-duraes",
                GitHub = "github.com/VitorDuraes"
            };
        }

        public List<ExperienciaProfissional> GetExperiencias()
        {
            return new List<ExperienciaProfissional>
            {
                new ExperienciaProfissional
                {
                    Empresa = "Tech Mahindra",
                    Cargo = "Analista de Sistemas",
                    DataInicio = new DateTime(2024, 7, 1),
                    DataFim = null,
                    Responsabilidades = new List<string>
                    {
                        "Automatizar fluxos em plataformas e-commerce B2B, aumentando a eficiência operacional",
                        "Testei e integrei APIs com Postman para garantir qualidade e segurança",
                        "Realizei monitoramento de sistemas com Datadog e Dynatrace, prevenindo falhas",
                        "Gerenciei chamados N1/N2 via Movidesk, Zendesk, ServiceNow e Jira",
                        "Coordenei entregas ágeis com Azure DevOps, incluindo versionamento e CI/CD",
                        "Provisiono infraestrutura usando Terraform para ambientes seguros e replicáveis",
                        "Realizei deploy e suporte em AWS, Azure e GCP, focando em escalabilidade e custo",
                        "Executei consultas e modelagens em Sybase, SQL Server e DynamoDB para otimização",
                        "Implementei integração entre ERP Promax e sistemas internos, automatizando processos"
                    }
                },
                new ExperienciaProfissional
                {
                    Empresa = "NTT DATA",
                    Cargo = "Analista de Sistemas",
                    DataInicio = new DateTime(2023, 4, 1),
                    DataFim = new DateTime(2024, 6, 30),
                    Responsabilidades = new List<string>
                    {
                        "Otimizei APIs e processos em sistemas B2B, resultando em aumento de performance e estabilidade",
                        "Executei testes de carga e análises de desempenho, colaborando com squads ágeis para entrega de melhorias",
                        "Atuei com banco de dados Sybase, aplicando boas práticas de modelagem e queries otimizadas"
                    }
                }
            };
        }

        public List<Projeto> GetProjetos()
        {
            return new List<Projeto>
            {
                new Projeto
                {
                    Nome = "Sistema de Delivery",
                    Descricao = "API REST completa para sistema de delivery com autenticação JWT, geração de PDFs e documentação via Swagger. Sistema robusto com arquitetura limpa e testes automatizados.",
                    Tecnologias = new List<string> { "ASP.NET Core 9", "Entity Framework Core", "SQL Server", "JWT", "Swagger", "AutoMapper" },
                    DataCriacao = new DateTime(2054, 3, 1),
                    EmDestaque = true,
                    GithubUrl = "https://github.com/VitorDuraes/Sistema-de-Delivery"
                },
                new Projeto
                {
                    Nome = "Sistema de Gerenciamento de Livros",
                    Descricao = "Sistema MVC completo para gerenciamento de biblioteca com autenticação, validação com FluentValidation, AutoMapper e injeção de dependência.",
                    Tecnologias = new List<string> { "ASP.NET Core", "Entity Framework Core", "SQL Server", "FluentValidation", "AutoMapper", "Bootstrap" },
                    DataCriacao = new DateTime(2025, 4, 12),
                    EmDestaque = true,
                    GithubUrl = "https://github.com/VitorDuraes/BookMaster"
                },
                new Projeto
                {
                    Nome = "CRM - Sistema de Gestão para Gráficas",
                    Descricao = "Sistema CRM completo para gestão de clientes e pedidos, com autenticação, segmentação automática, relatórios gerenciais, previsão de vendas com inteligência artificial em Python, validação com FluentValidation, integração com AutoMapper e injeção de dependência",
                    Tecnologias = new List<string> { "ASP.NET Core", "Entity Framework Core", "SQL Server", "FluentValidation", "AutoMapper", "ClosedXML", "Python.NET", "Bootstrap", "scikit-learn", "Python" },
                    DataCriacao = new DateTime(2025, 5, 6),
                    EmDestaque = true,
                    GithubUrl = "https://github.com/VitorDuraes/CRMProjeto"
                },
                new Projeto
                {
                    Nome = "Sistema de Gerenciamento de Tarefas",
                    Descricao = "Aplicação de To-Do List desenvolvida com ASP.NET Core e Entity Framework, utilizando SQL Server como banco de dados. O sistema permite gerenciar tarefas de forma simples e eficiente, com operações completas de CRUD (criar, listar, atualizar e remover tarefas).",
                    Tecnologias = new List<string> { "ASP.NET Core", "Entity Framework Core", "SQL Server", "JWT", "ASP.NET Core Identity" },
                    DataCriacao = new DateTime(2024, 6, 1),
                    EmDestaque = false,
                    GithubUrl = "https://github.com/VitorDuraes/To-Do-List-C-"

                }
            };
        }

        public List<Habilidade> GetHabilidades()
        {
            return new List<Habilidade>
            {
                // Linguagens
                new Habilidade { Nome = "C#", Categoria = "Linguagens", NivelProficiencia = 5 },
                new Habilidade { Nome = "JavaScript", Categoria = "Linguagens", NivelProficiencia = 4 },
                new Habilidade { Nome = "SQL", Categoria = "Linguagens", NivelProficiencia = 4 },
                
                // Frameworks
                new Habilidade { Nome = "ASP.NET Core", Categoria = "Frameworks", NivelProficiencia = 5 },
                new Habilidade { Nome = "Entity Framework Core", Categoria = "Frameworks", NivelProficiencia = 5 },
                new Habilidade { Nome = "Blazor", Categoria = "Frameworks", NivelProficiencia = 4 },
                new Habilidade { Nome = "xUnit", Categoria = "Frameworks", NivelProficiencia = 4 },
                new Habilidade { Nome = "NUnit", Categoria = "Frameworks", NivelProficiencia = 4 },
                
                // Bancos de Dados
                new Habilidade { Nome = "SQL Server", Categoria = "Bancos de Dados", NivelProficiencia = 5 },
                new Habilidade { Nome = "PostgreSQL", Categoria = "Bancos de Dados", NivelProficiencia = 4 },
                new Habilidade { Nome = "MongoDB", Categoria = "Bancos de Dados", NivelProficiencia = 3 },
                
                // DevOps
                new Habilidade { Nome = "Azure DevOps", Categoria = "DevOps", NivelProficiencia = 4 },
                new Habilidade { Nome = "GitHub Actions", Categoria = "DevOps", NivelProficiencia = 4 },
                new Habilidade { Nome = "Docker", Categoria = "DevOps", NivelProficiencia = 3 },
                
                // Arquitetura
                new Habilidade { Nome = "Clean Architecture", Categoria = "Arquitetura", NivelProficiencia = 4 },
                new Habilidade { Nome = "DDD", Categoria = "Arquitetura", NivelProficiencia = 4 },
                new Habilidade { Nome = "SOLID", Categoria = "Arquitetura", NivelProficiencia = 5 }
            };
        }

        public string GetResumo()
        {
            return "Desenvolvedor Back-end júnior com experiência prática em C#, ASP.NET Core e Entity Framework. " +
                   "Desenvolvimento de APIs RESTful seguras e escaláveis, com foco em arquitetura limpa e testes automatizados. " +
                   "Conhecimento em bancos de dados SQL Server, MongoDB e metodologias ágeis (Scrum/Kanban). " +
                   "Proativo, organizado e dedicado ao aprendizado contínuo.";
        }
    }
}

