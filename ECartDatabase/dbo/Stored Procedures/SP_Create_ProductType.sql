-- =============================================
-- Author:		Admin
-- Description:	Create New Product Type
-- =============================================
CREATE PROCEDURE [dbo].[SP_Create_ProductType]
	@ProductType nvarchar(50) = '',
	@ProductTypeImage nvarchar(50) = ''
AS
BEGIN
	INSERT INTO ProductTypes (ProductType,ProductTypeImage)
	VALUES (@ProductType,@ProductTypeImage)
END
