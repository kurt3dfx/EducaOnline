# [Título do Projeto] - Aplicação de Plataforma de Educação Online

## 1. Apresentação

Bem-vindo ao repositório do projeto Plataforma de Educação Online. Este projeto é uma entrega do MBA DevXpert Full Stack .NET e é referente ao módulo 3 do curso.
Consiste em uma plataforma de Educação Online  com múltiplos bounded contexts (BC), aplicando DDD, TDD, CQRS e padrões arquiteturais para gestão eficiente de
conteúdos educacionais, alunos e processos financeiros. 

### Autor(es)
- Tiago Bittencourt

## 2. Proposta do Projeto

O projeto consiste em

- Aplicação MVC Interface web.
- API RESTful Exposição dos recursos da plataforma para integração com outras aplicações ou desenvolvimento de front-ends alternativos.
- Autenticação e Autorização Implementação de controle de acesso, diferenciando administradores e usuários comuns.
- Acesso a Dados Implementação de acesso ao banco de dados através de ORM / repository e service.

## 3. Tecnologias Utilizadas

- Linguagem de Programação C#
- Frameworks
  - ASP.NET Core MVC
  - ASP.NET Core Web API
  - Entity Framework Core
- Banco de Dados SQL Server
- Autenticação e Autorização
  - ASP.NET Core Identity
  - JWT (JSON Web Token) para autenticação na API
- Front-end
  - Razor PagesViews
  - HTMLCSS para estilização básica
- Documentação da API Swagger

## 4. Estrutura do Projeto

A estrutura do projeto é organizada da seguinte forma (até o presente momento)


- src
  - src : pasta com os projetos 
  - tests: pasta com os testes
- README.md - Arquivo de Documentação do Projeto
- FEEDBACK.md - Arquivo para Consolidação dos Feedbacks
- .gitignore - Arquivo de Ignoração do Git

## 5. Funcionalidades Implementadas

- Controle de cursos


## 6. Como Executar o Projeto

### Pré-requisitos

- .NET SDK 8.0 ou superior
- SQL Server
- Visual Studio 2022 ou superior (ou qualquer IDE de sua preferência)
- Git

### Passos para Execução

1. Clone o Repositório
   - `git clone httpsgithub.comseu-usuarionome-do-repositorio.git`
   - `cd nome-do-repositorio`

2. Configuração do Banco de Dados
   - No arquivo `appsettings.json`, configure a string de conexão do SQL Server.
   - Rode o projeto para que a configuração do Seed crie o banco e popule com os dados básicos


## 7. Instruções de Configuração


## 8. Documentação da API



## 9. Avaliação

- Este projeto é parte de um curso acadêmico e não aceita contribuições externas. 
- Para feedbacks ou dúvidas utilize o recurso de Issues
- O arquivo `FEEDBACK.md` é um resumo das avaliações do instrutor e deverá ser modificado apenas por ele.