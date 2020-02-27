CREATE PROCEDURE [dbo].[SetError]
	@Ncode int,
	@Ntext nvarchar(200)
AS
		IF @Ncode NOT IN (SELECT code FROM ErrorCodes) AND  @Ntext NOT IN (SELECT text FROM ErrorCodes) 
		INSERT ErrorCodes(Id, text) VALUES(@Ncode, @Ntext)
GO
