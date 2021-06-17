﻿CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL IDENTITY,
	[Username] NVARCHAR(30) NOT NULL,
	[FirstName] NVARCHAR(50),
	[LastName] NVARCHAR(50),
	[Email] NVARCHAR(384) NOT NULL,
	[Password] BINARY(64) NOT NULL,
	[Salt] NVARCHAR(100) NOT NULL,
	[Picture] NVARCHAR(MAX),
	[Location] NVARCHAR(50),
	[Bio] NVARCHAR(4000),
	[RegistrationDate] DATETIME2 NOT NULL DEFAULT (SYSDATETIME()),
	[IsActive] BIT NOT NULL DEFAULT 1,
	[RoleId] INT NOT NULL DEFAULT 3,

	CONSTRAINT [PK_User] PRIMARY KEY ([Id]),
	CONSTRAINT [FK_User_UserRole_RoleId] FOREIGN KEY ([RoleId])
		REFERENCES [dbo].[UserRole]([Id]),
	CONSTRAINT [UK_User_Username] UNIQUE ([Username]),
	CONSTRAINT [UK_User_Email] UNIQUE ([Email])
);