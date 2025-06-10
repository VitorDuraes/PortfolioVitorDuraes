# Portfólio Blazor - Vitor Durães

## Descrição
Este é um portfólio completo desenvolvido em .NET com Blazor para exibir os projetos de backend de Vitor Durães. O portfólio apresenta um design moderno, responsivo e profissional, com todas as informações organizadas de forma clara e atrativa.

## Características Principais

### 🎨 Design e Interface
- Design moderno com gradientes e animações suaves
- Layout totalmente responsivo para desktop, tablet e mobile
- Navegação intuitiva com menu fixo
- Animações e transições elegantes
- Tipografia profissional com fonte Inter

### 📱 Páginas Implementadas
1. **Página Inicial** - Apresentação pessoal e resumo profissional
2. **Projetos** - Showcase dos principais projetos de backend
3. **Experiência** - Histórico profissional detalhado
4. **Habilidades** - Competências técnicas organizadas por categoria
5. **Contato** - Formulário de contato e informações pessoais

### 🛠️ Tecnologias Utilizadas
- **Frontend**: Blazor Server (.NET 8)
- **Linguagem**: C#
- **Estilização**: CSS3 com animações e responsividade
- **JavaScript**: Funcionalidades interativas
- **Arquitetura**: Clean Architecture com separação de responsabilidades

### ⚡ Funcionalidades
- Navegação fluida entre páginas
- Formulário de contato funcional
- Barras de progresso para habilidades
- Cards interativos com efeitos hover
- Menu mobile responsivo
- Animações de entrada para elementos
- Validação de formulários

## Estrutura do Projeto

```
PortfolioBlazor/
├── Components/
│   ├── Layout/
│   │   └── MainLayout.razor          # Layout principal
│   ├── Pages/
│   │   ├── Home.razor               # Página inicial
│   │   ├── Projetos.razor           # Página de projetos
│   │   ├── Experiencia.razor        # Página de experiência
│   │   ├── Habilidades.razor        # Página de habilidades
│   │   └── Contato.razor            # Página de contato
│   └── App.razor                    # Componente raiz
├── Models/
│   └── PortfolioModels.cs           # Modelos de dados
├── Services/
│   └── PortfolioService.cs          # Serviço com dados do portfólio
├── wwwroot/
│   ├── css/
│   │   └── portfolio.css            # Estilos personalizados
│   └── js/
│       └── portfolio.js             # Scripts interativos
└── Program.cs                       # Configuração da aplicação
```

## Como Executar

### Pré-requisitos
- .NET 8 SDK instalado
- Visual Studio 2022 ou VS Code (opcional)

### Passos para Execução

1. **Clone ou extraia o projeto**
   ```bash
   cd PortfolioBlazor
   ```

2. **Restaurar dependências**
   ```bash
   dotnet restore
   ```

3. **Executar a aplicação**
   ```bash
   dotnet run
   ```

4. **Acessar no navegador**
   - Abra o navegador e acesse: `https://localhost:5001` ou `http://localhost:5000`

### Execução em Produção
Para executar em produção, use:
```bash
dotnet run --environment Production
```

## Personalização

### Alterando Informações Pessoais
Edite o arquivo `Services/PortfolioService.cs` para atualizar:
- Dados de contato
- Experiências profissionais
- Projetos
- Habilidades técnicas

### Modificando Estilos
- **Cores**: Edite as variáveis CSS em `wwwroot/css/portfolio.css`
- **Layout**: Modifique os componentes em `Components/Layout/`
- **Animações**: Ajuste as animações no arquivo CSS e JavaScript

### Adicionando Novas Páginas
1. Crie um novo arquivo `.razor` em `Components/Pages/`
2. Adicione a rota com `@page "/nova-pagina"`
3. Atualize a navegação em `MainLayout.razor`

## Recursos Implementados

### 🎯 SEO e Acessibilidade
- Meta tags otimizadas
- Estrutura semântica HTML5
- Alt texts para imagens
- Navegação por teclado

### 📊 Performance
- Carregamento otimizado de recursos
- Lazy loading para imagens
- CSS e JavaScript minificados
- Componentes Blazor eficientes

### 🔧 Manutenibilidade
- Código bem documentado
- Separação clara de responsabilidades
- Modelos de dados tipados
- Serviços injetáveis

## Próximos Passos Sugeridos

1. **Integração com CMS**: Conectar com um sistema de gerenciamento de conteúdo
2. **Blog**: Adicionar seção de blog técnico
3. **Analytics**: Implementar Google Analytics
4. **PWA**: Transformar em Progressive Web App
5. **Testes**: Adicionar testes unitários e de integração

## Suporte e Contato

Para dúvidas ou sugestões sobre o portfólio:
- **Email**: vitordo09@hotmail.com
- **LinkedIn**: linkedin.com/in/vitor-duraes
- **GitHub**: github.com/VitorDuraes

---

**Desenvolvido com ❤️ usando .NET Blazor**

