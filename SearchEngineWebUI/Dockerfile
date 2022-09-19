FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /ui_src
COPY SearhEngineWebUI.csproj .
RUN dotnet restore
COPY . .
RUN dotnet publish -c release -o /app
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
EXPOSE 80
EXPOSE 445
COPY --from=build /app .
ENTRYPOINT ["dotnet", "SearchEngineWebUI.dll"]