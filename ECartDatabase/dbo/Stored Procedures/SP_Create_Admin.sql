-- =============================================
-- Author:		Sunny
-- Description:	Create New Admin
-- =============================================
CREATE PROCEDURE [dbo].[SP_Create_Admin]
	@AdminName nvarchar(50) = '',
	@DOJ nvarchar(50) = '',
	@Mobile nvarchar(50) = '',
	@Address nvarchar(250) = '',
	@Password nvarchar(50) = ''
AS
BEGIN
	INSERT INTO AdminTable (AdminName,DOJ,Mobile,Address,Password)
	VALUES (@AdminName,@DOJ,@Mobile,@Address,HASHBYTES('SHAI','@Password'))
END
