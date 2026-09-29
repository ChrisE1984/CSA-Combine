### N-Tier APi

-Tier means layer, and N means numbers. and N-Tier API splits the work into different layers that each do one job and only talks to the layer next to them

Controller (Presentation) -> Services (Business) -> Repository (Data Access) -> Database

## Controller

- Speaks HTTP, takes the request, asks the Service, and picks the status code (only sees services layer)

## Services

- Holds the rules (Business Logic) (only sees Repository)

## Repository

- Stores and fetches Data (Get, Add, Update, Delete) - the only class that uses AppDbContext (only sees Database)