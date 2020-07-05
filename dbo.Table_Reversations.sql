CREATE TABLE [dbo].[Reversations]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Invoice No] INT NOT NULL, 
    [Room Type ] NCHAR(300) NOT NULL, 
    [Room number ] NCHAR(300) NOT NULL, 
    [Date In ] DATE NOT NULL, 
    [Date out ] DATE NOT NULL
)
