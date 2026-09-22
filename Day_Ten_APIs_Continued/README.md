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

## Status Codes

200 Status Code your request is good -- Success

400 Status Code mean a bad request- something was wrong with your request

