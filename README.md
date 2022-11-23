# TO-DO List

### Add Logger to the Application

1. Application/API:
    
    1. Remaining requests to CQRS by the schema (CreateHotel)
    2. Change response to IActionResult interface
    3. Add logging to file feature
    4. Add env flag to throw complete errors in dev env
    5. Add Background Events layer w/ notifications, etc.
2. Domain

    1. Add relationship between Booking & User & Hotel
    2. Add UserId to the CreateBookingDto
3. Infrastructure

    1. Change data annotations to FluentAPI
4. Authorization

    1. Add Registration method to AuthService
    2. Add password hashing algorithm to user creation and cred. checking
    3. Add dummy users to the database in the configuration ^^
5. Swagger

    1. Add authorization methods to Swagger :muscle: :watermelon: