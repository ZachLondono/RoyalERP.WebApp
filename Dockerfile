FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
ENV ASPNETCORE_ENVIRONMENT Release
EXPOSE 7000

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["RoyalERP.WebApp/RoyalERP.WebApp.csproj", "RoyalERP.WebApp/"]
RUN dotnet restore "RoyalERP.WebApp/RoyalERP.WebApp.csproj"

COPY . .

RUN dotnet build "RoyalERP.WebApp/RoyalERP.WebApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RoyalERP.WebApp/RoyalERP.WebApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RoyalERP.WebApp.dll"]