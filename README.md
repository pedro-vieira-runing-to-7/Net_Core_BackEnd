# SAGE CRUD API
  
## API .NET Core
 
  Cadastro, edição, exclusão e atualização de um cadastro de pessoa com endereço.

# Como rodar a aplicação:
- Possuir a ultima versão do  SDK (https://dot.net/core)

 ## Docker
  Apartir do diretório clonado da aplicação:
  - docker build -t sageback .
  - docker run -d -p 8080:80 --name sageback

 ## .NET CLI
  Apartir do diretório clonado da aplicação:
  dotnet run --project sage.api\sage.Service.csProj

  Acessar o Swagger para visualizar o endpoint e testar as chamadas
  https://localhost:5001/swagger/index.html
  
  ## informações importantes :
  
   - A aplicação esta utilizando EF Core in memory ( Apenas para testes), portanto os dados só serão mantidos durante o ciclo de vida da aplicação.
   
   - TODO: A Api esta retornando classes do dominio ao invés de serem mapeadas para ViewModels (Automapper) 

## Ferramentas de CI
- Travis
- Circle CI

## Tecnologias Utilizadas:

- ASP.NET Core 2.2 (with .NET Core)
- ASP.NET MVC Core 
- ASP.NET WebApi Core
- Entity Framework Core 2.2
- Entity Framework Core 2.2 (InMemory)
- .NET Core Native DI
- Automapper
- FluentValidator
- MediatR
- Swagger UI

## Architecture / Patterns:

- Arquitetura com segregação de responsábilidade, utilizando Principios do SOLID
- Dependency Injection
- Inversion of control
- Domain Driven Design (Camadas and Domain Model Pattern)
- Domain Events
- Domain Notification
- CQRS ( utilizando um unico banco de dados)
- Unit of Work
- Repository
