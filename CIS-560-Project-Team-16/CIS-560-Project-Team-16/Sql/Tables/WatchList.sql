CREATE TABLE MovieDatabase.WatchList
(
	watchListId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	FOREIGN KEY (movieId) REFERENCES MovieDatabase.Movies(movieId)
);