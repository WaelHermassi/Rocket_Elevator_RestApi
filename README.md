# Rocket_Elevators_REST_API


## Description

- Retrieving the current status of a specific Battery
- Changing the status of a specific Battery
- Retrieving the current status of a specific Column
- Changing the status of a specific Column
- Retrieving the current status of a specific Elevator
- Changing the status of a specific Elevator
- Retrieving a list of Elevators that are not in operation at the time of the request
- Retrieving a list of Buildings that contain at least one battery, column or elevator requiring intervention
- Retrieving a list of Leads created in the last 30 days who have not yet become customers.


## Getting Started

### Dependencies

Visual Studio Code

* Nugget packages
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.InMemory
Microsoft.VisualStudio.Web.CodeGeneration.Design
Pomelo.EntityFrameworkCore.MySql
Swashbuckle.AspNetCore

global dotnet-ef - version 6.0.3 -> dotnet tool install --global dotnet-ef --version 6.0.3

Postman (App or Browser)

A MySQL Database

### Executing program

* How to run the program
* Start your MySQL
* run dotnet in correct directory
* Go to PostMan -> WorkSpace -> Collections -> url + route
* See routes Below

```
sudo service mysql start
dotnet run
```

Possible routes:
* /building
* /building/intervention
* /lead
* /lead/email
* /elevator
* /elevator/invalid
* /battery
* /column

## Authors

Contributors names and contact info

Brian Nieckarz
https://github.com/BrianNieckarz

Marc-Andre Ramirez
https://github.com/dremangry

Felicia Hartono
https://github.com/dremangry/Rocket_Elevators_API/commits?author=coder02603

David Pelletier
https://github.com/TheNobleTruth

WaelHermassi
https://github.com/WaelHermassi

## Version History

* 1.0.0
    * Initial Release

## CodeBoxx

Project for Week 7 of Odyssey
