# Etapa base: runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 3001
ENV ASPNETCORE_HTTP_PORTS=3001

# Etapa de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copiar os .csproj primeiro
COPY FIAP.FCG.User.API/FIAP.FCG.User.API.csproj FIAP.FCG.User.API/
COPY FIAP.FCG.User.Domain/FIAP.FCG.User.Domain.csproj FIAP.FCG.User.Domain/
COPY FIAP.FCG.User.Infrastructure/FIAP.FCG.User.Infrastructure.csproj FIAP.FCG.User.Infrastructure/
COPY FIAP.FCG.User.Service/FIAP.FCG.User.Service.csproj FIAP.FCG.User.Service/

# Restaurar dependências
RUN dotnet restore FIAP.FCG.User.API/FIAP.FCG.User.API.csproj
RUN dotnet restore FIAP.FCG.User.Infrastructure/FIAP.FCG.User.Infrastructure.csproj 
RUN dotnet restore FIAP.FCG.User.Service/FIAP.FCG.User.Service.csproj 

# Copiar o restante dos arquivos
COPY FIAP.FCG.User.API/ FIAP.FCG.User.API/
COPY FIAP.FCG.User.Domain/ FIAP.FCG.User.Domain/
COPY FIAP.FCG.User.Infrastructure/ FIAP.FCG.User.Infrastructure/
COPY FIAP.FCG.User.Service/ FIAP.FCG.User.Service/

# Build
WORKDIR /src/FIAP.FCG.User.API
RUN dotnet build FIAP.FCG.User.API.csproj -c Release -o /app/build

# Publish
FROM build AS publish
WORKDIR /src/FIAP.FCG.User.API
RUN dotnet publish FIAP.FCG.User.API.csproj -c Release -o /app/publish
FROM base AS final
WORKDIR /app

# Instalar Datadog .NET Tracer 
RUN apt-get update \
    && apt-get install -y --no-install-recommends curl ca-certificates \
    && curl -LO https://github.com/DataDog/dd-trace-dotnet/releases/download/v3.6.0/datadog-dotnet-apm_3.6.0_amd64.deb \
    && dpkg -i ./datadog-dotnet-apm_3.6.0_amd64.deb \
    && rm ./datadog-dotnet-apm_3.6.0_amd64.deb \
    && rm -rf /var/lib/apt/lists/*

COPY --from=publish /app/publish .

ENV CORECLR_ENABLE_PROFILING=1 \
    CORECLR_PROFILER="{846F5F1C-F9AE-4B07-969E-05C26BC060D8}" \
    CORECLR_PROFILER_PATH=/opt/datadog/Datadog.Trace.ClrProfiler.Native.so \
    DD_DOTNET_TRACER_HOME=/opt/datadog \
    DD_LOGS_INJECTION=true

ENTRYPOINT ["dotnet", "FIAP.FCG.User.API.dll"]
