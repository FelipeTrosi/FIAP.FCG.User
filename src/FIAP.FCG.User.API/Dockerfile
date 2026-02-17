# Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["FIAP.FCG.Contracts/FIAP.FCG.Contracts.csproj", "FIAP.FCG.Contracts/"]
COPY ["FIAP.FCG.User.API/FIAP.FCG.User.API.csproj", "FIAP.FCG.User.API/"]
COPY ["FIAP.FCG.User.Infrastructure/FIAP.FCG.User.Infrastructure.csproj", "FIAP.FCG.User.Infrastructure/"]
COPY ["FIAP.FCG.User.Domain/FIAP.FCG.User.Domain.csproj", "FIAP.FCG.User.Domain/"]
COPY ["FIAP.FCG.User.Service/FIAP.FCG.User.Service.csproj", "FIAP.FCG.User.Service/"]

RUN dotnet restore "FIAP.FCG.User.API/FIAP.FCG.User.API.csproj"

COPY . .

WORKDIR "/src/FIAP.FCG.User.API"
RUN dotnet publish -c Release -o /app/publish /p:UseAppHost=false

# Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS runtime

RUN addgroup -S appgroup && adduser -S appuser -G appgroup

WORKDIR /app
COPY --from=build /app/publish .

ENV ASPNETCORE_URLS=http://+:3001
ENV ASPNETCORE_ENVIRONMENT=Production

EXPOSE 3001

HEALTHCHECK --interval=30s --timeout=5s --retries=3 \
  CMD wget -qO- http://localhost:3001/health || exit 1

USER appuser

ENTRYPOINT ["dotnet", "FIAP.FCG.User.API.dll"]
