
-- =============================================
-- Author:		Admin
-- Description:	Delete Product Type
-- =============================================
CREATE PROCEDURE [dbo].[SP_Delete_ProductType]
(
	@Id int = 0,
	@ProductType nvarchar(50) = '',
	@ProductTypeImage nvarchar(50) = ''
)
AS
BEGIN
	DELETE FROM ProductTypes
	WHERE Id = @Id
END
