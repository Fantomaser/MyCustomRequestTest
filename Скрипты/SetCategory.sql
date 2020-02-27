CREATE PROCEDURE [dbo].[SetCategory]
@newcid int,
@newname nvarchar(max),
@newparent int,
@newimage nvarchar(max)
AS
IF @newcid NOT IN (SELECT Id FROM dbo.categories) AND 
		(@newname NOT IN (SELECT name FROM dbo.categories) OR @newparent NOT IN (SELECT parent FROM dbo.categories) OR @newimage NOT IN (SELECT image FROM dbo.categories))
INSERT categories(Id, name, parent, image) VALUES(@newcid, @newname, @newparent, @newimage)