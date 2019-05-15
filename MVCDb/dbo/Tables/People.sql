CREATE TABLE [dbo].[People]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [BirthDate] DATE NOT NULL
)

GO

CREATE NONCLUSTERED INDEX [LastNameIndex] ON [dbo].[People] ([LastName])
