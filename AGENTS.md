# AGENTS.md

## Overview
This document provides comprehensive guidelines and instructions for agents working with the EZBook codebase. It includes setup, build, lint, and test commands, as well as detailed code style guidelines. It serves as a reference for maintaining consistency and quality across development.

## Backend Purpose
The EZBook backend is designed for managing an aesthetics or hairdressing business. The main features include:
- Users with associated schedules and services
- Reservations linking users, clients, and services
- Integration with a chatbot for automated scheduling via API

### Key API Endpoints

#### ENDPOINT USUARIOS

- **/api/usuario**: Manage users, their services, and schedules

1. Obtener todos los usuarios:
  - Metodo GET a api/usuario
2. Obtener usuario por ID:
  - Metodo GET a api/usuario/{id}
3. Obtener servicios que brinda un usuario
  - Metodo GET a api/usuario/{id}/services
4. Crear usuarioService (asociar usuario con servicio)
  - Metodo POST a api/usuario/{id}/services
  - Cuerpo JSON  de peticion: 
    {
      "usuarioId": "guid-del-usuario",
      "servicioId": "guid-del-servicio"
    }
5. Obtener horarios en los que trabaja un usuario
  - Metodo GET a api/usuario/{id}/horarios
6. Crear horario para un usuario
  - Metodo POST a api/usuario/{id}/horarios
  - Cuerpo JSON  de peticion: 
    {
       "usuarioId": "guid-del-usuario",
       "dia": "Lunes",
       "inicio": "09:00:00",
       "fin": "18:00:00"
    }
7. Crear usuario
  - Metodo POST a api/usuario
  - Cuerpo JSON  de peticion: 
    {
      "nombre": "Carlos",
      "apellido": "Ramirez",
      "telefono": "123456789",
      "email": "carlos.ramirez@example.com",
      "password": "contraseña123",
      "rol": 0 (Administrador), 1(Gerente), 2(Empleado)
    }
8. Login de usuario
  - Metodo POST a api/usuario/login
  - Cuerpo JSON  de peticion: 
    {
      "email": "carlos.ramirez@example.com",
      "password": "contraseña123"
    }
  - Devuelve token de estilo: "nombreUsuario/rol"

- **/api/reserva**: Manage reservs

1. Obtener todas las reservas:
  - Metodo GET a api/reserva
2. Obtener reserva por ID:
  - Metodo GET a api/reserva/{id}
4. Crear reserva
  - Metodo POST a api/reserva
  - Cuerpo JSON  de peticion: 
    {
      "usuarioId": "guid-usuario-1",
      "servicioId": "guid-servicio-1",
      "clienteId": "guid-cliente-1",
      "fechaHoraInicio": "2026-06-26T09:00:00",
      "fechaHoraFin": "2026-06-26T09:30:00",
      "estado": 0(Pendiente), 1(Confirmada), 2(Pagada)
    }

- **/api/servicio**: Manage services

1. Obtener todos los servicios:
  - Metodo GET a api/servicio
2. Obtener usuarios que bridan servicio por ID:
  - Metodo GET a api/servicio/{id}/usuarios
4. Crear servicio
  - Metodo POST a api/servicio
  - Cuerpo JSON  de peticion: 
    {
      "nombre": "Depilación",
      "descripcion": "Depilación con cera para piernas completas",
      "precio": 1500,
      "duracion": 60,
      "descanso": 15
    }

- **/api/servicio**: Manage clients

1. Obtener todos los clientes:
  - Metodo GET a api/cliente
2. Obtener cliente por ID:
  - Metodo GET a api/cliente/{id}
4. Crear cliente
  - Metodo POST a api/servicio
  - Cuerpo JSON  de peticion: 
    {
      "nombreCompleto": "Maria Lopez",
      "dni": "12345678",
      "telefono": "987654321"
    }

- **/api/servicio**: GET BOT INFO

1. Obtener todos los bots:
  - Metodo GET a api/bot
2. Obtener bot por ID:
  - Metodo GET a api/bot/{id}
