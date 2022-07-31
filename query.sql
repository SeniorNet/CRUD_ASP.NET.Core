CREATE TABLE [dbo].[Employee] (
    [EmployeeId]   INT           NOT NULL,
    [EmployeeName] NVARCHAR (50) NULL,
    [ImageUser]    NVARCHAR (50) NULL,
    [BirthDate]    DATE          NULL,
    [Salary]       FLOAT          NULL,
    [HiringDate]   DATE          NULL,
    [NationalId]   NVARCHAR (50) NULL,
    CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED ([EmployeeId] ASC)
);
