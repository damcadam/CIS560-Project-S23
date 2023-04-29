--(localdb)\MSSQLLocalDb
DROP TABLE MovieDatabase.GenreValues;

IF OBJECT_ID(N'MovieDatabase.GenreValues') IS NULL
BEGIN
	CREATE TABLE MovieDatabase.GenreValues
	(
		genreId int IDENTITY(1,1) PRIMARY KEY,
		genreName NVARCHAR(128)  NOT NULL
	);
END;

SELECT *
FROM MovieDatabase.GenreValues

-- bcp CIS560Project.MovieDatabase.GenreValues in "C:\Users\Isaiah\source\repos\CIS560-Project-S23\CIS-560-Project-Team-16\CIS-560-Project-Team-16\Sql\Data\StaticGenres.tsv" -S "(localdb)\MSSQLLocalDb" -T -f StaticGenresFormat.fmt -h "CHECK_CONSTRAINTS"
