# API de Tarjetas de Crédito

Este README describe los endpoints disponibles para la gestión de tarjetas de crédito en una API bancaria. A continuación se presentan los endpoints en inglés, pero las descripciones están en español para mayor claridad.

## Endpoints

### 1. **Crear una nueva tarjeta de crédito**
   - **Endpoint:** `POST /api/cards`
   - **Descripción:** Emite una nueva tarjeta de crédito para un cliente específico.
   - **Request Body:**
     ```json
     {
       "customerId": "12345",
       "cardType": "Visa",
       "creditLimit": 10000,
       "expirationDate": "2025-12",
       "interestRate": 18.5
     }
     ```
   - **Response:**
     ```json
     {
       "cardId": "98765",
       "customerId": "12345",
       "cardNumber": "XXXX-XXXX-XXXX-1111",
       "expirationDate": "2025-12",
       "status": "active"
     }
     ```

### 2. **Obtener información de una tarjeta de crédito**
   - **Endpoint:** `GET /api/cards/{cardId}`
   - **Descripción:** Consulta los detalles de una tarjeta de crédito específica, con el número de tarjeta enmascarado.
   - **Response:**
     ```json
     {
       "cardId": "98765",
       "customerId": "12345",
       "cardNumber": "XXXX-XXXX-XXXX-1111",
       "expirationDate": "2025-12",
       "status": "active",
       "creditLimit": 10000,
       "availableCredit": 8000,
       "interestRate": 18.5
     }
     ```

### 3. **Listar todas las tarjetas de un cliente**
   - **Endpoint:** `GET /api/customers/{customerId}/cards`
   - **Descripción:** Devuelve una lista de todas las tarjetas de crédito asociadas a un cliente, con los números de tarjeta enmascarados.
   - **Response:**
     ```json
     [
       {
         "cardId": "98765",
         "cardNumber": "XXXX-XXXX-XXXX-1111",
         "expirationDate": "2025-12",
         "creditLimit": 10000,
         "availableCredit": 8000
       },
       {
         "cardId": "12345",
         "cardNumber": "XXXX-XXXX-XXXX-2222",
         "expirationDate": "2026-05",
         "creditLimit": 5000,
         "availableCredit": 3000
       }
     ]
     ```

### 4. **Realizar un cargo en una tarjeta de crédito**
   - **Endpoint:** `POST /api/cards/{cardId}/charges`
   - **Descripción:** Procesa un cargo a una tarjeta de crédito (por una compra).
   - **Request Body:**
     ```json
     {
       "amount": 150,
       "description": "Compra en tienda",
       "date": "2024-11-10"
     }
     ```
   - **Response:**
     ```json
     {
       "chargeId": "67890",
       "cardId": "98765",
       "amount": 150,
       "availableCredit": 7850,
       "description": "Compra en tienda",
       "date": "2024-11-10"
     }
     ```

### 5. **Realizar un pago a una tarjeta de crédito**
   - **Endpoint:** `POST /api/cards/{cardId}/payments`
   - **Descripción:** Procesa un pago a una tarjeta de crédito (reducción de deuda).
   - **Request Body:**
     ```json
     {
       "amount": 200,
       "paymentMethod": "bank transfer",
       "date": "2024-11-11"
     }
     ```
   - **Response:**
     ```json
     {
       "paymentId": "54321",
       "cardId": "98765",
       "amount": 200,
       "availableCredit": 8050,
       "date": "2024-11-11"
     }
     ```

### 6. **Consultar el historial de transacciones de una tarjeta**
   - **Endpoint:** `GET /api/cards/{cardId}/transactions`
   - **Descripción:** Obtiene un historial de transacciones (cargos y pagos) de la tarjeta de crédito.
   - **Query Params:** `startDate`, `endDate`
   - **Response:**
     ```json
     [
       {
         "type": "charge",
         "amount": 150,
         "description": "Compra en tienda",
         "date": "2024-11-10"
       },
       {
         "type": "payment",
         "amount": 200,
         "description": "Pago recibido",
         "date": "2024-11-11"
       }
     ]
     ```
