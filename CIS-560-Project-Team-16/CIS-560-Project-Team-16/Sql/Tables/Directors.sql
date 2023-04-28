--(localdb)\MSSQLLocalDb
--DROP TABLE MovieDatabase.Directors;

IF OBJECT_ID(N'MovieDatabase.Directors') IS NULL
BEGIN
	CREATE TABLE MovieDatabase.Directors
	(
		directorId int IDENTITY(1,1) PRIMARY KEY,
		fullName NVARCHAR(128)  NOT NULL,
		CreatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
		UpdatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET())
	);
END;

--SELECT *
--FROM MovieDatabase.Directors

-- bcp CIS560Project.MovieDatabase.Directors in "C:\Users\Isaiah\source\repos\CIS560-Project-S23\CIS-560-Project-Team-16\CIS-560-Project-Team-16\Sql\Data\MovieOutput.tsv" -S "(localdb)\MSSQLLocalDb" -T -f DirectorFormat.fmt -h "CHECK_CONSTRAINTS"
