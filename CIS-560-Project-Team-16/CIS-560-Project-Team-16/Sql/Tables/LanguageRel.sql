DROP TABLE MovieDatabase.LanguageRel;

-- make the LanguageRel table by inserting the id columns from the merge above
IF OBJECT_ID(N'MovieDatabase.LanguageRel') IS NULL
BEGIN
    CREATE TABLE LanguageRel 
    (
    languageId INT NOT NULL,
    movieId INT NOT NULL,
    PRIMARY KEY (languageId, movieId),
    FOREIGN KEY (languageId) REFERENCES MovieDatabase.Language(languageId),
    FOREIGN KEY (movieId) REFERENCES MovieDatabase.Movies(movieId)
    );
END;

SELECT *
FROM MovieDatabase.LanguageRel