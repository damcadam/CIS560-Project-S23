-- Relationship table will have multiple FKs
CREATE TABLE MovieDatabase.MovieCast
(
	actorId INT NOT NULL PRIMARY KEY 
		FOREIGN KEY REFERENCES MovieDatabase.Movies(actorId),
	movieId INT NOT NULL PRIMARY KEY 
		FOREIGN KEY REFERENCES MovieDatabase.Movies(movieId),
);