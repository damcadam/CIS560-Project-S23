﻿--(localdb)\MSSQLLocalDb
DROP TABLE MovieDatabase.Movies;

IF OBJECT_ID(N'MovieDatabase.Movies') IS NULL
BEGIN
	CREATE TABLE MovieDatabase.Movies
	(
		movieId int IDENTITY(1,1) PRIMARY KEY,
		directorId INT --NOT NULL??????????????????????????????????????????????????????????????
			FOREIGN KEY REFERENCES MovieDatabase.Directors(directorId),
		[name] NVARCHAR(128) NOT NULL,
		-- length is movie length in minutes
		[length] NVARCHAR(128) NOT NULL,
		-- Release data is given as a year eg 1992
		releaseDate NVARCHAR(128) NOT NULL,
	);
END;

SELECT *
FROM MovieDatabase.Movies

-- bcp CIS560Project.MovieDatabase.Movies in "C:\Users\Isaiah\source\repos\CIS560-Project-S23\CIS-560-Project-Team-16\CIS-560-Project-Team-16\Sql\Data\MovieOutput.tsv" -S "(localdb)\MSSQLLocalDb" -T -f MoviesFormat.fmt -h "CHECK_CONSTRAINTS" -F 2
-- the end of the above command has -F 2 to start on the second row
