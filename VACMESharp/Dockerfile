FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["VACMESharp/VACMESharp.csproj", "VACMESharp/"]
RUN dotnet restore "VACMESharp/VACMESharp.csproj"
COPY . .
WORKDIR "/src/VACMESharp"
RUN dotnet build "VACMESharp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "VACMESharp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "VACMESharp.dll"]
