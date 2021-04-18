# Proyecto de Catedra 

## Licencia: Reconocimiento - Compartir Igual (CC BY-SA)
---
Esta licencia permite que otros mezclen, adapten y desarrollen sobre su trabajo incluso con fines comerciales, siempre que le otorguen crédito y licencian sus nuevas creaciones bajo los mismos términos. Esta licencia a menudo se compara con licencias de software de código abierto y gratuitas "copyleft". Todos los trabajos nuevos basados en el suyo llevarán la misma licencia, por lo que cualquier derivado también permitirá el uso comercial. Esta es la licencia utilizada por Wikipedia y se recomienda para materiales que se beneficiarían de la incorporación de contenido de Wikipedia y proyectos con licencias similares.



### Tecnologías utilizadas:
---
- Visual Studio
- GitHub
- Trello
- DFD
- Editor de texto
<img align="left" alt="Visual Studio" width="26px" src="https://user-images.githubusercontent.com/73325232/115159853-72e05900-a052-11eb-9976-b6035cd35f36.png"/>
<img align="left" alt="GitHub" width="26px" src="https://user-images.githubusercontent.com/73325232/115159943-f8640900-a052-11eb-847a-afeac77f5e5b.png"/>
<img align="left" alt="Trello" width="26px" src="https://user-images.githubusercontent.com/73325232/115159984-1467aa80-a053-11eb-959b-3e33acbcbdba.png"/>
<img align="left" alt="VS Code"  width="26px" src="https://user-images.githubusercontent.com/73325232/115162334-2e5bba00-a060-11eb-9e74-d61153ba146f.png"/>
/


## Manual de usuario
---
En este caso el ejercicio nos dice: Don José necesita un sistema para llevar los registros de sus ventas diarias e inventarios en su tienda de productos de consumo diario, que tiene 10 productos de variedad. Cada venta realizada debe de ir afectando el inventario. La información debe guardarse en un archivo de texto, para luego leer los archivos y ser guardados en listas o matrices o vectores, así mantener en memoria mientras esté funcionando el sistema.
A continuación, presentamos algunas consideraciones que son importante de tener en cuenta para comprender el funcionamiento del programa: 
Los productos que la tienda de Don José dispone en su inventario son ingresados, junto con sus detalles, por medio de un archivo “.txt”, por lo que hemos ingresado el documento “Inventario.txt” dentro de la carpeta “netcoreapp3.1”, para ingresar a ella siga lo siguientes pasos:

1. Ingrese a la carpeta “Proyecto-Catedra-GP3”. <br><img src="https://user-images.githubusercontent.com/73325232/115162185-51d23500-a05f-11eb-8080-ed06655afe67.png" alt="InstruccionUno">
2. Ingrese a la carpeta “bin”. <br><img src="https://user-images.githubusercontent.com/73325232/115162473-e7ba8f80-a060-11eb-902a-bbd086a03c2d.png" alt="InstruccionDos">
3. Ingrese a la única carpeta que aparecerá, “Debug”.
4. Ingrese a la única carpeta que aparecerá, “netcoreapp3.1”.
5. El documento “Inventario.txt” que aparecerá es el que utilizamos para definir el código de los productos, el nombre, el precio, la cantidad disponible en el inventario y el detalle del producto. <br><img src="https://user-images.githubusercontent.com/73325232/115162492-0751b800-a061-11eb-83eb-5a86a45b8da7.png" alt="InstruccionTres"> <br>Este archivo está conformado por una estructura definida que va de la siguiente forma: código, nombre del producto, precio, cantidad, descripción, es decir, que, si deseamos modificar el código de un producto, modificaremos el primer espacio.
  




#### Funcionamiento de “Inventario y ventas”.
-	Al ejecutar el programa en Visual Studio, se abrirá la consola y dará las siguientes opciones: <img src="https://user-images.githubusercontent.com/73325232/115162777-a2975d00-a062-11eb-9d81-e0ff89c2de6e.png" alt="InstruccionbUno">
- Puedes ingresar tanto letras mayúsculas como minúsculas, y en el caso de presionar una tecla incorrecta el programa lo dará a conocer, dando alternativas para ejecutarlo de manera correcta.
- Al ingresar al menú “A. Ver todos los productos”, la consola nos mostrará lo siguiente: <img src="https://user-images.githubusercontent.com/73325232/115162805-c3f84900-a062-11eb-8b5d-42c8a45581dd.png" alt="InstruccionbDos"> 
  
- Nos dará el espacio para poder digitar el código del producto. IMPORTANTE: El código del producto no debe estar antecedido por 0 (Cero). Por ejemplo, si queremos     comprar 5 Resmas de papel se ingresará el código “10”. <img src="https://user-images.githubusercontent.com/73325232/115162814-d07ca180-a062-11eb-8c77-3dd027839c54.png" alt="InstruccionbTres">
- Al presionar “Enter” mostrará los detalles del producto, es decir, el nombre, descripción, unidades disponibles y el precio. Seguidamente se debe ingresar la cantidad de unidades a comprar. IMPORTANTE: Si el número que se ingresa para comprar es mayor al número de unidades disponibles el programa no permitirá continuar y mostrará una alerta, por ejemplo, si ingresamos 150 unidades por comprar, el programa nos mostrará lo siguiente: <img src="https://user-images.githubusercontent.com/73325232/115162878-47b23580-a063-11eb-92e4-cc56387ac80d.png" alt="InstruccionbCuatro">
- En este caso, ingresamos un número dentro del rango disponible para poder comprar, 45 unidades, y el programa nos mostrará las unidades ingresadas, el precio unitario y el total a pagar, así como se muestra a continuación: <img src="https://user-images.githubusercontent.com/73325232/115162893-56005180-a063-11eb-8732-c40606b6cfb0.png" alt="InstruccionbCinco">
- Al presionar cualquier tecla volveremos al menú de inicio, dado que hasta acá se ha llegado con el segundo avance del proyecto final.
- Al ingresar al menú “B. Buscar un producto por su código”, la consola nos mostrará lo siguiente: <img src="https://user-images.githubusercontent.com/73325232/115162916-78926a80-a063-11eb-86dd-f6ad2ad8630a.png" alt="InstruccionbSeis">
- Se deberá ingresar el código del producto. IMPORTANTE: El código del producto no debe estar antecedido por 0 (Cero).  En este caso ingresaremos el código de los bolígrafos azules, que es el código 6, y presionaremos “Enter”. <img src="https://user-images.githubusercontent.com/73325232/115162932-8b0ca400-a063-11eb-9ac9-28526329e100.png" alt="InstruccionbSiete">
- Nos mostrará que el producto fue encontrado, y dará a conocer, además del código, el nombre y la descripción. Presionar cualquier tecla para regresar al menú principal. IMPORTANTE: Si se ingresa un código no válido el programa nos alertará de ello. <img src="https://user-images.githubusercontent.com/73325232/115162976-c7400480-a063-11eb-951f-0f09dd653530.png" alt="InstruccionbOcho">
- Al presionar cualquier tecla se regresará al menú principal. Por el momento, éste es el avance de dicho menú para el segundo avance del proyecto final.
- Para salir del programa principal, estando en el menú principal, basta con presionar “ESC” 2 veces. <img src="https://user-images.githubusercontent.com/73325232/115162961-b2637100-a063-11eb-83a4-ec46d24f6c75.png" alt="InstruccionbNueve">
