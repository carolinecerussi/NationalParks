# National Parks API

### By Caroline Cerussi

## Description

A C# based API That hosts information about national parks- including their name, location, camping allowed, and park fee price.

## Table of Contents

[Technologies Used](#technologies-used)  
[Description](#description)  
[Setup/Installation Requirements](#setup-and-installation-requirements)  
[Known Bugs](#known-bugs)  
[License](#License)

## Technologies Used

_C#
_.NET
\_Swagger
\_XML
\_SQL Workbench
\_Entity Framework
\_MVC

## Description

This API is made up of a list of parks found across America. The returned lists are curated by :

- \_Name - name of the park
- \_Location - Which part of the Country is the park in
- \_Camping allowed - can you camp in this park
- \_ParkFee - What is the cost of entrance for each park

Endpoints for this api, including endpoint to swagger documentation:

_* api/NationalParks - returns all listed parks and information*
__ 5001/api/NationalParks/{id} - returns a park by id_ \*_ Put, Post, Delete updates may all be made by id number as well._

After following the set up instructions below see swagger documentation for more information:\_

\*_ /swagger_

## Setup and Installation Requirements

> Initial Setup

1. Copy the git repository url: https://github.com/carolinecerussi/NationalParks
2. Open a shell program and navigate to your desktop.
3. Clone the repository for this project using the "git clone" command and including the copied url.
4. While still in the shell program, navigate to the root directory of the newly created file named "NationalParks.Solution".
5. From the root directory, navigate to the "NationalParks" directory.
6. Move onto "sql workbench" instructions below to recreate database necessary to run this project.

> SQL Workbench Configuration

1. Install MySql Workbench :
  https://dev.mysql.com/downloads/workbench/
2. Create an appsettings.json file in the NationalParks directory of the project and Insert the following code_ :
   {
   "Logging": {
   "LogLevel": {
   "Default": "Warning",
   "System": "Information",
   "Microsoft": "Information"
   }
   },
   "AllowedHosts": "_",
   "ConnectionStrings": {
   "DefaultConnection": "Server=localhost;Port=3306;database=national_parks;uid=root;pwd=[YOUR-PASSWORD-HERE];"
   }
   }
** note: you must include your password in the code block section labeled "YOUR-PASSWORD-HERE".
  *** note: if you plan to push this cloned project to a public-facing repository, remember to add the appsettings.json file to your .gitignore before doing so.

4. Once appsettings.json file has been created, navigate back to SQL workbench

> To Run

Navigate to NationalParks and run the folllowing commands in the console:
$ dotnet restore
$ dotnet database update
$ dotnet run

- _To view more information view localhost:[yourlocalhost]/index.html_

- _Additional information in JSon can also be viewed at https://localhost:[yourlocalhost]/swagger

This program was built using Microsoft .NET SDK 5.0.401, and may not be compatible with other versions.

## Known Bugs

none

## License

Copyright (c) 08-2022 Caroline Cerussi
