-- =============================================
-- Author:		Sunny
-- Description:	Create New Customer
-- =============================================
CREATE PROCEDURE SP_CreateNewCustomer
	@UserName nvarchar(50) = '',
	@Mobile nvarchar(50) = '',
	@Email nvarchar(50) = '',
	@Address nvarchar(250) = '',
	@Password nvarchar(50) = ''
AS
BEGIN
	INSERT INTO Customer (UserName,Mobile,Email,Address,Password)
	VALUES (@UserName,@Mobile,@Email,@Address,@Password)
END
