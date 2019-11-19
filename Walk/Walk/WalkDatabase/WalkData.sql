﻿CREATE TABLE [dbo].[WalkData]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
	[Dato] DATETIME NOT NULL, 
    [Fornavn] TEXT NOT NULL, 
    [Efternavn] TEXT NOT NULL, 
    [Skridt] FLOAT NOT NULL DEFAULT 0, 
    [Km] FLOAT NOT NULL DEFAULT 0, 
    [Minutter] FLOAT NOT NULL DEFAULT 0, 
    [Kalorier] FLOAT NOT NULL DEFAULT 0
)
