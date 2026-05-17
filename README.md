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

## Grupo de trabajo - G

- JOSE ELIAS FLORES CALLEJAS
- ELY NICOLE RICALDI ARTEAGA
- ALEXANDER JUNIOR IGNACIO SIACARA
- KEVIN ANDRES ALPIRE ARTEAGA
- PAUL JHERSON RODRIGUEZ GUZMAN

## Estado del Práctico

1. **Dockerfile:** Creado con arquitectura multi-etapa para .NET 10.0.
2. **Construcción de imagen:** Validada localmente mediante `docker build`.
3. **Ejecución del contenedor:** Validada localmente mediante `docker run` (Salida: "Hello, World!").
4. **Integración al pipeline:** Paso de Docker agregado exitosamente al archivo `azure-pipelines.yml`.
5. **Validación:** Pipeline ejecutado exitosamente en Azure DevOps.
