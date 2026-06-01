# Sistema de Gestión Inmobiliaria

Este es un proyecto grupal desarrollado en **C#** utilizando **Windows Forms** para la asignatura de **Programación II**. El objetivo principal es diseñar e implementar un sistema para la administración, registro y control de bienes raíces (propiedades, clientes y contratos), aplicando los conceptos fundamentales de la Programación Orientada a Objetos (POO), patrones de diseño y persistencia de datos en memoria.

## 📋 Información del Proyecto
* **Tecnología:** C# (.NET Framework / .NET Core)
* **Interfaz Gráfica:** Windows Forms
* **Paradigma:** Programación Orientada a Objetos (POO)
* **Persistencia:** Listas en memoria (`List<T>`) mediante el patrón **Singleton**

---

## 🏠 Descripción del Sistema
El sistema permitirá gestionar el catálogo de una agencia inmobiliaria. Se podrán registrar propiedades (Casas, Apartamentos, Locales Comerciales) con atributos específicos (dirección, precio, cantidad de habitaciones, estado: *Disponible, Vendido o Alquilado*), así como asociar estas propiedades a clientes interesados o propietarios.

---

## 🎯 Arquitectura y Requisitos del Proyecto (5 Puntos Clave)

Para cumplir con las pautas de evaluación y los requisitos mínimos exigidos, el desarrollo del sistema se divide formalmente en los siguientes **5 bloques funcionales**, asignados estratégicamente entre los integrantes:

### 🚀 Bloque 1 y 2: Arquitectura Base y Registro (Tu Parte)
* **Punto 1 - Diseño de Pantallas Base (Windows Forms):** Creación de la **Pantalla Principal / Menú** para una navegación fluida por el sistema y diseño de la **Pantalla de Creación/Registro** de propiedades. Implementación de controles variados (TextBox, ComboBox, DateTimePicker, etc.) con validaciones de entrada para asegurar que no se guarden campos vacíos o incorrectos.
* **Punto 2 - Arquitectura POO y Persistencia Base:** Creación de las **clases de negocio esenciales** (ej. clase `Propiedad`) aplicando encapsulamiento estricto (propiedades públicas/privadas) y constructores. Implementación del patrón de diseño **Singleton** para manejar la lista global de datos en memoria (`List<Propiedad>`), permitiendo que el sistema realice la primera operación CRUD: **Crear (Registrar nuevos inmuebles)**.

### 🛠️ Bloque 3: Módulo de Actualización y Modificación
* **Punto 3 - Operación CRUD (Actualizar):** Desarrollo de la **Pantalla de Edición y Actualización** de registros existentes. Este módulo permite al usuario seleccionar una propiedad cargada, modificar sus datos en los controles de entrada (cambiar precio, estado de disponibilidad, etc.) y guardar los cambios directamente en la lista en memoria manipulada por el Singleton.

### 📊 Bloque 4: Módulo de Visualización, Consultas y Reportes
* **Punto 4 - Interfaz y Reportes Avanzados (Leer):** Diseño y programación de la **Pantalla de Visualización y Detalles**. Implementación de al menos **2 controles DataGridView** para listar las propiedades de forma masiva. Integración de filtros de búsqueda avanzados mediante ComboBox o ListBox para segmentar inmuebles por tipo, zona o precio (Operación CRUD: *Leer*).

### ❌ Bloque 5: Módulo de Eliminación y Control de Calidad
* **Punto 5 - Operación CRUD (Eliminar) y Excepciones:** Desarrollo del módulo para **Borrar registros de la lista**. Por seguridad del negocio, esta acción requerirá obligatoriamente una ventana de confirmación interactiva (`MessageBox`) antes de ejecutar la baja. Adicionalmente, se encarga de la implementación del manejo de errores global mediante bloques **try-catch** para asegurar que el programa jamás se cierre inesperadamente en tiempo de ejecución.

---

## 👥 Estructura del Equipo y Asignación de Roles

A partir de la arquitectura de 5 puntos definida arriba, los roles quedan distribuidos de la siguiente manera:

* **Desarrollador 1 (Líder / Backend Base): Wilmer Maldonado** -> Encargado de los **Puntos 1 y 2** (Estructura base del proyecto, Singleton, Clases principales, Menú y Pantalla de Registro).
* **Desarrollador 2:** *[Nombre del compañero]* -> Encargado del **Punto 3** (Pantalla de Edición y Actualización de registros).
* **Desarrollador 3:** *[Nombre del compañero]* -> Encargado del **Punto 4** (Pantalla de Reportes, Consultas y carga de DataGridViews).
* **Desarrollador 4 (Modelado e Integración): Cristian** -> Encargado de los diagramas, estructura previa y apoyo en el **Punto 5** junto a las validaciones finales del sistema.

---

## 🛠️ Buenas Prácticas de Código (Estándares de Evaluación)
* **Nomenclatura:** Uso estricto de `PascalCase` para nombres de clases, métodos y propiedades, y `camelCase` para variables locales y parámetros.
* **Código Limpio:** Funciones bien definidas para evitar código repetido, nombres descriptivos e indentación correcta.
* **Flujo:** Interfaz limpia, controles alineados, navegación fluida y sin duplicación ni pérdida de datos en memoria.
