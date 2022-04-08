# Rocket_Elevators_REST_API

.NET Core 6 Rest API

## Description
-GET: Returns all fields of all intervention Request records that do not have a start date and are in "Pending" status.
-PUT: Change the status of the intervention request to "InProgress" and add a start date and time (Timestamp).
-PUT: Change the status of the request for action to "Completed" and add an end date and time (Timestamp).



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
* Go to PostMan -> WorkSpace -> Collections -> https://superrocketelevators.azurewebsites.net + route
* See routes Below

```
sudo service mysql start
dotnet run
```

Possible routes:
* /intervention


# Version History

* 1.0.0
    * Initial Release

## Postman Collection

https://www.getpostman.com/collections/31a20fbdfbe03974d914

## CodeBoxx

Project for Week 7 of Odyssey
