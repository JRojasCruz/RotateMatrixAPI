# Usar la imagen base de .NET Core 8 Runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["RotateMatrixAPI.csproj", "./"]
RUN dotnet restore "./RotateMatrixAPI.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "RotateMatrixAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RotateMatrixAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RotateMatrixAPI.dll"]