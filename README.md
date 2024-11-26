**Versión 1.1.0.6 (25 de noviembre de 2024)**
- Al entrar en la caja se mantiene seleccionado la caja de texto de buscar producto
- Al fallar la contraseña ahora se mantiene la selección de de la caja de texto para escribir la contraseña
- Las facturas ya deberían de mostrar correctamente toda la dirección de la sucursal
- Se arregló un error que hacia que al cancelar los cambios al modificar cualquier cosa en la app mostraba el error como si el producto fuera nuevo
- Ya funciona la tecla de esc en la pestaña de nuevo producto
- En todas las pestañas de agregar, modificar y de buscar ahora si se equivocan escribiendo un código que ya existe, lo selecciona todo para escribirlo de nuevo
- Se arregló un error con los hilos de la app que hacía que a la hora de hacer ciertas acciones en específicas no cargaba correctamente el menu contextual con los botones de eliminar y modificar en las pestañas de mantenimiento
- Se aseguró que todas las listas se cargaran ordenadas por código
- Mejoras de la calidad de vida general de la app
- Ahora al terminar cualquier proceso se mantiene el objeto seleccionado anteriormente en la tabla, funciona en todos menos en las pestañas de busqueda


**Versión 1.1.1.5 (23 de noviembre de 2024)**
- La caja de advertencia a la hora de confirmar que se quiere cerrar la app en la pestaña de selcción de usuario al iniciar la app ahora da la opción de cancelarlo y que no se cierre la app
- Se mejoró el proceso de busqueda de todas las pestañas que lo ocupaban y de el de las tablas de los pedidos de los proveedores
- Ahora al buscar marcas y luego de fallar una vez la contraseña en el login se va a mantener seleccionado la caja de texto en la que se estaba escribiendo
- Se arregló un error con el query para cargar las categorías que impedía entrar a esta pestaña del mantenimiento luego de actualizar la app a la BETA
- Se añadieron los atajos del teclado que faltaban, entre ellos los de la pestaña de terminar venta de f7 y f3
- Se añadieron indices en la base de datos y un espacio para agregar el inventario disponible en la tabla en la que se guardan los productos mas aun no se va a implementar este sistema

**Versión 1.1.0.5 BETA (22 de noviembre de 2024)**
- Se mejoró el proceso de carga de la tabla de productos para que sea mucho más rápida, por medio del uso de hilos y de un termporiador para que se actualize la tabla cuando termines de escribir
- Existen varios errores aún por arreglar y esta versión no es estable en lo más mínimo, tan solo es una prueba

**Versión 1.1.0.4 (20 de noviembre de 2024)**
- Se arregló un eror que se generaba al entrar a la pestaña de buscar productos en la caja si le dabas doble click a la caja de texto de buscar producto
- Se Eliminió el filtro de busqueda por nombre y por código de todas las pestañas de busqueda y mantenimiento, ahora la misma caja de texto ahce ambos funciones, lo que aceleró un poco el proceso de busqueda de la app

**Versión 1.1.0.3 (18 de noviembre de 2024)**
- Se arregló un error que sucedía al acceder a la caja y regresar a la pestaña de inicio causando que se perdiera el usuario en el camino
- Se agregó un espacio que faltaba en la factura de pago mixto entre el pago en efectivo y el pago en tarjeta
- Se disminuyó el tamaño del texto en el data grid view de fechas de pedidos de los proveedores en la pestaña principal
- Se corrigió un error de guardado que impedía la modificación de los datos de los cajerosluego de crearlos
- Se corregió un error en el que no se almacenaba correctamente el precio de un producto al crearse por primera vez
- Se corrigió un error donde al modificar un producto y quitar la marca  la que pertenecía antes esta no se eliminaba al guardar los cambios
- Ya se puede modificar correctamente los datos de los productos con precios variables, mas a estos no se les puede cambiar el precio al agregarlos, al menos no de momento
- Se arregló un error que se producía al modificar productos en la versión anterior en el cual luego de entrar no se podía actualizar la tabla de busqueda
- Se arregló un error donde al imprimir una factura que incluyera un producto variable el precio que se colocó de este no se reflejaba correctamente en esta factura
- El botón del menu contextual en la pestaña de reimprimir factura que permite reimprimir la factura que se desee antes imprimía de vez en cuando los valores incorrectos, ya se corrigió el código para que simempre imprima correctamente
- Se arregló un error que sucedía al eliminar una fila a la hora de agregar o modificar los dias de pedidos de los proveedores, si eliminaban una fila esta no se eliminaba correctamente y producía que uno de los 2 datos permaneciera haciendo que no se puedira volver a entrar a modificar el proveedor y que se rompiera las tablas de pedidos del menu de inicio


