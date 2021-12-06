
-- =============================================
-- Author:		Admin
-- Description:	Delete Product
-- =============================================
CREATE PROCEDURE [dbo].[SP_Delete_Product]
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
	DELETE FROM ProductsTable
	WHERE ProductId = @ProductId
END
