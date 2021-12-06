
CREATE PROCEDURE [dbo].[SP_SelectById_ProductType]
(
	@Id int = '',
	@ProductType nvarchar(50) = '',
	@ProductTypeImage nvarchar(50) = ''
)
AS
BEGIN
	SELECT * FROM ProductTypes
	WHERE Id = @Id
END
