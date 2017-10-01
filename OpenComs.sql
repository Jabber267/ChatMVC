CREATE DATABASE OpenComs;
GO

USE OpenComs;
GO

CREATE TABLE [OpenComs].[dbo].[MessageBoard]
(
	[RID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Username] [varchar](100) NOT NULL,
	[Message] [varchar](max) NOT NULL,
	[DateTimeOfMessage] [datetime] NOT NULL
)
GO