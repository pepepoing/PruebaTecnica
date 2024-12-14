# Prueba Tecnica

Proyecto en angular y .net core

en la api 
el controlador CLientData utiliza LinQ
el controlador SPCLients utiliza un procedimiento de almacenado

hay que levantar el contenedor con SQL server `docker-compose up` dentro de la carpeta del servicio.
correr la migracion `dotnet ef database update` 
luego ejecuta el `database_SP_Data.sql`.

