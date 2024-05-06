# Project_1

## Building Lot Management System

### As a builder, I need a system that will store pertinent details related to our building lots inventory and related customers.


The system must provide:
- 
- Relational storage database for:
 
    - Lot records

    - Customer details
- Ability to create, retrieve, update, and delete records in the database using a console user interface (UI).
- Ability to search the database from the console UI.
- Each record should have a unique identifier.
- Ability to relate the records by their unique identifiers.
- Access to the system requires a valid user name and password
- Error Handling
- Input validation

Nice to have features:
-
- Ability to add 'Notes' to a record with a related Date/Time stamp
- Error logging
- Ability to assign roles to a user: Admin, User, Read-only

Lot Record Requirements
- 
- Lot Number - Unique Key
- Location Information
    - Address   
    - Neighborhood  
- Lot Size 
    - acres     
    - feet
- Description of property
    - options like "wooded", "cleared", "corner", "hillside"
- Acquired Price 
- Acquired Date (YYYY/MM/DD)
- Listed Price
- Listed Date (YYYY/MM/DD)
- Sold Price
- Sold Date (YYYY/MM/DD)
- Status: Available, Hold, Pending Sale, Sold
- Status Date (YYYY/MM/DD)


Customer Detail Requirements
-
- Customer ID - Unique Key
- Name - First, Last
- Address
- Phone Number  
- Email
- Related Lot Number 
    - allow for multiples
- Related Customer ID
    - allow for multiples
- Status: Interest, No Interest, Holding Lot(s), Purchased Lot(s)
- Statue Date (YYYY/MM/DD)


## Diagram

INPUT:  
- User --> UI --> Validation Layer --> Database | Lots <--> Customer 

OUTPUT: 
- Retrieve from Database | Lot <--> Customer 
- Return to UI  
