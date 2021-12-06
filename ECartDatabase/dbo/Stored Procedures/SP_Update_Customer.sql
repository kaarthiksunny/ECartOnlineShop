
-- =============================================
-- Author:		Sunny
-- Description:	Update Customer
-- =============================================
CREATE PROCEDURE SP_Update_Customer
(
	@UserId int = 0,
	@UserName nvarchar(50) = '',
	@Mobile nvarchar(50) = '',
	@Email nvarchar(50) = '',
	@Address nvarchar(250) = '',
	@Password nvarchar(50) = ''
)
AS
BEGIN
	UPDATE Customer SET UserName = @UserName, Mobile = @Mobile, Email = @Email, Address = @Address, Password = @Password
	WHERE UserID = @UserId
END
