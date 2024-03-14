# Projeto com intuito de aprendizado

Objetivo:
- Aplicar o aprendizado em aula do Marcoratti [Clean Architecture Essencil - ASP .NET Core com C#](https://www.udemy.com/course/clean-architecture-essencial-asp-net-core-com-c/?couponCode=ST15MT31224)
- Iniciado o projeto em .Net 5 pelo visual studio 2019.
- Aplicar os conceitos de arquitetura limpa.
- Organização de um projeto.
  - Usando uma separação em camadas com Domain, Application, Info.Data, Info.IoC e a WebUI.
      - Domain: Modelo de dominio, regras de negocio, interfaces.
      - Application:  Regras de dominio da aplicação, mapeamentos, serviços, DTOs, CQRS.
      - Infra.Data: EF Core, Contexto, Configurações, Migrations, Repository.
      - Infra.IoC: Injeção de Dependencias, registro dos serviços, tempo de vida.
      - WebUI: MVC, Controllers, Views, Filtros, ViewModels.
