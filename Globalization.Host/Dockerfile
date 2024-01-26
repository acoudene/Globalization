#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Globalization.Host/Globalization.Host.csproj", "Globalization.Host/"]
COPY ["Globalization.Api/Globalization.Api.csproj", "Globalization.Api/"]
COPY ["Core.Api/Core.Api.csproj", "Core.Api/"]
COPY ["Core.Data/Core.Data.csproj", "Core.Data/"]
COPY ["Core.Dtos/Core.Dtos.csproj", "Core.Dtos/"]
COPY ["Globalization.Data/Globalization.Data.csproj", "Globalization.Data/"]
COPY ["Globalization.Dtos/Globalization.Dtos.csproj", "Globalization.Dtos/"]
COPY ["Globalization.Data.MongoDb/Globalization.Data.MongoDb.csproj", "Globalization.Data.MongoDb/"]
COPY ["Core.Data.MongoDb/Core.Data.MongoDb.csproj", "Core.Data.MongoDb/"]
RUN dotnet restore "./Globalization.Host/./Globalization.Host.csproj"
COPY . .
WORKDIR "/src/Globalization.Host"
RUN dotnet build "./Globalization.Host.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Globalization.Host.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Globalization.Host.dll"]