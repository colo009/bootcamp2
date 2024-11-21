
# Módulo solicitado por el banco: Gestión de Préstamos

A continuación, se describen los requerimientos para la construcción de un sistema de gestión de préstamos. Este ejercicio cubrirá varios aspectos de los conocimientos adquiridos durante el Bootcamp.

---

## **Requerimientos del Sistema**

### **1. Creación de la Entidad "Plazo y Tasa de Interés"**
Diseñar una entidad que permita almacenar los siguientes datos en una base de datos:
- **Plazo** (en meses).
- **Tasa de Interés**.

Esta entidad será fundamental para la validación de plazos en los puntos subsecuentes, así como obtener el interés correspondiente. No es necesario crear endpoints en este punto.

---

### **2. Simulador de Cuota**
Implementar una funcionalidad que permita al cliente simular el importe mensual de un préstamo basado en los siguientes datos de entrada:
- **Monto**: Importe que desea solicitar.
- **Plazo**: Número de meses.

#### **Requisitos Técnicos:**
- Validar que el plazo ingresado sea un valor existente.
- Obtener el interés relacionado al plazo, para realizar los cálculos.
- Realizar el cálculo de la cuota.
- Mostrar al usuario el importe total a pagar, y el de la cuota.

---

### **3. Solicitud de Préstamo**
Crear una funcionalidad que permita a los clientes registrar solicitudes de préstamo, donde puedan seleccionar:
- **Tipo de Préstamo**: Personal, hipotecario, automotriz, etc.
- **Plazo**: En meses.
- **Monto**: Cantidad solicitada.

#### **Requisitos Técnicos:**
- Validar que el plazo ingresado sea un valor existente.
- Almacenar la solicitud en una tabla en la base de datos.
- Definir un estado inicial para la solicitud, como "Pendiente de Aprobación".

---

### **4. Aprobación/Rechazo de Solicitudes**
Implementar un flujo de aprobación/rechazo para las solicitudes de préstamo, accesible únicamente por usuarios con un rol autorizado. El sistema debe permitir:
- **Rechazo**: Cambiar el estado de la solicitud a "Rechazada".
- **Aprobación**:
  - Cambiar el estado de la solicitud.
  - Guardar los datos relevantes en una entidad de "Préstamos Aprobados", incluyendo:
    - Cliente.
    - Fecha de aprobación.
    - Monto solicitado.
    - Plazo.
    - Tipo de préstamo.
    - Tasa de interés.
  - Generar automáticamente las cuotas correspondientes, guardando:
    - Monto total de la cuota.
    - Monto del capital correspondiente.
    - Monto del interés correspondiente.
    - Fecha de vencimiento (el día 1 de cada mes, comenzando desde el mes siguiente de su aprobación).

#### **Requisitos Técnicos:**
 - Solicitudes y Préstamos se guardan en tablas diferentes.
 - Si la solicitud es "Rechazada", validar que se establezca un motivo de forma obligatoria.

---

### **5. Consulta de Detalles de un Préstamo**
Crear un endpoint protegido mediante un token válido para consultar los detalles de un préstamo aprobado. La respuesta debe incluir:
- Datos del cliente (Id y Nombre).
- Fecha de aprobación.
- Monto solicitado.
- Monto total a pagar.
- Ganancia obtenida.
- Plazo.
- Tipo de préstamo.
- Tasa de interés.
- Cantidad de cuotas pagadas.
- Cantidad de cuotas pendientes.
- Próxima fecha de vencimiento (o un mensaje indicando que todas las cuotas están pagadas, si es el caso).
- Cualquier otro dato que consideren relevante.

---

### **6. Pago de Cuotas**
Permitir a los clientes pagar una o varias cuotas de su préstamo. 

#### **Requisitos Técnicos:**
 - Las cuotas pagadas deben ser marcadas como "Pagadas" en la base de datos.
- Validar que no se puedan abonar más cuotas de las que correspondan.

---

### **7. Listado de Cuotas**
Enpoint para listar las cuotas de un préstamo. Permitir filtrar por:
- Todas las cuotas.
- Cuotas pagadas.
- Cuotas pendientes por pagar.

---

### **8. Listado de Cuotas Atrasadas**
Listar todas las cuotas atrasadas, mostrando:
- Cliente asociado.
- Fecha de vencimiento de la cuota.
- Días de atraso.
- Monto pendiente.

---

# Criterios Generales

### 1. Funcionalidad
- El código debe generar el resultado esperado.
- Calidad por sobre cantidad.

### 2. Base de datos
- Se deben guardar los datos de la mejor forma posible.

### 3. Buenas prácticas
- Seguir las políticas de nombramientos mencionadas por el profesor.
- Evitar código innecesario.
- Elegir los tipos de variables correctos según la situación.
- No tener código comentado.
- Principios SOLID.
- DRY (Don't Repeat Yourself).

### 4. Entendimiento
- Poder justificar los desarrollos realizados.

### 5. Performance
- La menor cantidad de viajes posibles a la base de datos.
- Presencia de solo las líneas necesarias para el funcionamiento.

### 6. Velocidad
- Rapidez con la que se entregan los desarrollos solicitados.
- No es el principal factor, pero es importante.

### 7. Pulcritud
- Se tiene en cuenta el esfuerzo realizado para la fácil lectura del código.

### 8. Responsabilidad
- Seguimiento a las reglas establecidas por el profesor.
