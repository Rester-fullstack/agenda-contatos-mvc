# Agenda de Contatos com ASP.NET MVC

Uma aplicação web para gerenciar uma agenda de contatos com funcionalidades de cadastro, edição, exclusão e busca, utilizando ASP.NET MVC, Entity Framework Core e Bootstrap.

---

## Índice

- [Tecnologias](#tecnologias)
- [Funcionalidades](#funcionalidades)
- [Pré-requisitos](#pré-requisitos)
- [Configuração](#configuração)
- [Execução](#execução)
- [Estrutura do projeto](#estrutura-do-projeto)
- [Como contribuir](#como-contribuir)
- [Licença](#licença)
- [Autor](#autor)

---

## Tecnologias

- ASP.NET Core MVC (.NET 7)
- Entity Framework Core 7 (Code First)
- Bootstrap 5
- SQL Server LocalDB
- Visual Studio 2022 (ou superior)

---

## Funcionalidades

- Cadastro de contatos com nome, telefone e email.
- Busca por nome na lista de contatos.
- Edição e exclusão de contatos.
- Interface responsiva utilizando Bootstrap.
- Uso de migrações para criação e atualização do banco de dados.
- Visualização dos detalhes do contato.

---

## Pré-requisitos

- [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)
- SQL Server Express LocalDB (instalado com Visual Studio)
- Git (para controle de versão)

---

## Configuração

1. **Clone este repositório**

git clone https://github.com/SEU_USUARIO/agenda-contatos-mvc.git
cd agenda-contatos-mvc

2. **Configure a string de conexão

No arquivo appsettings.json, verifique se a connection string está assim (ajuste conforme necessário):

"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=AgendaContatosDB;Trusted_Connection=True;MultipleActiveResultSets=true"
}

3. **Restaurar pacotes NuGet

Se estiver usando Visual Studio, normalmente ele restaura automaticamente. Se quiser via terminal:

dotnet restore

--Execução

  Usando Visual Studio
  
  Abra o arquivo .sln no Visual Studio.
  
  Certifique-se que o projeto está setado como startup.
  
  Execute com F5 (modo Debug) ou Ctrl + F5 (sem Debug).

--Usando linha de comando

Para criar o banco e rodar as migrations:

  dotnet ef database update
  
Para rodar a aplicação:

  dotnet run

--Estrutura do projeto

  Controllers/ - Controladores MVC (gerenciam as requisições HTTP)
  
  Models/ - Classes de domínio (Contato.cs)
  
  Views/ - Views Razor para interface (Contatos)
  
  Data/ - Contexto do Entity Framework (AppDbContext.cs)
  
  wwwroot/ - Arquivos estáticos (CSS, JS, imagens)
  
  Program.cs - Configuração da aplicação e serviços
  
  appsettings.json - Configurações gerais, incluindo string de conexão

--Como contribuir
  Faça um fork deste repositório.
  
  Crie uma branch para sua feature (git checkout -b feature/nome-da-feature).
  
  Faça commit das suas alterações (git commit -m "Descrição da feature").
  
  Envie para sua branch no GitHub (git push origin feature/nome-da-feature).
  
  Abra um Pull Request neste repositório.
