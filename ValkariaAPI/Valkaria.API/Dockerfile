#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Valkaria.API/Valkaria.API.csproj", "Valkaria.API/"]
RUN dotnet restore "Valkaria.API/Valkaria.API.csproj"
COPY . .
WORKDIR "/src/Valkaria.API"
RUN dotnet build "Valkaria.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Valkaria.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Valkaria.API.dll"]