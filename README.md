# The Shortly Project

The **Shortly Project** is a sample .NET 10 application demonstrating best practices in architecture, design patterns, and coding conventions.

It serves as a reference implementation for building clean, maintainable, and scalable applications using ASP.NET Core Minimal APIs, Entity Framework Core, and other modern technologies.

---
&copy; 2026 Arquitectura de Sistemas, DISC, UCN, Chile. All rights reserved.

---

## Project Structure and Laboratory Deliverables

This repository contains the development of the Shortly application and the 
deliverables associated with the different laboratory assignments.

### Laboratory 3 – API Development

The implementation of the REST API can be found primarily in:

Endpoints/ApiEndpoints.cs

Additional functionality related to the API is distributed throughout the project according to the layered architecture:

- **Application/** – DTOs, interfaces, and business contracts.
- **Controllers/** – API controllers.
- **Domain/** – Domain entities.
- **Infrastructure/** – Repositories, persistence, and database initialization.
- **Endpoints/** – Minimal API endpoint definitions.

### Laboratory 4 – Architecture Documentation

The deliverables for Laboratory 4 are located in the **docs/** directory.

Contents include:

docs/
├── **architecture.md**
└── **[architecture diagrams]**

These documents describe:

- Service decomposition rationale.
- Communication patterns.
- Data ownership strategy.
- Scalability considerations.
- Architecture diagrams and supporting materials.

### Laboratory 5 – Docker Containerization

The deliverables for Laboratory 5 are located both in the project root and in the
 **docs/** directory.

**Root directory**
Dockerfile
docker-compose.yml
.dockerignore
.env
IA.md

These files contain:

- Multi-stage Docker build configuration.
- Docker Compose orchestration.
- Environment variable configuration.
- Docker build context exclusions.
- AI usage report.

**Documentation**

- docs/docker.md

This document contains:

- Docker prerequisites.
- Build and execution instructions.
- Logging commands.
- Cleanup procedures.
- Health check information.
- Network and volume configuration.

**Running the Project with Docker**

Build and start the application:

docker compose up --build

Stop all services:

docker compose down

Remove containers and persistent volumes:

docker compose down -v
