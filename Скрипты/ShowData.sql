CREATE PROCEDURE [dbo].[ShowData]
AS
	
	SELECT * FROM categories
	ORDER BY parent, name