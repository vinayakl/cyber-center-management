if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Assign]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Assign]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Bill]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Bill]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Blacklist]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Blacklist]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CustomerInfo]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CustomerInfo]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Daily]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Daily]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[History]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[History]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[UserLogin]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[UserLogin]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[computer]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[computer]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[login]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[login]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[rates]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[rates]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[sysdiagrams]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[sysdiagrams]
GO

CREATE TABLE [dbo].[Assign] (
	[ComputerName] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[CustomerID] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[BrowseStartTime] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[BrowseEndTime] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TotalTime] [int] NULL ,
	[TotalAmount] [numeric](18, 2) NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Bill] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[ComputerName] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[CustomerID] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[FromHours] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[ToHours] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TotalTime] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[TotalAmount] [numeric](18, 2) NULL ,
	[BrowseDate] [smalldatetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Blacklist] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[Website] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Description] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[CustomerInfo] (
	[CustomerID] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[Fname] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Mname] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Lname] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[address] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[mobile] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[email] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[gender] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[idproof] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[pass] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Daily] (
	[customerId] [int] NOT NULL ,
	[VisitTime] [smalldatetime] NULL ,
	[AccessTime] [smalldatetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[History] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[UserName] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[URL] [varchar] (500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[VisitTime] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[VisitDate] [smalldatetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[UserLogin] (
	[Uname] [nvarchar] (255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[Password] [nvarchar] (255) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[computer] (
	[systemname] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[machinename] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[cpu] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[memory] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[monitorsize] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[os] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[username] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[status] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[login] (
	[uname] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[pass] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[rates] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[Category] [varchar] (500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,
	[rate] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[sysdiagrams] (
	[name] [ntext] COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL ,
	[principal_id] [int] NOT NULL ,
	[diagram_id] [int] NOT NULL ,
	[version] [int] NULL ,
	[definition] [image] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

