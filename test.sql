CREATE DATABASE local;

USE local;

CREATE TABLE
    Employees (
        EmployeeID INT PRIMARY KEY, -- Auto-incrementing primary key
        FirstName NVARCHAR (50) NOT NULL, -- First name, cannot be null
        LastName NVARCHAR (50) NOT NULL, -- Last name, cannot be null
        BirthDate DATE, -- Birth date
        Email NVARCHAR (100) -- Email
    );