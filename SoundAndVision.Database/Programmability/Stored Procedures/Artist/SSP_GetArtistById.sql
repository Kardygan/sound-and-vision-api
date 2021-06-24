CREATE PROCEDURE [dbo].[SSP_GetArtistById]
	@Id INT
AS
BEGIN
	SELECT * FROM [dbo].[Artist] WHERE [Id] = @Id;
END;