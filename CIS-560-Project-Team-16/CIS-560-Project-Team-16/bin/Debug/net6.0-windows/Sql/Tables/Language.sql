--(localdb)\MSSQLLocalDb

DROP TABLE MovieDatabase.[Language];

IF OBJECT_ID(N'MovieDatabase.Language') IS NULL
BEGIN
    CREATE TABLE MovieDatabase.[Language]
    (
        languageId int IDENTITY(1,1) PRIMARY KEY,
        [language] NVARCHAR(128)
    );
END;

SELECT *
FROM MovieDatabase.Language

-- bcp CIS560Project.MovieDatabase.Language in "C:\Users\Isaiah\source\repos\CIS560-Project-S23\CIS-560-Project-Team-16\CIS-560-Project-Team-16\Sql\Data\StaticLanguages.tsv" -S "(localdb)\MSSQLLocalDb" -T -f StaticLanguageFormat.fmt -h "CHECK_CONSTRAINTS"
