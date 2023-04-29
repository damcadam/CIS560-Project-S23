--(localdb)\MSSQLLocalDb
DROP TABLE MovieDatabase.[Actor];

IF OBJECT_ID(N'MovieDatabase.Actor') IS NULL
BEGIN
	CREATE TABLE MovieDatabase.Actor
	(
		actorId int IDENTITY(1,1) PRIMARY KEY,
		fullName NVARCHAR(128)  NOT NULL
	);
END;

SELECT *
FROM MovieDatabase.Actor

-- bcp CIS560Project.MovieDatabase.Actor in "C:\Users\WaterMan\source\repos\CIS560-Project-S23\CIS-560-Project-Team-16\CIS-560-Project-Team-16\Sql\Data\MovieOutput.tsv" -S "(localdb)\MSSQLLocalDb" -T -f ActorFormat.fmt -h "CHECK_CONSTRAINTS"
