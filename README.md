# Table Reservation System

##Cleanup script for database:

DELETE FROM [db_a6e02b_trs].[dbo].[__EFMigrationsHistory]

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Medias]') AND type in (N'U'))
DROP TABLE [dbo].[Medias]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Reservations]') AND type in (N'U'))
DROP TABLE [dbo].[Reservations]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RestaurantUser]') AND type in (N'U'))
DROP TABLE [dbo].[RestaurantUser]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Restaurants]') AND type in (N'U'))
DROP TABLE [dbo].[Restaurants]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Users]') AND type in (N'U'))
DROP TABLE [dbo].[Users]
GO
