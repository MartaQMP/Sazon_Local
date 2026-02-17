<div align="center">

# 🌿 Sazón Local: El sabor que el campo no perdió
  
  ![Stack](https://img.shields.io/badge/Stack-.NET_Core_MVC-512bd4)
  ![Lenguaje](https://img.shields.io/badge/Language-C%23-239120)
  ![DB](https://img.shields.io/badge/Database-SQL_Server-red)
  ![Region](https://img.shields.io/badge/Region-Madrid_KM0-orange)
  
</div>

---

## 🛠️ Stack Tecnológico

* **Backend:** ASP.NET Core MVC con C#.
* **Frontend:** Vistas Razor, HTML5, CSS3 y JavaScript (integrados en el patrón MVC).
* **Base de Datos:** SQL Server con T-SQL.
* **ORM:** Entity Framework Core (Database-First/Code-First).

---

## 🏗️ Arquitectura del Sistema

El proyecto sigue el patrón de diseño **MVC**, garantizando una separación clara de responsabilidades:

* **Modelos (Models):** Mapeo directo con las tablas de SQL Server (Usuarios, Fincas, Productos, Pedidos).
* **Vistas (Views):** Interfaz dinámica para Clientes (Catálogo/Carrito) y Agricultores (Panel de Control de Fincas).
* **Controladores (Controllers):** Lógica de negocio, gestión de sesiones de usuario y procesamiento de transacciones.

---

## 📊 Entidades de Negocio (SQL Server)

El modelo de datos está optimizado para la logística de la Comunidad de Madrid:

1.  **Gestión de Usuarios:** Roles diferenciados para Admin, Agricultor y Cliente.
2.  **Módulo de Producción:** Localización geográfica de 65 fincas mediante coordenadas (Lat/Long) para futuros cálculos de rutas.
3.  **Catálogo Dinámico:** Gestión de 22 subcategorías con soporte para unidades de medida mixtas (KG/Unidad).
4.  **Flujo de Venta:** Sistema de carrito, pedidos y pasarela de pagos simulada con trazabilidad por tarjeta.

---

## 💡 Funcionalidades Destacadas de la Implementación

* **Validación de Stock en el Checkout:** Lógica en C# para verificar la disponibilidad en SQL Server antes de procesar el pago.
* **Filtros de KM 0:** Búsqueda de productos basada en la proximidad de las fincas a las direcciones del cliente en Madrid.
* **Persistencia de Carrito:** Gestión de ítems por sesión de usuario para facilitar la experiencia de compra.

---

<div align="center">

Desarrollado como un ecosistema digital para conectar el campo con la ciudad. 🍎🚜

</div>
