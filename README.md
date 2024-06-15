[![Markdown Validation](https://github.com/ChristianGrimberg/Christian-Grimberg-58425-Desafio-3/actions/workflows/markdown-validation.yml/badge.svg?branch=main)](https://github.com/ChristianGrimberg/Christian-Grimberg-58425-Desafio-3/actions/workflows/markdown-validation.yml)
[![.NET Validation](https://github.com/ChristianGrimberg/Christian-Grimberg-58425-Desafio-3/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/ChristianGrimberg/Christian-Grimberg-58425-Desafio-3/actions/workflows/dotnet.yml)

# Integrando Apis con Ado.Net

> En nuestro Proyecto Web API, añadir los Endpoint del ABM de nuestra API

## Consigna

* Deben utilizar los métodos de ABM creados en clases anteriores __(Modificar Usuario, Crear Producto, Modificar Producto, Eliminar Producto, Cargar Venta)__ y agregar los métodos necesarios a nuestras clases controladoras ya creadas en la clase 14 (UsuarioController, ProductoController VentaController) para que podamos exponerlos mediante nuestra API.
* Entregar en conjunto con los métodos Get del ejercicio dado en la clase 14.

## Aspectos a incluir

* Modificar las clases Controllers dentro de la carpeta "Controllers" (UsuarioController, VentaController, ProductoVendidoController y ProductoController) para agregar los métodos CRUD referidos al modelo dado para el proyecto.

## Formato

* Link del repositorio del proyecto en Github. (Subir la versión entregable del código a una rama llamada "master")

## Detalle

* __Modificar usuario__: Recibe como parámetro todos los datos del objeto usuario y se deberá modificar el mismo con los datos nuevos (No crear uno nuevo).
* __Crear producto__: Recibe un producto como parámetro, deberá crearlo, puede ser void, pero validar los datos obligatorios.
* __Modificar producto__: Recibe un producto como parámetro, debe modificarlo con la nueva información.
* __Eliminar producto__: Recibe un id de producto a eliminar y debe eliminarlo de la base de datos (eliminar antes sus productos vendidos también, sino no lo podrá hacer).
* __Cargar Venta__: Recibe una lista de productos y el número de IdUsuario de quien la efectuó, primero cargar una nueva Venta en la base de datos, luego debe cargar los productos recibidos en la base de ProductosVendidos uno por uno por un lado, y descontar el stock en la base de productos por el otro.
