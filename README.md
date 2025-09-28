# Sistema de Gestión de Clientes y Órdenes

## Descripción
Este sistema está desarrollado en **Visual Basic .NET (WinForms)** y permite la gestión de clientes y órdenes, además de contar con un módulo de **inicio de sesión y registro de usuarios**.  

El proyecto se conecta a una **base de datos de Access** y utiliza **iTextSharp** para generar documentos PDF.

## Funcionalidades principales
- **Inicio de sesión y registro de usuarios**  
  - Vinculado a la tabla `inicio` en la base de datos.  
  - Permite controlar accesos y registrar nuevos usuarios.  
  - Incluye validaciones en cuanto a contraseñas.

- **Gestión de Clientes**  
  - Alta, baja y modificación de datos de clientes.  
  - Acceso rápido a la base de datos.  
  - Filtrado y busqueda de clientes segun un campo especifico
  - Acción para imprimir la base de datos

- **Gestión de Órdenes**  
  - Registro de órdenes vinculadas a los clientes.  
  - Relación con los clientes mediante el campo `n_orden`.  
  - Alta, baja y modificación de ordenes

- **Generación de Reportes PDF**  
  - Exportación de datos con logotipo, títulos personalizados y enlaces funcionales.  
  - Implementado con la librería `iTextSharp`.  
  - Autorrellenado de campos al seleccionar la orden correspondiente



## Requisitos
- Visual Studio 2019 o superior  
- .NET Framework 4.x  
- Microsoft Access
- Librería **iTextSharp** (incluida en el proyecto)

## Instalación y ejecución
1. Clonar o descargar el repositorio.  
2. Abrir `sistema_completo.sln` en Visual Studio.  
3. Restaurar las referencias si es necesario.  
4. Compilar el proyecto (`Ctrl + Shift + B`).  
5. Ejecutar con `F5`.  

## Uso del sistema
1. **Inicio de sesión y registro de usuario**
Ingresar usuario y contraseña registrados en la tabla `inicio`. Si no esta registrado, crear usuario y, una vez que se haya guardado con éxito su usario, iniciar sesión.


2. **Gestión de clientes**
Una vez iniciado sesión, tendrás acceso a la tabla de clientes y ordenes. 
En la tabla de clientes podrás imprimir la tabla pulsando el boton de "Imprimir base de datos", a su vez, se mostrará una vista previa de la impresión. Podrás dar alta, baja y modificación de clientes al seleccionar la celda correspondiente y pulsando el botón de la acción que quiera realizar. Abajo de la tabla, encontrará botones para filtrar los clientes según campos especificos. Si desea buscar un nombre de cliente en especifico, por ejemplo, debera limpiar campos y llenar la caja de texto correspondiente. Ejemplo: Si desea buscar un cliente llamado Juan, debera limpiar los campos de las cajas de texto con el botón de "Limpiar", deberá llenar la caja de texto de "Nombre" con el nombre "Juan", luego accionará el botón de "Buscar". De esta forma, filtrará la busqueda y mostrará a todos los clientes, cuyo campo "nombr_cl" sea Juan. Si desea encontrar un cliente aun más especifico que solo el nombre, puede hacerlo llenando los otros campos y dandole a "Buscar". Nota: El ID del cliente no puede ser agregado ni modificado. Al añadir a la base de datos un cliente, aunque escriba algo en la casilla de ID, su ID será autoincremental y seguirá la linea de números dependiendo de los ID de clientes agregados antes de este.

3. **Gestión de órdenes**
En la sección de ordenes, se podrá acceder a la base de datos de las ordenes, las cuales se vinculan a su cliente correspondiente a través del atributo "n_orden".
De la misma manera que la tabla de clientes, se podrá filtrar la busqueda segun la especificación que se de en la o las cajas de texto. Al oprimir el botón de "Imprimir base de datos", se imprime la base de datos y se muestra una vista previa de como se vería la impresión. 

4. **Creación de factura en PDF y envío por correo**
Para crear una factura, es decir, generar un PDF, se deberá seleccionar la celda de la fila que contenga los datos en los cuales se basará la factura. Al seleccionar la celda, las cajas de texto se autorrellenarán, incluyendo los datos del cliente al que está vinculada la orden. Al crear la factura, automaticamente se rellenará la casilla "Adjuntar" en el area de "Enviar". Por lo que, apenas se tenga la factura, se podrá enviar a su correspondiente receptor. Si desea cambiar el asunto del correo y la descripción, deberá hacerlo desde el código. Para enviarlo desde un correo, deberá ingresar el código de acceso rapido de correo dentro del código, también el correo electrónico emisor.


5. **Sobre el PDF**
El PDF se personaliza desde el código. Por lo que si se quiere cambiar el logo, información o lo que se desee hacer, deberá descargar este sistema y modificarlo en el form correspondiente.

6. **Acerca de y Manual de usuario**
Estas páginas se encuentran vacías para que pueda ser rellenado según necesidades del usuario. Se pueden modificar desde el código.

**Desarrollado por Katia Sotomayor 📧katiasotomayor042@gmail.com**
