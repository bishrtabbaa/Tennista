CREATE TABLE [tennista].[player]
(
	[player_id] INT NOT NULL PRIMARY KEY,
	[name] VARCHAR(255) NOT NULL,
	[place_of_birth] VARCHAR(255) NULL,
	[place_of_birth_location_id] INT NULL,
	[date_of_birth] DATETIME NULL,
	[preferred_hand_type] VARCHAR(255) NULL,
	[backhand_type] VARCHAR(255) NULL,
	[height] FLOAT NULL,
	[weight] FLOAT NULL,
    CONSTRAINT [PK_player] PRIMARY KEY ([player_id])

)
