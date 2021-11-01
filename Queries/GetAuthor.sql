USE [aspnet-Game_Hub-70EDBC99-917B-4751-8DFD-8C25E435BA2E]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[SelectGames]

SELECT	@return_value as 'Return Value'

GO
