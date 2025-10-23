# CRUD-Category

Proyecto de ejemplo de un **CRUD funcional** desarrollado con **ASP.NET MVC** usando **Visual Studio Community**.

---

## Tecnologías utilizadas

- **ASP.NET MVC** (C#)
- **Entity Framework 8** para la conexión y manejo de la base de datos
- **Bootstrap** para el diseño responsive
- **JavaScript** para modales de interacción en el CRUD
- **SQL Server LocalDB** (sembrado de datos incluido)

---

## Funcionalidades

Este proyecto implementa un CRUD completo sobre una tabla de categorías:

- Crear nuevas categorías
- Editar categorías existentes
- Eliminar categorías
- Listar categorías en una vista
- Uso de **modales** para interacción amigable con el usuario
- Base de datos con datos de ejemplo (**seeded data**)

---

## Estructura del proyecto

- **Controladores:** `CategoryController` con acciones para Crear, Editar, Eliminar y Listar.  
- **Vistas:** `Create`, `Edit`, `Delete`, `Index` con Bootstrap y modales JavaScript.  
- **Modelo:** `Category` con propiedades básicas.  
- **Entity Framework:** configurado con migraciones y datos iniciales.

---

## Cómo descargar y ejecutar

1. Clona el repositorio en tu máquina local:

```bash
git clone https://github.com/saulbf96/CrudMVCAsp.git
