# 📇 Agenda de Contatos

Aplicação web desenvolvida com **ASP.NET Core MVC** para gerenciamento de contatos, utilizando **Entity Framework Core** e **SQL Server**.

O sistema permite cadastrar, consultar, editar, pesquisar e excluir contatos por meio de uma interface web responsiva construída com Bootstrap.

---

## 🚀 Funcionalidades

- 📋 Listagem de contatos
- ➕ Cadastro de novos contatos
- ✏️ Edição de contatos
- 🗑️ Exclusão de contatos
- 🔍 Pesquisa por nome
- 👤 Visualização dos detalhes do contato
- ✅ Validação de dados
- 💾 Persistência de dados com Entity Framework Core

---

## 🛠️ Tecnologias Utilizadas

- C#
- ASP.NET Core MVC (.NET 8)
- Entity Framework Core
- SQL Server / LocalDB
- Razor Views
- Bootstrap 5

---

## 📂 Estrutura do Projeto

```text
agenda-contatos-mvc
│
├── Controllers
├── Data
├── Migrations
├── Models
├── Views
├── wwwroot
│
├── Program.cs
├── appsettings.json
└── AgendaContatosMVC.csproj
```

---

## 🏗️ Arquitetura

```text
Navegador
      │
      ▼
Controllers
      │
      ▼
Models
      │
      ▼
Entity Framework Core
      │
      ▼
SQL Server
```

---

## ▶️ Como executar

### Clone o repositório

```bash
git clone https://github.com/Rester-fullstack/agenda-contatos-mvc.git
```

Entre na pasta do projeto

```bash
cd agenda-contatos-mvc
```

### Configure a conexão

No arquivo **appsettings.json**:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=AgendaContatosDB;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```

### Crie o banco de dados

```bash
dotnet ef database update
```

### Execute a aplicação

```bash
dotnet run
```

---

## 📸 Screenshots

Adicione imagens como:

- Tela inicial
- Lista de contatos
- Cadastro
- Edição
- Pesquisa

---

## 📚 Objetivos do Projeto

Este projeto foi desenvolvido para praticar:

- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- CRUD completo
- Razor Views
- Bootstrap
- Migrations
- Arquitetura MVC

---

## 👩‍💻 Desenvolvedora

**Ester da Costa Batista**

Desenvolvedora Full Stack

### Tecnologias

- C#
- .NET
- ASP.NET Core
- React
- SQL Server
- Entity Framework Core
- APIs REST

GitHub:

https://github.com/Rester-fullstack

---

## 📄 Licença

Projeto desenvolvido para fins de estudo e portfólio.
