USE [AgricultureDatabase]
GO

/****** Object: Table [dbo].[Vegetables] Script Date: 10/19/2019 4:52:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Vegetables] (
    [Veg_ID]     INT           IDENTITY (1, 1) NOT NULL,
    [Product_ID] INT           NOT NULL,
    [Veg_Name]   NVARCHAR (50) NOT NULL
);

MERGE INTO Vegetables AS Target 

USING (VALUES 

        (2001, 2, 'Potato'), 

        (2002, 2, 'Tomato'), 

        (2003, 2, 'Mushroom'),

		(2004, 2, 'Black bean'),

		(2005, 2, 'Broccoli'),

		(2006, 2, 'Cabbage'),

		(2007, 2, 'Carrot'),

		(2008, 2, 'Sweet corn'),

		(2009, 2, 'Green pepper'),

		(2010, 2, 'Onion')
) 

AS Source (Veg_ID, Product_ID, Veg_Name) 

ON Target.Veg_ID = Source.Veg_ID 

WHEN NOT MATCHED BY TARGET THEN 

INSERT (Product_ID, Veg_Name) 

VALUES (Product_ID, Veg_Name);