**Versión 1.1.0.2 (17 de noviembre de 2024)**
- Se revisó el funcionamiento de las configuraciones, ahora se necesita reiniciar la app para que los valores nuevos se carguen
- Se quitó el botón de regresar en la pestaña de selección de usuarios ya que no debía de estar ahí y se agregó el de cerrar la app
- Se modifico la ruta a la que iba el botón de regresar de la caja para que ahora vuelva correctamente al menu de inicio

**Versión 1.1.0.1 (16 de noviembre de 2024)**
- Ahora al crear cajeros se puede definir su rol, ya sea Administrador o cajero, el cajero tiene restringido el acceso a los reportes, al mantenimiento y a las configuraciones, mientras que el administrador puede acceder a todo el sistema, luego se añadirán más tipos de perfiles
- Con el cambio anterior ahora al entrar a la aplicación se te pedira iniciar sesión con una cuenta y se te habilitarán las opciones dependiendo del rol que tenga asignado tu cuenta
- Se cambió el nombre del botón de exportar base de datos por el de respaldar base de datos para que se entienda mejor su función
- Se arregló un error donde en la caja de texto de telefono a la hora de guardar los cambios hechos a un proveedor este no se eliminaba y los datos se quedaban ahí
- Se arregló un error donde al seguir una serie de pasos las listas se cargaban con un orden incorrecto en las pestañas de mantenimiento y de busqueda
- Se corrigió un error que provocaba que no se pudiera eliminar un producto en la pestaña de mantenimiento
- Se arreglaron errores a la hora de modificar productos, ya que antes en caso de querer quitar la descripción, marca, categoría o proveedor, estos no se quitaban correctamente en la base de datos
- Se arreglaron ciertos errores que produjo el cambio de las listas a la hora de modificar los productos en la caja
- Ahora al imprimir una factura si se pagó con el método de pago mixto en la factura se verá reflejado lo que pagó en efectivo y en tarjeta por aparte
- Se volvieron a corregir errores en el botón de imprimir más reciente, ahora si de verdad debería de funcionar bien

**Versión 1.1.0.0 (16 de noviembre de 2024)**
- Se modifico el formato de todas las listas para que sean más agradables a la vista y además ahora son mucho más eficientes y ya se pueden acomodar de menor a mayor y viceversa por cada una de las columnas (Se pasaron todas y sus procesos relacionados de un List view a Data grid view)
- Se removió el botón de cerrar la aplicación en la pestaña de mantenimiento de productos por problemas con los atajos del teclado
- Se corrigieron varios errores relacionados con la busqueda de productos donde dependiendo de los filtros que se usaban no se mostraba la información
- Se corrgió un error en las eliminaciones de proveedores donde estos no se podían eliminar correctamente si estaban relacionados con algún producto, ahora tiene el mismo proceso que con las marcas y las categorías, donde estas se, eliminan de los productos también

**Version 1.0.0.12 (14 de noviembre de 2024)**
- Se modificó el color de la pestala para agregar a la caja los producto variables para que sea más visible y se arreglaron problemas donde esta no se cerraba al terminar el proceso
- Creo que ahora si resolví el problema con el botón de imprimir más reciente y ya funciona correctamente, además en la lista de facturas ahora la más recinte también es la que aparece en la parte de más arriba


**Versión 1.0.0.11 (14 de nomviembre de 2024)**
- Ahora se pueden crear productos con precios variables, este tipo de productos al pasarlo por la caja muestran un pestaña en la cual además de mostrar la info del producto, te permite colocar el precio que desees para ese tipo de productos que se vende por kilo y demás. En este caso no se almacena níngun impuesto, ganancia o precio de venta, unicamente el precio base
- Había un error en la pestaña de agregar productos en el que a la hora de buscar un impuesto el resultado que te daba luego de escoger uno era incorrecto y estaba relacionado con la categoría en vez de con el impuesto correcto
- Ahora la crear o modificar un proveedor en el sistema el teclado para escribir se fija en la caja de de texto del código en vez de la del nombre como estaba antes

