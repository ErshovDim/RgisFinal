FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

COPY ["Rgis1/Rgis1.csproj", "Rgis1/"]
RUN dotnet restore "Rgis1/Rgis1.csproj"

COPY . .


WORKDIR "/src/Rgis1"
RUN dotnet build -c $BUILD_CONFIGURATION -o /app/build


FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false


FROM base AS final
WORKDIR /app


COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "Rgis1.dll"]
