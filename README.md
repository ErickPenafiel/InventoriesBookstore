# Sistema de Control de Inventarios para una Librería

## Capturas de Pantalla

### Login
![Login](https://drive.google.com/uc?export=view&id=1DOMqoeHnVvmPkUlDvfVxovof2MVKfvry)
*Login del Inventario*

### Pantalla Principal
![Pantalla Principal](https://drive.google.com/uc?export=view&id=1ext6w5rQv2w8CmUQDHTBsGoM3M7mpRWr)
*Pantalla Principal del Sistema de Control de Inventarios*

## Descripción

Este proyecto es una aplicación de escritorio desarrollada en C# utilizando Windows Forms para gestionar el inventario de una librería. Proporciona funcionalidades para agregar, actualizar, eliminar y ver libros en el inventario, asegurando una gestión eficiente y organizada. La aplicación utiliza una base de datos SQL Server para almacenar toda la información relevante.

## Funcionalidades

- **Gestión de Productos**: Añadir, actualizar y eliminar productos en el inventario.
- **Entradas y Salidas**: Registrar entradas y salidas de productos del inventario.
- **Control de Inventarios**: Ver y gestionar el estado actual del inventario.
- **Gestión de Pedidos**: Administrar los pedidos de productos.
- **Editoriales**: Gestionar la información de las editoriales.
- **Usuarios**: Administrar los usuarios del sistema.
- **Generación de Reportes en PDF**: Crear y exportar reportes de inventario y otras actividades en formato PDF.
- **Respaldos de la Base de Datos**: Crear y restaurar respaldos de la base de datos.

## Instalación

Para ejecutar este proyecto en tu máquina local, sigue estos pasos:

1. **Clonar el Repositorio**:
    ```bash
    git clone https://github.com/ErickPenafiel/InventoriesBookstore.git
    cd bookstore-inventory
    ```

2. **Abrir el Proyecto en Visual Studio**:
    - Abre Visual Studio.
    - Selecciona `Archivo > Abrir > Proyecto/Solución`.
    - Navega al directorio clonado y abre el archivo `.sln`.

3. **Configurar la Base de Datos**:
    - Configura una instancia de SQL Server.
    - Restaura la base de datos utilizando el archivo SQL proporcionado en el repositorio (`database\InventarioLibreriaDb.sql`).
    - Actualiza la cadena de conexión en el archivo `App.config` con los detalles de tu instancia de SQL Server.

4. **Compilar el Proyecto**:
    - Selecciona `Compilar > Compilar Solución` o presiona `Ctrl+Shift+B`.

5. **Ejecutar la Aplicación**:
    - Presiona `F5` o haz clic en el botón `Iniciar` para ejecutar la aplicación.

## Uso

Una vez que la aplicación esté en funcionamiento, puedes utilizar las siguientes funcionalidades:

- **Gestión de Productos**: Haz clic en el botón `Productos` para agregar, actualizar o eliminar libros del inventario.
- **Entradas y Salidas**: Registra nuevas entradas o salidas de productos desde el módulo correspondiente.
- **Control de Inventarios**: Navega por la lista para ver el estado actual del inventario.
- **Gestión de Pedidos**: Administra los pedidos de productos desde el módulo de pedidos.
- **Editoriales**: Añade y gestiona la información de las editoriales.
- **Usuarios**: Administra los usuarios del sistema.
- **Generación de Reportes**: Haz clic en el botón `Reportes` para generar y exportar informes en formato PDF.
- **Respaldos de la Base de Datos**: Utiliza el módulo de respaldos para crear y restaurar respaldos de la base de datos.

## Requisitos

- Sistema operativo Windows
- .NET Framework (versión 4.7.2 o superior)
- SQL Server
- Visual Studio 2019 o posterior