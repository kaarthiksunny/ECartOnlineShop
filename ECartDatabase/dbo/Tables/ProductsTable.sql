CREATE TABLE [dbo].[ProductsTable] (
    [ProductId]          INT            IDENTITY (1, 1) NOT NULL,
    [ProductName]        NVARCHAR (50)  NULL,
    [ProductPrice]       DECIMAL (18)   NULL,
    [ProductDescription] NVARCHAR (250) NULL,
    [ProductRating]      NVARCHAR (50)  NULL,
    [ProductImage]       NVARCHAR (50)  NULL,
    [IsAvailable]        BIT            NULL,
    [ProductCategory]    NVARCHAR (50)  NULL,
    [ProductCategoryId]  INT            NULL
);

