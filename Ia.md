# Lab 3 API REST

## AI Assistance Report

### 1. Enabling XML Support in ASP.NET Core

**Tool Used:** Claude

**Prompt Used:**
*"How do I enable support for XML responses in addition to JSON in ASP.NET Core?"*

**Response Obtained:**
The tool explained that ASP.NET Core supports JSON by default and that XML support can be added by registering XML formatters using `AddXmlSerializerFormatters()` when configuring controllers. It also described how the framework selects the response format based on the client's `Accept` header.

**How It Was Integrated:**
The information was used as guidance to configure the API so that it could return responses in both JSON and XML formats. The recommended formatter registration was incorporated into the application's service configuration, allowing the API to support content negotiation as required by the laboratory.

---

### 2. Returning 406 Not Acceptable

**Tool Used:** Claude

**Prompt Used:**
*"How do I configure ASP.NET Core to return 406 Not Acceptable when the requested format is not supported?"*

**Response Obtained:**
The tool explained that ASP.NET Core can be configured to return a **406 Not Acceptable** response by enabling the `ReturnHttpNotAcceptable` option in the controller configuration. It also described how this behavior works together with content negotiation and supported media types.

**How It Was Integrated:**
The information was used to configure the API so that unsupported response formats generate the appropriate HTTP status code. This ensured that the application's behavior matched the REST requirements specified in the laboratory.

---

### 3. HTTP Status Codes

**Tool Used:** Claude

**Prompt Used:**
*"What is the difference between HTTP status codes 200 OK, 201 Created, and 204 No Content?"*

**Response Obtained:**
The tool explained the purpose of each status code. It described that **200 OK** is used for successful requests returning data, **201 Created** is used when a new resource is successfully created, and **204 No Content** indicates that an operation completed successfully without returning a response body.

**How It Was Integrated:**
The explanation was used as a reference when selecting the appropriate status codes for the REST API endpoints. The responses returned by the different operations were aligned with the expected HTTP semantics defined in the laboratory instructions.

---

### 4. Dependency Injection Service Lifetimes

**Tool Used:** Claude

**Prompt Used:**
*"What is the difference between AddScoped(), AddSingleton(), and AddTransient() in ASP.NET Core?"*

**Response Obtained:**
The tool explained the lifetime of each dependency injection registration. It described that **AddScoped()** creates one instance per request, **AddSingleton()** creates a single shared instance for the application's lifetime, and **AddTransient()** creates a new instance every time the service is requested.

**How It Was Integrated:**
The information served as guidance when registering repositories, services, and infrastructure components in the dependency injection container. The explanations helped determine the most appropriate lifetime for each component based on its responsibilities.

---

### 5. Logging with ILogger

**Tool Used:** Claude

**Prompt Used:**
*"How do I log messages using ILogger in a service layer?"*

**Response Obtained:**
The tool explained how to inject `ILogger<T>` into service classes and how to record messages using different logging levels such as Debug, Information, Warning, and Error. It also described common scenarios in which each logging level is appropriate.

**How It Was Integrated:**
The information was used as a guide for incorporating structured logging into the service layer. Log messages were added to record significant operations, warnings, and error conditions, improving traceability and making it easier to monitor the application's execution.

# Lab 4 Microservice

## AI Assistance Report

### 1. C4 Diagram Levels

**Tool Used:** ChatGPT

**Prompt Used:**
*"What is the difference between Context, Container, and Component diagrams in the C4 model?"*

**Response Obtained:**
The tool explained the purpose of each C4 diagram level. It described that the **Context Diagram** provides a high-level view of the system and its interactions with external actors and systems, the **Container Diagram** shows the main applications, services, and databases that make up the system, and the **Component Diagram** details the internal structure of a selected container by presenting its main components and their interactions.

**How It Was Integrated:**
The explanation was used as a reference for defining the scope and level of detail of each C4 diagram. This helped ensure that the diagrams followed the C4 methodology and that each level represented the appropriate architectural perspective.

---

### 2. Data Ownership in Microservices

**Tool Used:** ChatGPT

**Prompt Used:**
*"What does Data Ownership mean in a microservices architecture?"*

**Response Obtained:**
The tool explained that Data Ownership means each microservice is responsible for its own data and database. It also described that services should not directly modify another service's data and that communication between services is used to exchange information while maintaining loose coupling.

**How It Was Integrated:**
The information was used to define the data ownership section of the architecture document. Each proposed microservice was assigned responsibility for its own data, and the explanation helped describe how data consistency would be maintained across the system.

---

### 3. Relationships in C4 Diagrams

**Tool Used:** ChatGPT

**Prompt Used:**
*"How should relationships between microservices be represented correctly in a C4 diagram?"*

**Response Obtained:**
The tool explained that relationships in C4 diagrams should clearly indicate the direction of communication, identify the participating systems or services, and include concise labels describing the interaction or communication protocol, such as REST, HTTP, or messaging.

**How It Was Integrated:**
The information was used as guidance when creating the C4 diagrams. Relationships between actors, services, databases, and supporting infrastructure were labeled consistently to improve readability and accurately represent the communication flow within the proposed architecture.

---

### 4. Microservices vs. Monolithic Architecture

**Tool Used:** ChatGPT

**Prompt Used:**
*"What advantages does a microservices architecture offer over a monolithic architecture for an application like Shortly?"*

**Response Obtained:**
The tool explained that a microservices architecture improves scalability, maintainability, fault isolation, and independent deployment. It also described how separating responsibilities into independent services allows different parts of the system to scale individually and reduces the impact of failures on the overall application.

**How It Was Integrated:**
The explanation was used to justify the proposed architectural design in the architecture document. The identified advantages supported the decision to decompose the original monolithic application into multiple microservices, each with a clearly defined responsibility and independent scalability.



