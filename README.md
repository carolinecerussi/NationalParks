# National Parks API

### By Caroline Cerussi 


A C# based API That hosts information about national parks- including their name, location, camping allowed, and park fee price. 





## Technologies Used
-C#
-.NET
-Swagger
-XML
-SQL Workbench
-Entity Framework
-MVC

## Description
This API is made up of a list of parks found across America. The returned lists are curated by : 

Name - name of the park
Location - Which part of the Country is the park in
Camping allowed - can you camp in this park 
ParkFee - What is the cost of entrance for each park 

<!-- _Both v1 and v2 are supported at this time. Some end points that can be use are:

/api/v1/Parks/all - returns all listed parks
5001/api/v1/Parks/{id} - returns a park by id
Put, Post, Delete updates may all be made by id number as well. *v2 supports filtered results. *After following the set up instructions below see swagger documentation for more information. -->

## Setup and Installation Requirements
> Initial Setup
1. Copy the git repository url: https://github.com/carolinecerussi/NationalParks
2. Open a shell program and navigate to your desktop.
3. Clone the repository for this project using the "git clone" command and including the copied url.
4. While still in the shell program, navigate to the root directory of the newly created file named "NationalParks.Solution".
5. From the root directory, navigate to the "NationalParks" directory.
6. Move onto "sql workbench" instructions  below to recreate database necessary to run this project.

> SQL Workbench Configuration
1. Create an appsettings.json file in the NationalParks directory of the project *
2. Insert the following code** : 
{
   "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=national_parks;uid=root;pwd=[YOUR-PASSWORD-HERE];"
  }
}

*note: you must include your password in the code block section labeled "YOUR-PASSWORD-HERE". 
**note: if you plan to push this cloned project to a public-facing repository, remember to add the appsettings.json file to your .gitignore before doing so.
 
3. Once appsettings.json file has been created, navigate back to SQL workbench

> To Run

Navigate to NationalParks and run : 
$ dotnet restore
$ dotnet database update 
$ dotnet run in the console

This program was built using Microsoft .NET SDK 5.0.401, and may not be compatible with other versions.

## Known Bugs 
non 


## License


Copyright (c) 08-2022 Caroline Cerussi