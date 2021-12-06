

-- =============================================
-- Author:		Admin
-- Description:	Update Product
-- =============================================
CREATE PROCEDURE [dbo].[SP_Update_Product]
(
	@ProductId int = 0,
	@ProductName nvarchar(50) = '',
	@ProductPrice money = '',
	@ProductDescription nvarchar(250) = '',
	@ProductRating nvarchar(50) = '',
	@ProductImage nvarchar(50) = '',
	@ProductCategory nvarchar(50) = ''
)
AS
BEGIN
	UPDATE ProductsTable SET ProductName = @ProductName, ProductPrice = @ProductPrice, ProductDescription = @ProductDescription, ProductRating = @ProductRating, ProductImage = @ProductImage, ProductCategory = @ProductCategory
	WHERE ProductId = @ProductId
END
