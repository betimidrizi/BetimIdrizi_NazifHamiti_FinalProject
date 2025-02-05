# BetimIdrizi_NazifHamiti_FinalProject

Book Review Platform
A web-based platform built using C# .NET MVC where users can view, review, like, and dislike books. Admins can manage the book catalog and perform CRUD operations. This platform allows users to engage with books by submitting their reviews and rating them.

Features

User Features:
View a list of books.
Read detailed information about each book.
Like or dislike books.
Submit reviews for books.
User authentication and account management.


Admin Features:
Add, edit, and delete books.
Manage users and their reviews.
View all reviews and ratings for books.


Technologies Used
Backend: C# .NET MVC
Frontend: HTML, CSS, JavaScript
Database: SQL Server
Authentication: ASP.NET Identity


Getting Started
Prerequisites
.NET 8.0 SDK or higher
SQL Server


Installation
Clone the repository:

bash
Copy
Edit
git clone [https://github.com/your-username/book-review-platform.git](https://github.com/betimidrizi/BetimIdrizi_NazifHamiti_FinalProject.git)
Open the solution in Visual Studio.

Restore the required NuGet packages:

bash
Copy
Edit
dotnet restore
Set up the database:

Update your appsettings.json with the correct connection string.
Apply migrations:
bash
Copy
Edit
dotnet ef database update
Run the application:

bash
Copy
Edit
dotnet run
Navigate to http://localhost:5000 to access the platform.

Usage
Admin Account:
Use the admin credentials to manage books and users.
User Account:
Register for a user account to like, dislike, and review books.
