# Oreo

To run this proyect you must change the routes on the next files:

ProyectConnection.cs / Line 15  ---------> Route of new Database
UtilityMenu.cs / Line 49  ---------> Route of .txt file to save Product Catalog
ShopCtrl.cs / Line 31, 52, 79 -------> Route of txt file to save Shopping Cart Elements


-----------------------------------------------------------------------------------
Script for Database:

CREATE TABLE [dbo].[Employee] (
    [Document] VARCHAR (50) NOT NULL,
    [Name]     VARCHAR (50) NOT NULL,
    [Address]  VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Document] ASC)
);

CREATE TABLE [dbo].[Order] (
    [Id]             INT          NOT NULL,
    [ClientDocument] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Product] (
    [Id]          INT          NOT NULL,
    [Name]        VARCHAR (50) NOT NULL,
    [Category]    VARCHAR (50) NOT NULL,
    [Price]       INT          NOT NULL,
    [Description] VARCHAR (50) NOT NULL,
    [Quantity]    INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
