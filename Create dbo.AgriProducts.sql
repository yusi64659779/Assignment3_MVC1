USE [AgricultureDatabase]
GO

/****** Object: Table [dbo].[AgriProducts] Script Date: 10/19/2019 4:44:52 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AgriProducts] (
    [Product_ID]   INT           IDENTITY (1, 1) NOT NULL,
    [Product_Name] NVARCHAR (50) NOT NULL
);

MERGE INTO AgriProducts AS Target 

USING (VALUES 

        (1, 'Fruits'), 

        (2, 'Vegetable') 

        

) 

AS Source (Product_ID,Product_Name) 

ON Target.Product_ID = Source.Product_ID 

WHEN NOT MATCHED BY TARGET THEN 

INSERT (Product_Name) 

VALUES (Product_Name);


