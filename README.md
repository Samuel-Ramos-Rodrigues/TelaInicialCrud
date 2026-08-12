<div align="center">

# 📋 GerenciadorDeProjetos

### Sistema de Cadastro e Gerenciamento de Projetos com Autenticação

Aplicação desenvolvida em **ASP.NET Core MVC** utilizando **C#**, **Entity Framework Core**, **SQL Server** e **ASP.NET Core Identity** para autenticação e gerenciamento de usuários.

![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge\&logo=dotnet\&logoColor=white)
![C#](https://img.shields.io/badge/C%23-Language-239120?style=for-the-badge\&logo=csharp\&logoColor=white)
![ASP.NET Core MVC](https://img.shields.io/badge/ASP.NET_Core-MVC-5C2D91?style=for-the-badge\&logo=dotnet)
![Identity](https://img.shields.io/badge/ASP.NET_Core-Identity-512BD4?style=for-the-badge\&logo=dotnet\&logoColor=white)
![Entity Framework Core](https://img.shields.io/badge/Entity_Framework_Core-512BD4?style=for-the-badge)
![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge\&logo=microsoftsqlserver\&logoColor=white)
![Bootstrap](https://img.shields.io/badge/Bootstrap-7952B3?style=for-the-badge\&logo=bootstrap\&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge\&logo=visualstudio\&logoColor=white)

</div>

---

# 📑 Índice

* [📖 Sobre o Projeto](#-sobre-o-projeto)
* [🚀 Funcionalidades](#-funcionalidades)
* [🔐 Autenticação com Identity](#-autenticação-com-identity)
* [🛠 Tecnologias Utilizadas](#-tecnologias-utilizadas)
* [📦 Pacotes Utilizados](#-pacotes-utilizados)
* [🗄 Banco de Dados](#-banco-de-dados)
* [▶️ Como Executar](#️-como-executar)
* [📁 Estrutura do Projeto](#-estrutura-do-projeto)
* [🎯 Objetivos de Aprendizagem](#-objetivos-de-aprendizagem)
* [👨‍💻 Créditos](#-créditos)

---

# 📖 Sobre o Projeto

O **GerenciadorDeProjetos** é um sistema desenvolvido para fins acadêmicos com o objetivo de aplicar os conceitos do padrão arquitetural **Model-View-Controller (MVC)** utilizando o ecossistema **ASP.NET Core**.

A aplicação permite realizar o gerenciamento de **projetos**, possibilitando operações de **CRUD (Create, Read, Update e Delete)** para cadastrar, visualizar, editar e excluir projetos armazenados no banco de dados.

O sistema também utiliza o **ASP.NET Core Identity**, permitindo o cadastro e a autenticação de usuários através de um sistema de **login**, protegendo funcionalidades que necessitam de autenticação.

A persistência dos dados é realizada utilizando o **Entity Framework Core** integrado ao **SQL Server**.

---

# 🚀 Funcionalidades

✅ Cadastro de usuários

✅ Login de usuários

✅ Logout de usuários

✅ Autenticação utilizando ASP.NET Core Identity

✅ Proteção de páginas para usuários autenticados

✅ Cadastro de projetos

✅ Listagem de projetos

✅ Visualização dos detalhes de um projeto

✅ Edição de projetos

✅ Exclusão de projetos

✅ Persistência de dados com Entity Framework Core

✅ Banco de dados SQL Server

✅ Interface utilizando Bootstrap

---

# 🔐 Autenticação com Identity

O projeto utiliza o **ASP.NET Core Identity** para implementar o sistema de autenticação.

Com o Identity, a aplicação possui recursos para gerenciamento e autenticação de usuários, permitindo controlar o acesso às funcionalidades do sistema.

Entre os recursos utilizados estão:

* Cadastro de usuários
* Login
* Logout
* Armazenamento seguro das credenciais
* Gerenciamento de usuários
* Controle de autenticação
* Proteção de páginas e funcionalidades

Dessa forma, determinadas áreas do sistema podem ser acessadas somente após o usuário realizar o **login**.

---

# 🛠 Tecnologias Utilizadas

| Tecnologia            | Descrição                                |
| --------------------- | ---------------------------------------- |
| C#                    | Linguagem principal da aplicação         |
| ASP.NET Core MVC      | Estrutura e arquitetura da aplicação     |
| ASP.NET Core Identity | Autenticação e gerenciamento de usuários |
| Entity Framework Core | ORM para acesso ao banco de dados        |
| SQL Server            | Banco de dados                           |
| Razor                 | Construção das páginas da aplicação      |
| HTML                  | Estrutura das páginas                    |
| CSS                   | Estilização da interface                 |
| Bootstrap             | Interface responsiva                     |
| Visual Studio         | Ambiente de desenvolvimento              |

---

# 📦 Pacotes Utilizados

O projeto utiliza o seguinte pacote:


* Microsoft.VisualStudio.Web.CodeGeneration.Design

---

# 🗄 Banco de Dados

A persistência dos dados foi implementada utilizando o **SQL Server**.

O **Entity Framework Core** é responsável pela comunicação entre a aplicação e o banco de dados.

Além dos dados relacionados aos projetos, o banco também possui as tabelas utilizadas pelo **ASP.NET Core Identity** para armazenar informações relacionadas aos usuários e à autenticação.

Entre elas podem estar tabelas como:

```text
AspNetUsers
AspNetRoles
AspNetUserRoles
AspNetUserClaims
AspNetUserLogins
AspNetUserTokens
AspNetRoleClaims
```

Para criar ou atualizar a base de dados através das migrations, execute no **Console do Gerenciador de Pacotes**:

```powershell
Update-Database
```

---

# ▶️ Como Executar

## 1. Clone o projeto

```bash
git clone https://github.com/Samuel-Ramos-Rodrigues/TelaInicialCrud.git
```

---

## 2. Abra a solução

Abra o arquivo da solução utilizando o **Visual Studio**.

---

## 3. Configure a conexão

No arquivo:

```text
appsettings.json
```

Configure a string de conexão com o seu **SQL Server**.

Exemplo:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=SEU_SERVIDOR;Database=GerenciadorProjetos;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

---

## 4. Execute as Migrations

Abra o **Console do Gerenciador de Pacotes** no Visual Studio e execute:

```powershell
Update-Database
```

Isso criará as tabelas necessárias para a aplicação, incluindo as utilizadas pelo **ASP.NET Core Identity**.

---

## 5. Execute o projeto

Pressione:

```text
F5
```

ou clique no botão **Iniciar** no Visual Studio.

Após iniciar a aplicação, será possível criar uma conta, realizar login e utilizar as funcionalidades disponíveis no sistema.

---

# 📁 Estrutura do Projeto

```text
GerenciadorDeProjetos
│
├── Areas
│   └── Identity
│
├── Controllers
│   └── ProjetosController.cs
│
├── Data
│   └── ApplicationDbContext.cs
│
├── Migrations
│
├── Models
│   └── Projeto.cs
│
├── Views
│   ├── Home
│   ├── Projetos
│   └── Shared
│
├── wwwroot
│   ├── css
│   ├── js
│   └── lib
│
├── imagens
│
├── appsettings.json
├── Program.cs
└── README.md
```

---

# 🎯 Objetivos de Aprendizagem

Este projeto foi desenvolvido com o propósito de praticar e compreender:

* ASP.NET Core
* ASP.NET Core MVC
* Arquitetura MVC
* C#
* ASP.NET Core Identity
* Autenticação de usuários
* Autorização de acesso
* Cadastro e login de usuários
* Entity Framework Core
* SQL Server
* Migrations
* CRUD
* Models
* Views
* Controllers
* Razor
* Bootstrap
* Organização de aplicações web
* Integração entre aplicação e banco de dados

---

# 👨‍💻 Créditos

### Desenvolvedor

**Arthur Francisco Santos Gomes Barreto**

---

### Professor

**Wallace Oliveira dos Santos**

---

<div align="center">

### ⭐ Projeto desenvolvido para fins acadêmicos e prática de desenvolvimento web com ASP.NET Core MVC.

</div>
