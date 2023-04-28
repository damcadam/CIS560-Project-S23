CREATE TABLE MovieDatabase.Movies
(
	movieId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	directorId INT NOT NULL
		FOREIGN KEY REFERENCES MovieDatabase.Directors(directorId),
	watchListId INT NOT NULL
		FOREIGN KEY REFERENCES MovieDatabase.WatchList(watchListId),
	actorId INT NOT NULL,
	[language] NVARCHAR(128) NOT NULL,
	[name] NVARCHAR(128) NOT NULL,
	-- length is movie length in minutes
	[length] INT NOT NULL,
	-- Release data is given as a year eg 1992
	releaseDate YEAR NOT NULL,
);