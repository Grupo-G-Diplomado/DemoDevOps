ARG DOTNET_VERSION=10.0
ARG PROJECT_FILE=DemoDevOps.csproj

FROM mcr.microsoft.com/dotnet/sdk:${DOTNET_VERSION} AS build
WORKDIR /src

ARG PROJECT_FILE

COPY ["DemoDevOps.csproj", "./"]
RUN dotnet restore "${PROJECT_FILE}"

COPY . ./
RUN dotnet publish "${PROJECT_FILE}" \
    --configuration Release \
    --output /app/publish \
    --no-restore \
    --no-self-contained \
    /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:${DOTNET_VERSION} AS runtime
WORKDIR /app

ENV ASPNETCORE_HTTP_PORTS=8080
EXPOSE 8080

COPY --from=build /app/publish ./
USER $APP_UID

ENTRYPOINT ["dotnet", "DemoDevOps.dll"]
