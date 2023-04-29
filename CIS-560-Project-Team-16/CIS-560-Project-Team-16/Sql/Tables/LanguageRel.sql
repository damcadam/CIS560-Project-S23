--(localdb)\MSSQLLocalDb
DROP TABLE MovieDatabase.LanguageRelationship;

-- make the LanguageRel table by inserting the id columns from the merge above
IF OBJECT_ID(N'MovieDatabase.LanguageRelationship') IS NULL
BEGIN
	CREATE TABLE LanguageRelationship 
	(
	languageId INT NOT NULL,
	movieId INT NOT NULL,
	PRIMARY KEY (languageId, movieId),
	FOREIGN KEY (languageId) REFERENCES MovieDatabase.[Language](languageId),
	FOREIGN KEY (movieId) REFERENCES MovieDatabase.Movies(movieId)
	);
END;

SELECT *
FROM MovieDatabase.LanguageRelationship



INSERT INTO MovieDatabase.LanguageRelationship (movieId)
SELECT movieId
FROM MovieDatabase.Movies;

-- bcp CIS560Project.MovieDatabase.Language in "C:\Users\Isaiah\source\repos\CIS560-Project-S23\CIS-560-Project-Team-16\CIS-560-Project-Team-16\Sql\Data\StaticLanguages.tsv" -S "(localdb)\MSSQLLocalDb" -T -f StaticLanguageFormat.fmt -h "CHECK_CONSTRAINTS"
