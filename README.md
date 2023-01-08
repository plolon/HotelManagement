# TO-DO List

### Add Logger to the Application

1. Application/API:

   1. Change response to IActionResult interface
   2. Add logging to file feature
   3. Add env flag to throw complete errors in dev env
   4. Add Background Events layer w/ notifications, etc.
   5. Add validation to controllers
   6. Testing and expanding validation
   7. Change IRequest & IRequestHandlers in Queries to IQuery & IQueryHandler respectively
2. Domain

    1. Add relationship between Booking & User & Hotel
    2. Add UserId to the CreateBookingDto
3. Infrastructure

    1. Change data annotations to FluentAPI
4. Authorization

   1. Limit the returned rows from registration or return just the token :) - Add Dto :^)
   2. Add auth to all Create Update Delete commands
   3. Fix Swagger AUTH
