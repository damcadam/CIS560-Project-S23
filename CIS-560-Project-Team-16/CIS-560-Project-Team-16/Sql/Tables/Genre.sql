--(localdb)\MSSQLLocalDb
DROP TABLE MovieDatabase.Genre;
-- bcp CIS560Project.MovieDatabase.Directors in "C:\Users\Isaiah\source\repos\CIS560-Project-S23\CIS-560-Project-Team-16\CIS-560-Project-Team-16\Sql\Data\StaticGenres.tsv" -S "(localdb)\MSSQLLocalDb" -T -f StaticGenres.fmt -h "CHECK_CONSTRAINTS"

IF OBJECT_ID(N'MovieDatabase.Genre') IS NULL
BEGIN
    CREATE TABLE MovieDatabase.Genre
    (
        genreId INT NOT NULL,
        movieId INT NOT NULL,
        PRIMARY KEY (genreId, movieId),
        FOREIGN KEY (genreId) REFERENCES MovieDatabase.GenreValues(genreId),
        FOREIGN KEY (movieId) REFERENCES MovieDatabase.Movies(movieId)
    );
END;