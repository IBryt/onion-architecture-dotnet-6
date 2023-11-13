CREATE TABLE [dbo].[ChurchBulletinItem]
(
	[Id] [uniqueidentifier] NOT NULL PRIMARY KEY,
	[Name] [nvarchar](50) NULL,
	[Place] [nvarchar](50) NULL,
	[Date] [datetime2] NULL
)