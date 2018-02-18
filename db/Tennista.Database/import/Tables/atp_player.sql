CREATE TABLE [import].[atp_player]
(
	[player_id] INT NOT NULL PRIMARY KEY,
	[first_name] VARCHAR(255) NOT NULL,
	[last_name] VARCHAR(255) NOT NULL, 
	[preferred_hand_type] VARCHAR(255) NOT NULL,
	[date_of_birth] VARCHAR(255) NOT NULL,
	[place_of_birth] VARCHAR(255) NOT NULL
)
