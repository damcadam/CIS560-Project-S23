CREATE TABLE MovieDatabase.Genre
(
	genreId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	movieId INT NOT NULL FOREIGN KEY REFERENCES MovieDatabase.Movies(movieId)
);