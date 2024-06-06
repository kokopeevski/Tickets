use master 
go

CREATE DATABASE Tickets
GO

USE [Tickets]
GO

CREATE TABLE [dbo].[Flights](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FlightNumber] [int] NOT NULL,
	[Destination] [nvarchar](50) NOT NULL,
	[Price] [real] NOT NULL,
 CONSTRAINT [PK_Flights] PRIMARY KEY CLUSTERED (Id)
)
GO
SET IDENTITY_INSERT [dbo].[Flights] ON 

INSERT [dbo].[Flights] ([Id], [FlightNumber], [Destination], [Price]) VALUES (1, 256, N'New York', 1258)
INSERT [dbo].[Flights] ([Id], [FlightNumber], [Destination], [Price]) VALUES (2, 187, N'Paris', 414)
INSERT [dbo].[Flights] ([Id], [FlightNumber], [Destination], [Price]) VALUES (3, 210, N'London', 212)
INSERT [dbo].[Flights] ([Id], [FlightNumber], [Destination], [Price]) VALUES (4, 187, N'Manchester', 430)
INSERT [dbo].[Flights] ([Id], [FlightNumber], [Destination], [Price]) VALUES (5, 187, N'Los Angeles', 1934)
INSERT [dbo].[Flights] ([Id], [FlightNumber], [Destination], [Price]) VALUES (6, 210, N'Edinburgh', 442)
INSERT [dbo].[Flights] ([Id], [FlightNumber], [Destination], [Price]) VALUES (7, 256, N'Chicago', 1490)
INSERT [dbo].[Flights] ([Id], [FlightNumber], [Destination], [Price]) VALUES (8, 189, N'Houston', 1658)
INSERT [dbo].[Flights] ([Id], [FlightNumber], [Destination], [Price]) VALUES (9, 190, N'Vienna', 396)
INSERT [dbo].[Flights] ([Id], [FlightNumber], [Destination], [Price]) VALUES (10, 192, N'Salsburg', 624)
INSERT [dbo].[Flights] ([Id], [FlightNumber], [Destination], [Price]) VALUES (11, 190, N'Innsbruck', 782)
INSERT [dbo].[Flights] ([Id], [FlightNumber], [Destination], [Price]) VALUES (12, 212, N'Glasgow', 352)
INSERT [dbo].[Flights] ([Id], [FlightNumber], [Destination], [Price]) VALUES (13, 256, N'Philadelphia', 1904)
INSERT [dbo].[Flights] ([Id], [FlightNumber], [Destination], [Price]) VALUES (14, 205, N'Istanbul', 468)
SET IDENTITY_INSERT [dbo].[Flights] OFF
