# Aplicación Web con Blazor y .NET Core 3.1

Este proyecto es una aplicación web interactiva desarrollada con Blazor y .NET Core 3.1, que implementa un sistema completo con base de datos y está publicado en Azure.

## Descripción del Proyecto

Esta aplicación web ha sido desarrollada como parte del curso "Desarrollo Web con Blazor y .Net Core 3", utilizando tecnologías Microsoft modernas para crear una experiencia de usuario interactiva y responsive.

### Características Principales

- **Frontend con Blazor WebAssembly**: Interfaz de usuario interactiva en el navegador
- **Backend con ASP.NET Core 3.1**: API RESTful para manejo de datos
- **Entity Framework Core**: ORM para acceso y manipulación de base de datos
- **Diseño Responsive**: Implementado con Bootstrap 4
- **Autenticación y Autorización**: Gestión de usuarios y roles
- **Publicación en Azure**: Despliegue completo en la nube de Microsoft

## Demo

La aplicación está disponible en línea en: [Proyecto con host en Azure]([https://miproyectoblazor.azurewebsites.net](https://inventaryblazor042025.azurewebsites.net/))

## Tecnologías Utilizadas

- **Blazor Web**
- **ASP.NET Core 8.0**
- **Entity Framework Core**
- **SQL Server**
- **Bootstrap 4**
- **Azure App Service**
- **Azure SQL Database**

## Requisitos del Sistema

Para desarrollo local:
- Visual Studio 2019 o superior
- .NET Core SDK 3.1 o superior
- SQL Server (local o en la nube)

## Instalación y Configuración

1. Clona este repositorio:
```
git clone [https://github.com/danny1227/InventaryWithBlazor.git](https://github.com/danny1227/InventaryWithBlazor.git)
```

2. Navega al directorio del proyecto:
```
cd turepositorio
```

3. Restaura los paquetes NuGet:
```
dotnet restore
```

4. Actualiza la cadena de conexión en `appsettings.json`:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=MiBaseDeDatos;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```

5. Ejecuta las migraciones para crear la base de datos:
```
dotnet ef database update
```

6. Inicia la aplicación:
```
dotnet run
```

## Estructura del Proyecto

```
├── MiProyectoBlazor.Business       # Capa de conección entre el acceso a datos y el proyecto con Blazor (DataBase/Bussiness)
├── MiProyectoBlazor.DataAccess     # Capa de conección con la base de datos por medio de EF (Migraciones/Entidades)
├── MiProyectoBlazor.Entities       # Capa de entidades creadas con Entity Framework (Entidades)
└── MiProyectoBlazor.Enventary      # Proyecto de los templates de blazor y capa de vista (Frontend)
```

## Características Implementadas

- 📝 CRUD completo para todas las entidades del sistema
- 📱 Diseño responsive para móviles y tablets

## Despliegue en Azure

Para desplegar esta aplicación en Azure:

1. Crea un App Service en Azure
2. Configura una base de datos SQL en Azure
3. Actualiza las cadenas de conexión para el entorno de producción
4. Publica directamente desde Visual Studio o configura CI/CD con GitHub Actions

## Contribuciones

Las contribuciones son bienvenidas. Para contribuir:

1. Haz fork del repositorio
2. Crea una rama para tu feature (`git checkout -b feature/AmazingFeature`)
3. Haz commit de tus cambios (`git commit -m 'Add some AmazingFeature'`)
4. Haz push a la rama (`git push origin feature/AmazingFeature`)
5. Abre un Pull Request

## Licencia

No es requerido ningún tipo de licencia.

## Contacto

Daniel Ramirez - [danielcoroy1200@gmail.com](mailto:danielcoroy1200@gmail.com)

Enlace del proyecto: [https://github.com/danny1227/InventaryWithBlazor](https://github.com/danny1227/InventaryWithBlazor)

---

Desarrollado con ❤️ como parte del curso "Desarrollo Web con Blazor y .Net Core 3"
