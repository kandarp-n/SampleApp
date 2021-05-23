Drop table dbo.Employee
Drop table dbo.Department

CREATE TABLE [dbo].[Department]
(
	[DeptId] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(100) NULL
)

CREATE TABLE [dbo].[Employee]
(
	[EmpId] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(100) NULL,
	[DeptId] int foreign key references Department(DeptId)
)
