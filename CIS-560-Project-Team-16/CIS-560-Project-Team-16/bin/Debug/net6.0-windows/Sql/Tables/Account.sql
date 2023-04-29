--(localdb)\MSSQLLocalDb
DROP TABLE MovieDatabase.[Account];

IF OBJECT_ID(N'MovieDatabase.Account') IS NULL
BEGIN
	CREATE TABLE MovieDatabase.Account
	(
		accountId int IDENTITY(1,1) PRIMARY KEY,
		username NVARCHAR(128) NOT NULL,
		[password] NVARCHAR(128)  NOT NULL
	);
END;

SELECT *
FROM MovieDatabase.Account

--bcp CIS560Project.MovieDatabase.Account in "C:\Users\Isaiah\source\repos\CIS560-Project-S23\CIS-560-Project-Team-16\CIS-560-Project-Team-16\Sql\Data\AccountData.tsv" -S "(localdb)\MSSQLLocalDb" -T -f AccountFormat.fmt -h "CHECK_CONSTRAINTS"


