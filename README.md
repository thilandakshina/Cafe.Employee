## Backend Solution 
1. Navigate to the Project Directory -> CafeManagement
2. Open CafeManagement.sln using visual studio
3. Set Cafe.API as starup project.

CafeManagement System

Architecture Overview -- The solution follows Clean Architecture principles, organized into distinct layers:

-> Core Layers 

- Cafe.Domain: Contains business entities and models
- Cafe.Application: Houses business logic, behaviors, and CQRS implementations

  - Commands and Queries
  - Command/Query Handlers
  - Validators
  - DTOs
  - Interfaces

-> Infrastructure Layer

- Cafe.Infrastructure: Handles data persistence and external concerns

  - SQLite Database implementation
  - Entity Configurations
  - Repositories
  - Unit of Work pattern

-> Presentation Layer

- Cafe.API: Web API endpoints and configurations

  - Controllers
  - Middleware
  - API Response handling

-> Technology Stack

  - .NET Core
  - SQLite
  - MediatR
  - NUnit
  - Moq
  - Autofac
  - FluentValidation (implied by validators)

  ![image](https://github.com/user-attachments/assets/dd030f15-cbc1-436d-910b-3e544842a573)


## Frontend Solution
1. Navigate to the Project Directory -> cafe-employee-manager
2. Open the folder using vs code
3. In the terminal write npm start

![image](https://github.com/user-attachments/assets/afc889e0-efb7-48e7-b1fd-b92cd061da07)


![image](https://github.com/user-attachments/assets/bd203991-2edd-49a8-ba60-606ac3cad463)

![image](https://github.com/user-attachments/assets/9b637557-cbab-4b34-8e4a-59feeda2a3a6)

![image](https://github.com/user-attachments/assets/6ef82593-49c6-470b-8f34-05ea72f2520c)

![image](https://github.com/user-attachments/assets/b4c4a414-f920-477d-9a1d-a0ea5af51164)

![image](https://github.com/user-attachments/assets/3522efc1-a420-4900-8fbf-a00d0a22fa3e)


Make sure FE runs http://localhost:3000/ and BE runs https://localhost:5002/
if any changes please update the program.cs under Cafe.API project and src-> api -> config.js under FE project