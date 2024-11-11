FROM mcr.microsoft.com/dotnet/sdk:8.0  AS build
WORKDIR /app
COPY . .
RUN dotnet restore "PilatesStudio.csproj"
RUN dotnet publish "PilatesStudio.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .



CMD [ "dotnet", "PilatesStudio.dll"]