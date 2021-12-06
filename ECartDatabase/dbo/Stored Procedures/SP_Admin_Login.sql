-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_Admin_Login]
	@AdminName varchar(50)='',
	@Password varchar(50)='',
	@IsValid bit out
AS
BEGIN
	Set @IsValid = (Select COUNT(AdminName) from AdminTable 
	WHERE AdminName=@AdminName AND Password=@Password)
END
