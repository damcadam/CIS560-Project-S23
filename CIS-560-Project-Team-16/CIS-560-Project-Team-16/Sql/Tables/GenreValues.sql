CREATE TABLE MovieDatabase.GenreValues
(
	genreTitle NVARCHAR(128) NOT NULL PRIMARY KEY,
	genreId INT NOT NULL FOREIGN KEY REFERENCES MovieDatabase.Genre(genreId)
);