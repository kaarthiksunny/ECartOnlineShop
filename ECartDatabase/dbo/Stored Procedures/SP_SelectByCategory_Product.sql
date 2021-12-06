
-- =============================================
-- Author:		Admin
-- Description:	Select Product
-- =============================================
CREATE PROCEDURE [dbo].[SP_SelectByCategory_Product]
(
	@ProductId int = '',
	@ProductName nvarchar(50) = '',
	@ProductPrice money = '',
	@ProductDescription nvarchar(250) = '',
	@ProductRating nvarchar(50) = '',
	@ProductImage image = '',
	@ProductCategory nvarchar(50) = '',
	@ProductCategoryId int=''
)
AS
BEGIN
	SELECT * FROM ProductsTable
	WHERE ProductCategoryId = @ProductCategoryId
END
