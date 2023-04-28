--(localdb)\MSSQLLocalDb
--DROP TABLE MovieDatabase.Genre;

CREATE TABLE MovieDatabase.Genre
(
	genreId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	movieId INT NOT NULL FOREIGN KEY REFERENCES MovieDatabase.Movies(movieId)
);

--SELECT *
--FROM MovieDatabase.Genre

-- bcp CIS560Project.MovieDatabase.Directors in "C:\Users\Isaiah\source\repos\CIS560-Project-S23\CIS-560-Project-Team-16\CIS-560-Project-Team-16\Sql\Data\StaticGenres.tsv" -S "(localdb)\MSSQLLocalDb" -T -f StaticGenres.fmt -h "CHECK_CONSTRAINTS"