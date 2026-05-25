# DemoDevOps

Proyecto de ejemplo para la práctica de Integración Continua (CI) en el diplomado.

## Descripción

API REST en .NET con soporte de Swagger, Entity Framework Core y SQL Server (vía Docker), que demuestra el uso de Azure DevOps Pipelines para la integración continua.

## Estructura del proyecto

- `DemoDevOps.csproj` - Archivo de proyecto .NET
- `Program.cs` - Código fuente de la aplicación
- `azure-pipelines.yml` - Configuración del pipeline de Azure DevOps

## Pasos para levantarlo en otra computadora (Desarrollo Local)

Para clonar y ejecutar este proyecto de forma local, debes tener instalados **.NET SDK** y **Docker**. Sigue esta secuencia exacta:

### 1. Levantar la Base de Datos
El proyecto tiene un archivo `docker-compose.yaml` listo para desplegar SQL Server con las credenciales correctas.
```bash
docker-compose up -d
```

### 2. Configurar la Cadena de Conexión (User Secrets)
Por seguridad, la contraseña de la base de datos no está en el código. Debes configurar tu cadena de conexión de forma local en tu máquina ejecutando este comando en la terminal (en la raíz del proyecto):
```bash
dotnet user-secrets set "ConnectionStrings:ConexionSql" "Server=127.0.0.1,1433;Database=DemoDevOpsDb;User ID=sa;Password=MyStrongPass123;MultipleActiveResultSets=true;TrustServerCertificate=true"
```

### 3. Aplicar las Migraciones (Entity Framework)
Genera la base de datos y sus tablas mediante las herramientas de EF Core:
```bash
dotnet ef database update
```
*(Nota: Si no existe la carpeta `Migrations` en el repositorio, primero usa `dotnet ef migrations add Initial`).*

### 4. Ejecutar y testear la API
Levanta el servidor web:
```bash
dotnet run
```
Abre en tu navegador la ruta de Swagger (fíjate en el puerto que asigne tu consola). Ejemplo:
```text
http://localhost:5035/swagger
```

## Ejecución de la Imagen Docker (Solo App)

```bash
docker build -t demodevops:local .
docker run --rm demodevops:local
```

El `Dockerfile` usa una etapa de build con el SDK de .NET y una etapa de runtime con la imagen liviana necesaria para ejecutar la API.

## Pipeline CI/CD

El pipeline se ejecuta automáticamente en cada push a la rama `main`, ejecutando el comando `dotnet build` para compilar el proyecto y `docker build` para validar la construcción de la imagen.
## pruebas unitarias 1 correcto sin detalles .

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
