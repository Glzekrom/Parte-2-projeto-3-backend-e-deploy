# Etapa base para execução
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Etapa de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia o .csproj e restaura dependências
COPY ["WebServiceLivros.csproj", "./"]
RUN dotnet restore

# Copia todo o conteúdo do projeto e publica
COPY . .
RUN dotnet publish "WebServiceLivros.csproj" -c Release -o /app/publish

# Etapa final: imagem leve com a aplicação
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .

# Inicia o servidor
ENTRYPOINT ["dotnet", "WebServiceLivros.dll"]


