# DemoDevOps

Proyecto de ejemplo para la práctica de Integración Continua (CI) en el diplomado.

## Descripción

Aplicación de consola en .NET que demuestra el uso de Azure DevOps Pipelines para la integración continua.

## Estructura del proyecto

- `DemoDevOps.csproj` - Archivo de proyecto .NET
- `Program.cs` - Código fuente de la aplicación
- `azure-pipelines.yml` - Configuración del pipeline de Azure DevOps

## Ejecución local

```bash
dotnet build
dotnet run
```

## Ejecución con Docker

```bash
docker build -t demodevops:local .
docker run --rm demodevops:local
```

El `Dockerfile` usa una etapa de build con el SDK de .NET y una etapa de runtime con la imagen liviana necesaria para ejecutar la aplicación publicada.

## Pipeline CI/CD

El pipeline se ejecuta automáticamente en cada push a la rama `main`, ejecutando el comando `dotnet build` para compilar el proyecto y `docker build` para validar la construcción de la imagen.

## Grupo de trabajo

- Grupo G - Diplomado DevOps
