CREATE TABLE [dbo].[ProductTypes] (
    [Id]               INT           IDENTITY (1, 1) NOT NULL,
    [ProductType]      NVARCHAR (50) NULL,
    [ProductTypeImage] NVARCHAR (50) NULL,
    CONSTRAINT [PK_ProductTypes] PRIMARY KEY CLUSTERED ([Id] ASC)
);

