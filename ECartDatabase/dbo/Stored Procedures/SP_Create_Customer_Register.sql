-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_Create_Customer_Register]
	@UserName nvarchar(50) = '',
	@Email nvarchar(50) = '',
	@Mobile nvarchar(50) = '',
	@Password nvarchar(250) = '',
	@Address nvarchar(50) = ''
AS
BEGIN
	INSERT INTO CustomerTable (UserName,Email,Mobile,Password,Address)
	VALUES (@UserName,@Email,@Mobile,HASHBYTES('SHAI','@Password'),@Address)
END
