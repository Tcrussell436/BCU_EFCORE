FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["BCU_EFCORE/BCU_EFCORE.csproj", "BCU_EFCORE/"]
RUN dotnet restore "BCU_EFCORE/BCU_EFCORE.csproj"
COPY . .
WORKDIR "/src/BCU_EFCORE"
RUN dotnet build "BCU_EFCORE.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BCU_EFCORE.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BCU_EFCORE.dll"]
