# FleetUp Maintenance Web API
======

Basic web api that keep track of maintenance tasks for vehicles in order to keep them working and increasing company's production levels.
This a basic proof of concepts; CQRS,DDD, AGGREGATES, SOLID 

We have applied Clean Code Architecture for this project. 

## Projects:
#### Soinsoft.FleetUp.Domain.Contracts
Generic repository interface (one per aggregate)

#### Soinsoft.FleetUp.Domain.Entities
Entities/Aggregates to be used across the solution

#### Soinsoft.FleetUp.Application.Contracts
Interfaces for services

#### Soinsoft.FleetUp.Application.Business
Commands, commands handlers, querys, querys handlers, Dtos, and their related validators

#### Soinsoft.FleetUp.Infraestructure.Persistence
Entitty Framework persistence using SQLLite. migrations, generic repository, etc

#### Soinsoft.FleetUp.Presentation.WebAPI
Web API for exposing functionality using mediator, root app composition, services, etc.

This project can be used as a starting point to build scalable applications and easy to maintain.
Every vehicle has a group of maintenance tasks to be applied every x miles.

## Database:
For this project we worked with SqlLite but since this implemented via Entity Framework, you can switch to SQL Server/Postgresql.

## Model:
Asset: is the vehicle used for scheduling maintenance routines
Maintenance: is the taks to be performed on vehicles in order to keep them working safely and improve performance
WorkOrder: details of executed maintenance on vehicles.


## RESTful end points:
#### Asset
- POST /api/v1/asset/
- GET /api/v1/asset/{Id}
- GET /api/v1/asset/{Id}/maintenance/
- GET /api/v1/asset/{Id}/workorders/
- GET /api/v1/asset/
- PUT /api/v1/asset/{Id}
- DELETE /api/v1/asset/{Id}

#### Maintenance
- POST /api/v1/maintenance/
- GET /api/v1/maintenance/{Id}
- PUT /api/v1/maintenance/{Id}
- DELETE /api/v1/maintenance/{Id}

#### Work Order
- POST /api/v1/workorder/
- GET /api/v1/workorder/{Id}
- PUT /api/v1/workorder/{Id}
- DELETE /api/v1/workorder/{Id}


## Project dependencies:
- A- Soinsoft.FleetUp.Domain.Entities | none
- B- Soinsoft.FleetUp.Domain.Contracts | none
- C- Soinsoft.FleetUp.Application.Contracts | A, B
- D- Soinsoft.FleetUp.Application.Business | A, B
- E- Soinsoft.FleetUp.Infraestructure.Persistence | A, B, C, D
- F- Soinsoft.FleetUp.Presentation.WebAPI | E, C, D	

**How to make it work:**
- >dotnet restore
- >dotnet run Soinsoft.FleetUp.Presentation.WebAPI
- Load PostMan at https://localhost:5001/api/v1/asset/
- Download and import collection for postman at <Link>

>For questions/comments: reliasro@gmail.com
Happy clean coding!! :)
