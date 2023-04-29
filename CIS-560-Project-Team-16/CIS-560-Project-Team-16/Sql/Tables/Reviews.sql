--(localdb)\MSSQLLocalDb
DROP TABLE MovieDatabase.Reviews;

IF OBJECT_ID(N'MovieDatabase.Reviews') IS NULL
BEGIN
	CREATE TABLE MovieDatabase.Reviews
	(
		reviewId int IDENTITY(1,1) PRIMARY KEY,
		movieId INT --NOT NULL??????????????????????????????????????????????????????????????
			FOREIGN KEY REFERENCES MovieDatabase.Movies(movieId),
		averageIMDB NVARCHAR(128) NOT NULL,
		ratingVotes NVARCHAR(128) NOT NULL,
	);
END;

--create the relationship table for Languages

SELECT *
FROM MovieDatabase.Reviews


-- bcp CIS560Project.MovieDatabase.Reviews in "C:\Users\Isaiah\source\repos\CIS560-Project-S23\CIS-560-Project-Team-16\CIS-560-Project-Team-16\Sql\Data\MovieOutput.tsv" -S "(localdb)\MSSQLLocalDb" -T -f ReviewsFormat.fmt -h "CHECK_CONSTRAINTS" -F 2