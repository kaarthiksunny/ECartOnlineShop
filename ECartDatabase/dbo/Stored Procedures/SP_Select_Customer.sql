-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_Select_Customer]
	@UserName nvarchar(50) = '',
	@Email nvarchar(50) = '',
	@Mobile nvarchar(50) = '',
	@Password nvarchar(50) = '',
	@Address nvarchar(250) = ''
AS
BEGIN
	Select * from CustomerTable
END
