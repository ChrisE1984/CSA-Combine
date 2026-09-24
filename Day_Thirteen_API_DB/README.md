### SQLite & Entity Framework Core

## What is a database?

A database is where our application permanently stores information.
This allows our information to stay saved even when our API stops.

### SQLite

SQLite is a simple database that stores all of its data in a file

Unlike SQL Server, SQLite does not require us to have a separate database server running

## Entity Framework Core

EF Core allows our C# application to communicate with a database

* Instead of writing SQL ourselves, we can work with our database using C# *

C# API -> Ef Core -> SQLite Database

## AppDbContext Class

This is the main connection between our application and our database

It tells EF Core with Models we want to store in our DB

Each DbSer inside of our AppDbContext represents a table.

## What is a Migration

A Migration is EF cores way of keeping track of changes we want to make to our DB

Whenever we create/change models we create a migration
* dotnet ef migrations add init * init stands for initialize
any migrations after the initial migration can be named anything
*dotnet ef migrations add StudentUpdate

## Updating the database

Creating a migration does not automaticall update the database
We still need to run our databse update
* dotnet ef database update *
Model-> Migration-> Database Update-> Database

## Common LINQ

FirstOrDefault() - finds the first matching record, if nothing is found it returns null

Where() - filters records based on a condition. (we would store results in a variable)

ToList() - Gets multiple records and returns them as a list

## SaveChanges

Ef Core keeps track of changes that we make to our Data

When we add, update, or remove something, those changes need to be save to the db

SaveChanges() tells the ef core: Takes the changes I made and save them to the Database

## Dependency Injections

DI allows our classes to receive the things they need instead of creating it manually