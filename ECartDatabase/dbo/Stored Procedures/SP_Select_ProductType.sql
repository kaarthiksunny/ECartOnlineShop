



-- =============================================
-- Author:		Admin
-- Description:	Select Product Tye
-- =============================================
CREATE PROCEDURE [dbo].[SP_Select_ProductType]
	@ProductType nvarchar(50) = '',
	@ProductTypeImage nvarchar(50) = ''
AS
BEGIN
	SELECT * FROM ProductTypes
END
