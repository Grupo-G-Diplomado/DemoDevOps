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

## Pipeline CI/CD

El pipeline se ejecuta automáticamente en cada push a la rama `main`, ejecutando el comando `dotnet build` para compilar el proyecto.

## Grupo de trabajo

- Grupo G - Diplomado DevOps
