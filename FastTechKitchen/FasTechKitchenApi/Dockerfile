# Etapa base para runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8081


# Etapa de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copiando os .csproj (sem repetir "FastTechKitchen")
COPY FastTechKitchen/FasTechKitchenApi/FasTechKitchen.Api.csproj FasTechKitchenApi/
COPY FastTechKitchen/FastTechKitchenApplication/FastTechKitchen.Application.csproj FastTechKitchenApplication/
COPY FastTechKitchen/FastTechKitchen.Domain/FastTechKitchen.Domain.csproj FastTechKitchen.Domain/
COPY FastTechKitchen/FastTechKitchen.Infraestructure/FastTechKitchen.Infraestructure.csproj FastTechKitchen.Infraestructure/


# Restaurando pacotes
RUN dotnet restore FasTechKitchenApi/FasTechKitchen.Api.csproj

# Copiando todo o conteúdo do contexto
COPY . .

# Compilando a aplicação
WORKDIR /src/FasTechKitchenApi
RUN dotnet build "FasTechKitchen.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publicando
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "FasTechKitchen.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Imagem final
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FasTechKitchen.Api.dll"]


