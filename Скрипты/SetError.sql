CREATE PROCEDURE [dbo].[SetError]
@newcode int,
@newtext nvarchar(max)
AS
IF @newcode NOT IN (SELECT Id FROM dbo.ErrorCodes) AND @newtext NOT IN (SELECT infotext FROM dbo.ErrorCodes)
INSERT ErrorCodes(Id, infotext) VALUES(@newcode, @newtext)