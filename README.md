# Sistema de Gestión Inmobiliaria 🏢

Este es un proyecto grupal desarrollado en **C#** utilizando **Windows Forms** para la asignatura de **Programación II**. El objetivo principal es diseñar e implementar un sistema para la administración, registro y control de bienes raíces, aplicando los conceptos fundamentales de la Programación Orientada a Objetos (POO), patrones de diseño y persistencia de datos en memoria.

## 📋 Información del Proyecto
* **Tecnología:** C# (.NET Framework)
* **Interfaz Gráfica:** Windows Forms
* **Paradigma:** Programación Orientada a Objetos (POO)
* **Persistencia:** Listas en memoria (`List<T>`) mediante el patrón **Singleton**

---

## 🏠 Descripción del Sistema
El sistema permite gestionar el catálogo de una agencia inmobiliaria. Se pueden registrar propiedades (Casas, Apartamentos) con sus atributos específicos, registrar a los clientes, y finalmente generar **Contratos** que vinculan ambas partes y cambian el estado de disponibilidad del inmueble automáticamente.

---

## 🎯 Arquitectura y Bloques Funcionales (CRUD)

Para cumplir con la rúbrica de evaluación, el sistema se diseñó bajo una arquitectura centralizada y se dividió en **3 bloques funcionales** asignados a cada integrante:

### ⚙️ Bloque 1: Arquitectura Base, Singleton y Menú (Christian Villalba)
* **Patrón Singleton:** Creación de la clase `SistemaCentral` que funciona como la base de datos en memoria del programa, garantizando que no se pierdan datos al cambiar de pantalla.
* **Interfaz Principal:** Diseño del `FrmMenuPrincipal` para una navegación fluida.
* **Control de Calidad:** Implementación de la operación **Eliminar** (con validación de `MessageBox`) y estructuración de los bloques `try-catch` generales para evitar cierres inesperados.

### 📝 Bloque 2: Clases POO y Módulo de Registro (Wilmer Maldonado)
* **Encapsulamiento POO:** Creación de las clases de negocio (`Inmueble`, `Cliente`, `Contrato`) utilizando propiedades privadas y públicas estrictas.
* **Operación Crear:** Desarrollo del `FrmRegistrar` con controles variados (TextBox, ComboBox) y validaciones de entrada para asegurar formatos correctos (ej. cédulas y teléfonos venezolanos) impidiendo el registro de campos vacíos.

### 📊 Bloque 3: Operaciones, Actualización y Reportes ([Nombre del 3er Integrante])
* **Operación Actualizar:** Desarrollo del `FrmOperaciones`, donde el usuario relaciona un Inmueble y un Cliente para crear un Contrato, alterando automáticamente el estado de la propiedad (ej. de Disponible a Vendida).
* **Operación Leer (Reportes):** Diseño del `FrmReportes` integrando controles `DataGridView` para mostrar el inventario de inmuebles y el historial de transacciones en tiempo real.

---

## 🛠️ Buenas Prácticas de Código Aplicadas
* **Nomenclatura:** Uso de `PascalCase` para clases/métodos y `camelCase` para variables.
* **Rendimiento:** Uso de ramas individuales en Git para evitar colisión de código y garantizar una integración limpia en la rama principal (`main`).
* **Experiencia de Usuario (UX):** Interfaz limpia, controles alineados y mensajes informativos claros ante cada acción.
