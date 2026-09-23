# Intro to API's, .NET, & Status codes, HTTP Request Methods

What does API stand for?

## Application Program Interface

** API allows different applications to communicate with each other **

** Front-> Send data to API -> Data -> Back to API -> back to front end.

## .NET is Microsoft's Development Platform

** Dotnet lets us create Applications from Console Projects to Web API to Frontend Website **

## What is an Endpoint/ Route

An endpoint is a specified location where we send our requests to (i.e. Localhost5000/user/api/login)

## What is a Controller

Controllers hold our Endpoints and allows applications to send requests to them.

** Request -> Controller -> C# logic -> request/response is sent back **

## CRUD Create, Read, Update & Delete

### Read Method [HttpGet]

Retrieves data from our API/ Database.

### Create Method [HttpPost]

Used to *create new Data* (ex creating a new account)

### Update [HttpPut]

Used to *Update existing Data*

### Delete[HttpDelete]

Used to *Delete existing Data*

//-------------------------------------------------//

# Status Codes

## 200 Status Code 

Your request is good -- Success
(Ok)

## 201 Status Code

This means creation was successful!
(used for CreateAtAction)

## 204 Status Code

States the request was successful with nothing to return

## 400 Status Code 

Means a bad request- something was wrong with your request

## 404 Status code

Not Found means whatever user expected it was not there
(NotFound)

//-----------------------------------------------//

## Day Three Services, Interfaces, & Dependency Injection

# Controller is our waiter - Takes orders (Requests Methods)

# Interface is our Menu - tells us what our kitchen has 

# Services is our Kitchen - Makes the food (Implements our logic)

# Dependency Injection is our Manager - makes sure everything runs smoothly (Connects everything)

### Services

This Layer of our application is where our logic resides (We access our database from this layer only)

### Interfaces

This is a contract or list of promises that our Services MUST implement (there is no logic here)

### Dependency Injection

We Inject our Services int the Controller using our Constructor
We must ad out Services and Interface to our program.cs
When we implement our Interface it will pass on the responsibility to our Services