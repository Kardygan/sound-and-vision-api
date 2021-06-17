﻿CREATE TABLE [dbo].[UserRole]
(
	[Id] INT NOT NULL IDENTITY,
	[Name] NVARCHAR(50),

	CONSTRAINT [PK_UserRole] PRIMARY KEY ([Id]),
	CONSTRAINT [UK_UserRole_Name] UNIQUE ([Name])
);