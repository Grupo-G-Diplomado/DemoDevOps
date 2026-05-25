# DemoDevOps

Proyecto de ejemplo para la práctica de Integración Continua (CI) en el diplomado.

## Descripción

API REST en .NET con soporte de Swagger, Entity Framework Core y SQL Server (vía Docker), que demuestra el uso de Azure DevOps Pipelines para la integración continua.

## Estructura del proyecto

- `DemoDevOps.csproj` - Archivo de proyecto .NET
- `Program.cs` - Código fuente de la aplicación
- `azure-pipelines.yml` - Configuración del pipeline de Azure DevOps

## Pasos para levantarlo en otra computadora (Desarrollo Local)

Para clonar y ejecutar este proyecto de forma local de manera completamente automatizada, debes tener instalado **Docker** y **Docker Compose**. Sigue esta secuencia:

### 1. Configurar las variables de entorno (Secretos)
Por seguridad, las credenciales de la base de datos no se suben al repositorio. Antes de iniciar la aplicación, debes crear tu archivo local de configuración:

1. Localiza el archivo `.env.example` en la raíz del proyecto.
2. Haz una copia del mismo y nómbralo exactamente `.env` (quitándole el `.example`).
3. (Opcional) Abre ese nuevo archivo `.env` para cambiar la contraseña si así lo deseas.

### 2. Levantar toda la infraestructura
El proyecto está configurado para levantar la Base de Datos, conectarla y ejecutar las migraciones iniciales automáticamente. En la terminal escribe:

```bash
docker compose up -d --build
```

### 3. Probar la API (Swagger)
Tu API ya debe estar corriendo junto con SQL Server. Ábrela en tu navegador para ver la interfaz de Swagger:
```text
http://localhost:8080/swagger
```

### 4. Pruebas Unitarias
El proyecto cuenta con un entorno aislado (con xUnit y Moq). Para verificar que las pruebas pasan, puedes ejecutar localmente:
```bash
dotnet test DemoDevOps.Tests
```

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
