CREATE TABLE [tennista].[match]
(
	[tournament_id] INT NOT NULL,
	[tournament_date] DATETIME NOT NULL,
	[round] INT NOT NULL,
	[winner_player_id] INT NOT NULL,
	[loser_player_id] INT NOT NULL,
	[score] VARCHAR(255) NOT NULL, 
    CONSTRAINT [PK_match] PRIMARY KEY ([tournament_id],[tournament_date],[winner_player_id],[loser_player_id])
)
