# MP CalcHub

**Nome em Ingl�s:** Multiple Platform Calculation Hub  
**Nome em Portugu�s:** Hub de C�lculos para M�ltiplas Plataformas

## Integrantes do Grupo

- Gabriel Loureiro
- Gabriel Domingos
- Matheus Bellini
- Anderson Mello

## Descri��o

Este � um projeto de p�s-gradua��o em Arquitetura de Software, desenvolvido pelo Grupo 13 da faculdade. O MP CalcHub visa proporcionar uma estrutura para o desenvolvimento de c�lculos de seguros, utilizando as melhores pr�ticas de arquitetura e design de software.

## Tecnologias Utilizadas

- **.NET 8**
- **C# 12**
- **DDD (Domain-Driven Design)**
- **TDD (Test-Driven Development)**
- **BDD (Behavior-Driven Development)**

## Conte�do do Projeto

O projeto abordar� os seguintes t�picos:

** Fase 1
1. **Novidades do .NET 8 e C# 12**
2. **Desenvolvimento de API com .NET**
3. **Middlewares e Inje��o de Depend�ncia**
4. **Trabalhando com Logs**
5. **Serializa��o de Dados em JSON e MessagePack**
6. **Autentica��o e Autoriza��o**
7. **Documenta��o de API**
8. **Trabalhando com Cache**

## Fase 2
1. GitHub Actions
2. Azure Pipelines
3. Dockerfile
4. Prometheus
5. Grafana

## Estrutura do Projeto

O projeto inicial conter� uma estrutura b�sica para trabalhar com c�lculos de seguros. Espera-se que, ao longo do desenvolvimento, a aplica��o evolua para abranger diversas funcionalidades relacionadas ao c�lculo e � gest�o de seguros, mantendo a escalabilidade e a manutenibilidade como princ�pios fundamentais.

## Contribui��o

Se voc� deseja contribuir para este projeto, sinta-se � vontade para abrir um problema (issue) ou enviar um pull request.

## Como rodar o projeto

** Instala��es
Dotnet 8 SDK e 
Dotnet 8 Tools

** Instalador docker
https://www.docker.com/products/docker-desktop/

** Instala��o do SQL no Docker --> PowerShell Administrator

docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=@fiap2024" -p 1433:1433 --name SqlServerFiap -d mcr.microsoft.com/mssql/server:2022-latest

** Instalar o SQL Management Studio
https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16

dotnet ef migrations add "Adicionar o nome da Migration Aqui" --project MPCalcHub.Infrastructure --startup-project MPCalcHub.Api

## Licen�a

Este projeto est� licenciado sob a [MIT License](LICENSE).