**Versión 1.0.0.10 (12 de noviembre de 2024)**
- Se cambio el formato de la lista de los productos en caja, ahora tiene un formato un poco más trabajado (se pasó de un list view a un datagrid), este cambio se hará en un futuro a todas las demás listas del sistema
- Junto con el cambio anterior ahora en la tabla de los productos en caja se puede  modificar el valor de la cantidad y se actualizan los valores correctamente
- Ahora al darle click a los filtros de buscar por nombre o código estos te colocan de una vez en la caja de etxto para que escribas tu busqueda, al igual que con los otros filtros del productos
- Se ajustaron los textos de los placeholders de algunas cajas de texto puesto que habían varias con leyendas incorrectas
- El botón de imprimir mas reciente debería de funcionar correctamente ahora
- Se corrigieron errores en donde al presionar enter en las pestañas de modificar y agregar en el mantenimiento se guardaban los datos como estuvieran en el momento sin importar que le faltara información necesaria, ahora el mismo botón también hace una última verificación antes de guardar la información
- Todas las listas del mantenimiento se acomodan por defecto por código de menor a mayor, en un futuro se podrá acomodar de muchas otras formas con los demás atributos de cada parte del mantenimiento.

**Versión 1.0.0.9 (11 de noviembre de 2024)**
- Ahora el botón de inicio de sesión siempre está habilitado para las cuentas de cajero sin contraseña
- Los dialogos para abrir los archivos para modificar el directorio y modificar la conexión con la base de datos muestran lo que está seleccionado actualmente
- Se corrigió un error en el que no se podía guardar correctamente los colores de los cajeros al modficarlos
- Se corrigió un error a la hora de modificar los proveedores ya que al eliminar los datos del correo o el telefono estos no eran correctamente eliminados de la base de datos
- Se agregaron dos botones a la pestaña de pago mixto en la pestañla de terminar venta, estos colocan en la caja de texto junto a la que están el monto restante para realizar la compra
- Ahora la pestaña de pedidos de los porveedores ya se puede usar la tecla esc para regresar
- Se corrigió el error que sucedía cuando se escaneaba un código de barras, ya que este presionaba la tecla enter y hacía un acción en el prograam, como enviar un archivo vacío a la caja o entrar a la pestaña de agregar producto cuando no debía de hacerlo
- Se corrigió un error donde no se eliminaban correctamente de la base de datos los valores de la marca, categoría, proveedor y descripción de los productos por problemas con los atrivutos de entre estos
- Ahora cuando se cancela la modificación o agregación de un producto se reinicia la barra de progreso, anteriormente no lo hacía y se seguía incrementando hasta fallar
- En la caja ya funcionan los atajos del teclado desde el f1-f8, a excepción del f2 que por alguna razón no lo hace

**Versión 1.0.0.7**
- Se modificó de nuevo el proceso de creación de respaldos y los procesos de la pestaña de configuración general

**Versión 1.0.0.6**

- Arreglos al apartado de la creación de respaldos
- Se agregaron botones para modificar el directorio donde se guardan los respaldos
- Se agregó un botón para modficar la conexión con la base de datos a otra distinta(Importante que tenga la misma estructura o sino dará errores)
- Se eliminaron procesos de Md_inicialización que no se utilizaron
- Se agregó un par de líneas en el Md_Backup para obtener la conection string que está almacenado en el app config

**Versión 1.0.0.5**

- Se modifican los iconos de varios de los botones para que esten mejor alineados
- Correción de errores en la impresión de las facturas
- Bugfix general

**Versión 1.0.0.4**

- Se añadió la función para poder modificar el directorio en el que se exportan los respaldos de la base de datos
- Se arreglaron problemas en los que los productos no se podían buscar y filtrar por marca, proveedor y categoria a futuro se convertiran en drop downs
- Se arreglaron temas de diseño de la app para dejar todo un poco más uniforme, en la siguiente versión se modificarán lo iconos a unos más estandarizados
- Se modificó el ícono de todas las pestañas al actual y nuevo de la aplicación
- Se colocó un identificador de la versión de la aplicación en el menu de inicio
- Se modificaron los nombres de algunos controles que anteriormente aparecían con nombres incorrectos
- Se agregaron los nombre y titulos de cada una de las pestañas
