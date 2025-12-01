Agenda de Contatos – ASP.NET MVC

Uma aplicação web completa para gerenciamento de contatos, desenvolvida com ASP.NET Core MVC, Entity Framework Core e Bootstrap 5.
Permite cadastrar, visualizar, editar, buscar e excluir contatos de forma simples e intuitiva.

🚀 Tecnologias Utilizadas

ASP.NET Core MVC (.NET 7)

Entity Framework Core 7 (Code First)

SQL Server LocalDB

Bootstrap 5

C#

Visual Studio 2022

📌 Funcionalidades

✔️ Cadastro de novos contatos
✔️ Edição de contatos existentes
✔️ Exclusão de contatos
✔️ Busca por nome
✔️ Visualização detalhada do contato
✔️ Interface responsiva (Bootstrap)
✔️ Banco criado via Migrations (EF Core)

📂 Estrutura do Projeto
agenda-contatos-mvc/
│
├── Controllers/         # Controladores MVC
├── Models/              # Modelos (Contato)
├── Views/               # Views Razor (Lista, Criar, Editar, etc.)
├── Data/                # AppDbContext (EF Core)
├── Migrations/          # Migrations do EF Core
├── wwwroot/             # Arquivos estáticos (CSS, JS, imagens)
├── appsettings.json     # String de conexão e configurações
├── Program.cs           # Configuração da aplicação
└── AgendaContatosMVC.csproj

🛠️ Pré-requisitos

Antes de rodar o projeto, certifique-se de ter instalado:

✔️ .NET 7 SDK

✔️ Visual Studio 2022 (com ASP.NET e desenvolvimento web)

✔️ SQL Server Express LocalDB

✔️ Git

🔧 Configuração e Instalação
1️⃣ Clonar o repositório
git clone https://github.com/Rester-fullstack/agenda-contatos-mvc.git
cd agenda-contatos-mvc

2️⃣ Ajustar a Connection String

Edite o arquivo appsettings.json se necessário:

"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=AgendaContatosDB;Trusted_Connection=True;MultipleActiveResultSets=true"
}

3️⃣ Restaurar os pacotes
dotnet restore

4️⃣ Criar o banco e rodar as migrations
dotnet ef database update

5️⃣ Rodar a aplicação
dotnet run


Ou simplesmente F5 no Visual Studio.

🤝 Como Contribuir

Faça um fork do repositório

Crie uma branch:

git checkout -b feature/minha-feature


Faça commit:

git commit -m "Minha nova feature"


Envie para o GitHub:

git push origin feature/minha-feature


Abra um Pull Request 🎉

👩‍💻 Autora

Ester da Costa Batista
Desenvolvedora C# e estudante de desenvolvimento fullstack.

📄 Licença

Este projeto está licenciado sob a MIT License.
Sinta-se livre para usar e modificar.
