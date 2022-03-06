FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Parking.API/Parking.API.csproj", "Parking.API/"]
RUN dotnet restore "Parking.API/Parking.API.csproj"
COPY . .
WORKDIR "/src/Parking.API"
RUN dotnet build "Parking.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Parking.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Parking.API.dll"]
