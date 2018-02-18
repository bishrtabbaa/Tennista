CREATE TABLE [tennista].[location]
(
	[location_id] INT NOT NULL PRIMARY KEY,
	[name] VARCHAR(255) NOT NULL,
	[state_province] VARCHAR(255) NULL,
	[country] VARCHAR(255) NULL,
	[region] VARCHAR(255) NULL
)
