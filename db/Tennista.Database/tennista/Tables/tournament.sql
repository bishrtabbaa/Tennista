CREATE TABLE [tennista].[tournament]
(
	[tournament_id] INT NOT NULL PRIMARY KEY,
	[name] VARCHAR(255) NOT NULL,
	[location] VARCHAR(255) NULL,
	[location_id] INT NULL,
	[surface_type] VARCHAR(255) NULL,
	[level] VARCHAR(255) NULL,
	[points] INT NULL,
	CONSTRAINT [PK_tournament] PRIMARY KEY ([tournament_id])

)