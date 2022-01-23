# CASE
You work in a new company that wants to provide HR services to external partners. The services will be provided through an API layer, which the external partners can use from their own software solutions.
The company is asking you to develop an API around basic employee management.

# Business Requirements
The API should provide the following functionality to the external partners:
-	Create employee
-	Update employee
-	Show list of employees with the possibility of searching (e.g., by field)

The Employee entity should consist of the following fields:
- Id	                  (Number)
- First Name	          (String)
- Last Name	            (String)
- Email	                (String)
- Date of Birth	        (Date)
- Currently Employed	  (Boolean)

# Technical Requirements
To fit into the company’s technology vision, the API should be developed using the following technologies:
-	ASP.Net Core 5 or 6
-	A relational database of your choice (PostgreS, Oracle, MySQL, SQL Server, etc.)

The API should be developed as either REST, OData or GraphQL. Other request and response formats are left to the developer to decide.
The API must be protected using an authentication mechanism.

# Exercise
Develop the new HR functionality while staying inside the technical requirements as much as possible. If there are areas where you have no previous experience, please find alternative solutions. 

You will likely use an ORM to handle the database communication, but please be ready to discuss the underlying SQL as well.

Think about how the system would be hosted.

In the interview you will be asked to present the developed prototype, and the following discussion will be based on the proposed solution.
