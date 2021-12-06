

-- =============================================
-- Author:		Admin
-- Description:	Select Product
-- =============================================
CREATE PROCEDURE [dbo].[SP_Select_Product]
	@ProductName nvarchar(50) = '',
	@ProductPrice money = '',
	@ProductDescription nvarchar(250) = '',
	@ProductRating nvarchar(50) = '',
	@ProductImage nvarchar(50) = '',
	@ProductCategory nvarchar(50) = ''
AS
BEGIN
	SELECT * FROM ProductsTable
END
