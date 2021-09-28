FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 5000

ENV ASPNETCORE_URLS=http://+:5000

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["batch08162021dockerdemo/batch08162021dockerdemo.csproj", "batch08162021dockerdemo/"]
RUN dotnet restore "batch08162021dockerdemo\batch08162021dockerdemo.csproj"
COPY . .
WORKDIR "/src/batch08162021dockerdemo"
RUN dotnet build "batch08162021dockerdemo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "batch08162021dockerdemo.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "batch08162021dockerdemo.dll"]
