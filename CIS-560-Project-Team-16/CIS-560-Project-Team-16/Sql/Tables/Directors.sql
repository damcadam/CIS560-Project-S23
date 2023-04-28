--DROP TABLE MovieDatabase.Directors;

CREATE TABLE MovieDatabase.Directors
(
	directorId int IDENTITY(1,1) PRIMARY KEY,
	fullName NVARCHAR(128)  NOT NULL
);

SELECT *
FROM MovieDatabase.Directors

-- bcp CIS560Project.MovieDatabase.Directors in "C:\Users\Isaiah\source\repos\CIS560-Project-S23\CIS-560-Project-Team-16\CIS-560-Project-Team-16\Sql\Data\MovieOutput.tsv" -S "(localdb)\MSSQLLocalDb" -T -f DirectorFormat.fmt -h "CHECK_CONSTRAINTS"
