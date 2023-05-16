CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Usuario] NCHAR(15) NOT NULL, 
    [Email] NCHAR(30) NOT NULL, 
    [Senha] NCHAR(15) NOT NULL, 
    [Games] INT NULL
)
