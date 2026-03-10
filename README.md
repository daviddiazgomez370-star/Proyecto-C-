# SmartUrban

Instrucciones paso a paso para abrir y usar este proyecto

Prerequisitos
- Visual Studio (2019/2022/2026) con soporte para .NET Framework
- .NET Framework Developer Pack 4.7.2 instalado
- Git
- (Opcional) SQL Server / SQL Express si la aplicación usa base de datos

Clonar el repositorio
1. Clona el repositorio:
   ```powershell
   git clone https://github.com/daviddiazgomez370-star/Proyecto-C-.git
   cd SmartUrban
   ```

Abrir en Visual Studio
1. Abre `SmartUrban.sln` desde Visual Studio (Archivo → Abrir → Proyecto/Solución).
2. Si Visual Studio pregunta por restaurar paquetes NuGet, acepta (Restaurar paquetes).

Configurar la base de datos
1. Revisa y actualiza la cadena de conexión en `SmartUrban.DAL/Conexion/ConexionDB.cs` si es necesario.
   - Busca la variable `connectionString` (o el lugar donde se define) y ajusta la URL/credenciales según tu entorno.
2. Si hay scripts de creación de la base de datos, ejecútalos en tu servidor SQL.

Compilar y ejecutar
1. Selecciona el proyecto de inicio correcto en el Explorador de soluciones.
2. Build → Build Solution (o Ctrl+Shift+B).
3. Ejecuta la aplicación con Debug → Start Debugging (F5) o Start Without Debugging (Ctrl+F5).

Buenas prácticas para colaborar
- Crea una rama nueva para tu trabajo:
  ```powershell
  git checkout -b feat/mi-cambio
  ```
- Añade y commitea tus cambios:
  ```powershell
  git add .
  git commit -m "Descripción breve de mi cambio"
  ```
- Empuja tu rama al remoto y crea un Pull Request desde GitHub:
  ```powershell
  git push -u origin feat/mi-cambio
  ```

Problemas comunes
- NuGet no restaura: en Visual Studio, Menu → Tools → NuGet Package Manager → Package Manager Console y ejecuta `Update-Package -reinstall`.
- Errores de cadena de conexión: verifica que el servidor SQL esté accesible y que las credenciales sean correctas.

Contacto
Si tienes problemas, abre un issue en el repositorio o contacta con el responsable del proyecto.
