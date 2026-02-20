-- Create Database
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'AppointmentDB')
BEGIN
    CREATE DATABASE AppointmentDB;
END
GO

USE AppointmentDB;
GO

-- Create Student Table
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'STUDENT')
BEGIN
    CREATE TABLE STUDENT (
        id NVARCHAR(50) PRIMARY KEY,
        name NVARCHAR(100) NOT NULL,
        address NVARCHAR(200),
        dob DATE
    );
END
GO
