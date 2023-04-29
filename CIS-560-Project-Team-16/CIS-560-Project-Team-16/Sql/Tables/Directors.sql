--DROP TABLE MovieDatabase.Directors;

CREATE TABLE MovieDatabase.Directors
(
	directorId int IDENTITY(1,1) PRIMARY KEY,
	fullName NVARCHAR(128)  NOT NULL
);

SELECT *
FROM MovieDatabase.Directors
JOIN MovieDatabase.Movies

-- bcp CIS560Project.MovieDatabase.Directors in "C:\Users\Cade\Source\Repos\CIS560-Project-S23-main\CIS-560-Project-Team-16\CIS-560-Project-Team-16\Sql\Data\MovieOutput.tsv" -S "(localdb)\MSSQLLocalDb" -T -f "C:\Users\Cade\Source\Repos\CIS560-Project-S23-main\CIS-560-Project-Team-16\CIS-560-Project-Team-16\Sql\Data\DirectorFormat.fmt" -h "CHECK_CONSTRAINTS"

SELECT MDD.fullName
FROM MovieDatabase.Directors MDD
ORDER BY MDD.fullName ASC;