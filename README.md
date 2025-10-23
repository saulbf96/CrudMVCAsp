# CRUD-Category

Proyecto de ejemplo de un **CRUD funcional** desarrollado con **ASP.NET MVC** usando **Visual Studio Community**.

---

## Tecnolog�as utilizadas

- **ASP.NET MVC** (C#)
- **Entity Framework 8** para la conexi�n y manejo de la base de datos
- **Bootstrap** para el dise�o responsive
- **JavaScript** para modales de interacci�n en el CRUD
- **SQL Server LocalDB** (sembrado de datos incluido)

---

## Funcionalidades

Este proyecto implementa un CRUD completo sobre una tabla de categor�as:

- Crear nuevas categor�as
- Editar categor�as existentes
- Eliminar categor�as
- Listar categor�as en una vista
- Uso de **modales** para interacci�n amigable con el usuario
- Base de datos con datos de ejemplo (**seeded data**)

---

## Estructura del proyecto

- **Controladores:** `CategoryController` con acciones para Crear, Editar, Eliminar y Listar.  
- **Vistas:** `Create`, `Edit`, `Delete`, `Index` con Bootstrap y modales JavaScript.  
- **Modelo:** `Category` con propiedades b�sicas.  
- **Entity Framework:** configurado con migraciones y datos iniciales.

---

## C�mo descargar y ejecutar

1. Clona el repositorio en tu m�quina local:

```bash
git clone https://github.com/saulbf96/CrudMVCAsp.git
