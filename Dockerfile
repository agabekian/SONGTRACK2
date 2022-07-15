# docker run -d --network=host songtrack

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 5000

ENV ASPNETCORE_URLS=http://+:5000

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["cSharp2022.csproj", "./"]
RUN dotnet restore "cSharp2022.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "cSharp2022.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "cSharp2022.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "cSharp2022.dll"]
