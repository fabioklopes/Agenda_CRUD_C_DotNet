CREATE TABLE [dbo].[people]
(
	[ContactId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(100) NOT NULL, 
    [Company] VARCHAR(100) NULL, 
    [Telephone] VARCHAR(25) NULL,
	[Email] VARCHAR(100) NULL, 
    [Client] BIT NULL, 
    [LastCall] DATETIME NULL    
)
