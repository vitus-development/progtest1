CREATE TABLE [dbo].[BrugerData]
(
	[Pk_Bruger_ID] INT NOT NULL PRIMARY KEY IDENTITY(10000, 1), 
    [Fornavn] TEXT NULL, 
    [Efternavn] TEXT NULL, 
    [Fødselsdag] DATETIME NULL
)
