-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_Delete_Customer]
	@UserId int='',
	@UserName nvarchar(50) = '',
	@Email nvarchar(50) = '',
	@Mobile nvarchar(50) = '',
	@Password nvarchar(250) = '',
	@Address nvarchar(50) = ''
AS
BEGIN
	Delete from CustomerTable Where UserId=@UserId
END
