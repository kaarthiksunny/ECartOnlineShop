

-- =============================================
-- Author:		Admin
-- Description:	Update Product Type
-- =============================================
CREATE PROCEDURE [dbo].[SP_Update_ProductType]
(
	@Id int = 0,
	@ProductType nvarchar(50) = '',
	@ProductTypeImage nvarchar(50) = ''
)
AS
BEGIN
	UPDATE ProductTypes SET ProductType = @ProductType, ProductTypeImage = @ProductTypeImage
	WHERE Id = @Id
END
