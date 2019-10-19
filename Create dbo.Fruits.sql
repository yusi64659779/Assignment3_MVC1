USE [AgricultureDatabase]
GO

/****** Object: Table [dbo].[Fruits] Script Date: 10/19/2019 4:58:36 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Fruits] (
    [Fruit_ID]   INT           IDENTITY (1, 1) NOT NULL,
    [Product_ID] INT           NOT NULL,
    [Fruit_Name] NVARCHAR (50) NOT NULL
);

MERGE INTO Fruits AS Target 

USING (VALUES 

        (104, 1, 'Mango'), 

        (105, 1, 'Orange'), 

        (106, 1, 'Peach'),

		(107, 1, 'Pear'),

		(108, 1, 'Pineapple'),

		(109, 1, 'Watermelon'),

		(1010, 1, 'Strawberry')

) 

AS Source (Fruit_ID, Product_ID, Fruit_Name) 

ON Target.Fruit_ID = Source.Fruit_ID 

WHEN NOT MATCHED BY TARGET THEN 

INSERT (Product_ID,Fruit_Name) 

VALUES (Product_ID,Fruit_Name);
