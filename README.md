Versión 1.0.0.9 (11 de noviembre de 2024)
- Ahora el botón de inicio de sesión siempre está habilitado para las cuentas de cajero sin contraseña
- Los dialogos para abrir los archivos para modificar el directorio y modificar la conexión con la base de datos muestran lo que está seleccionado actualmente
- Se corrigió un error en el que no se podía guardar correctamente los colores de los cajeros al modficarlos
- Se corrigió un error a la hora de modificar los proveedores ya que al eliminar los datos del correo o el telefono estos no eran correctamente eliminados de la base de datos
- Se agregaron dos botones a la pestaña de pago mixto en la pestañla de terminar venta, estos colocan en la caja de texto junto a la que están el monto restante para realizar la compra
- Ahora la pestaña de pedidos de los porveedores ya se puede usar la tecla esc para regresar
- Se corrigió el error que sucedía cuando se escaneaba un código de barras, ya que este presionaba la tecla enter y hacía un acción en el prograam, como enviar un archivo vacío a la caja o entrar a la pestaña de agregar producto cuando no debía de hacerlo
- Se corrigió un error donde no se eliminaban correctamente de la base de datos los valores de la marca, categoría, proveedor y descripción de los productos por problemas con los atrivutos de entre estos
- Ahora cuando se cancela la modificación o agregación de un producto se reinicia la barra de progreso, anteriormente no lo hacía y se seguía incrementando hasta fallar

  Versión 1.0.0.7
- Se modificó de nuevo el proceso de creación de respaldos y los procesos de la pestaña de configuración general

Versión 1.0.0.6

- Arreglos al apartado de la creación de respaldos
- Se agregaron botones para modificar el directorio donde se guardan los respaldos
- Se agregó un botón para modficar la conexión con la base de datos a otra distinta(Importante que tenga la misma estructura o sino dará errores)
- Se eliminaron procesos de Md_inicialización que no se utilizaron
- Se agregó un par de líneas en el Md_Backup para obtener la conection string que está almacenado en el app config

Versión 1.0.0.5

- Se modifican los iconos de varios de los botones para que esten mejor alineados
- Correción de errores en la impresión de las facturas
- Bugfix general

Versión 1.0.0.4

- Se añadió la función para poder modificar el directorio en el que se exportan los respaldos de la base de datos
- Se arreglaron problemas en los que los productos no se podían buscar y filtrar por marca, proveedor y categoria a futuro se convertiran en drop downs
- Se arreglaron temas de diseño de la app para dejar todo un poco más uniforme, en la siguiente versión se modificarán lo iconos a unos más estandarizados
- Se modificó el ícono de todas las pestañas al actual y nuevo de la aplicación
- Se colocó un identificador de la versión de la aplicación en el menu de inicio
- Se modificaron los nombres de algunos controles que anteriormente aparecían con nombres incorrectos
- Se agregaron los nombre y titulos de cada una de las pestañas
