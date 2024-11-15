
# Ejercicio: Gestión de Entidades Operativas del Cliente

## Descripción del Problema

Diseña un sistema que permita guardar información sobre las entidades con las que opera un cliente y los productos que tiene asociados a cada entidad. Cada cliente puede interactuar con múltiples entidades, y cada entidad puede ofrecer diferentes productos al cliente.

### Requerimientos Funcionales

1. **Guardar entidades y productos del cliente:**
   - Diseñar un endpoint que permita registrar las entidades financieras o comerciales con las que opera un cliente.
   - Cada entidad debe estar asociada a una lista de productos específicos.

2. **Consultar entidades y productos:**
   - Diseñar un endpoint que permita consultar todas las entidades y productos asociados a un cliente.

### Ejemplo de Escenario

Un cliente opera con las siguientes entidades:
- **Banco Sudameris**:
  - Producto: Tarjeta de Crédito
  - Producto: Préstamo Activo
- **Claro**:
  - Producto: Plan de Telefonía

El sistema debe permitir almacenar esta información y, posteriormente, consultarla.

### Consideraciones Técnicas

1. Los estudiantes deben definir:
   - El formato de los datos a almacenar (estructura de las entidades, productos y su relación con el cliente).
   - Los detalles de los requests y responses de los endpoints.

2. **Endpoints sugeridos**:
   - `POST /api/customers/{customerId}/entities`  
     Para registrar una entidad y sus productos asociados a un cliente.
   - `GET /api/customers/{customerId}/entities`  
     Para consultar las entidades y productos asociados a un cliente.

3. El diseño debe ser flexible para admitir:
   - Múltiples entidades por cliente.
   - Múltiples productos por entidad.
   - Actualización y eliminación de productos o entidades según sea necesario.

4. Se debe considerar cómo manejar la relación entre cliente, entidades y productos de manera eficiente.

### Objetivo del Ejercicio

- Que los estudiantes diseñen las estructuras de datos necesarias.
- Que definan los cuerpos de las solicitudes y respuestas en base a los requisitos.
- Que implementen un modelo de relación entre cliente, entidades y productos.
