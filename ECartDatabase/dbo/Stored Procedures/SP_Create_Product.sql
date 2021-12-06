-- =============================================
-- Author:		Admin
-- Description:	Create New Product
-- =============================================
CREATE PROCEDURE [dbo].[SP_Create_Product]
	@ProductName nvarchar(50) = '',
	@ProductPrice money = '',
	@ProductDescription nvarchar(250) = '',
	@ProductRating nvarchar(50) = '',
	@ProductImage nvarchar(50) = '',
	@ProductCategory nvarchar(50) = '',
	@ProductCategoryId int=''
AS
BEGIN
	INSERT INTO ProductsTable (ProductName,ProductPrice,ProductDescription,ProductRating,ProductImage,ProductCategory,ProductCategoryId)
	VALUES (@ProductName,@ProductPrice,@ProductDescription,@ProductRating,@ProductImage,@ProductCategory,@ProductCategoryId)
END
