CREATE PROCEDURE [tennista].[ImportPlayers]
AS
	INSERT INTO tennista.player ([name],[preferred_hand_type],[date_of_birth],[place_of_birth])
	SELECT DISTINCT p.first_name + ' ' + p.last_name, p.preferred_hand_type, CONVERT(DATETIME, p.date_of_birth, 112), p.place_of_birth
	FROM [import].atp_player p
	WHERE NOT EXISTS (SELECT * FROM [tennista].player p2 WHERE p2.name = p.first_name + ' ' + p.last_name);
RETURN 0
