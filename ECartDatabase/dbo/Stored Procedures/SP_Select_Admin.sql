-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE  [dbo].[SP_Select_Admin]
	@AdminName nvarchar(50) = '',
	@DOJ nvarchar(50) = '',
	@Mobile nvarchar(50) = '',
	@Address nvarchar(250) = '',
	@Password nvarchar(50) = ''
AS
BEGIN
	Select * from AdminTable
END
