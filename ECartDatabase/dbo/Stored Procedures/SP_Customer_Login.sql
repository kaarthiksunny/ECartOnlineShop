-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_Customer_Login]
	@UserName varchar(50)='',
	@Password varchar(50)='',
	@IsValid bit out
AS
BEGIN
	Set @IsValid = (Select COUNT(@UserName) from CustomerTable 
	WHERE UserName=@UserName AND Password=@Password)
END