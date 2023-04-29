/*
Description: This query lists the number of titles for each language. 
Knowing what language of the titles in the movie database helps us 
know who to market our application to.
Parameters: None.
Result Columns: TitleCount, Language
*/


-- Procedure Part



-- Query Part
SELECT L.[language] AS [Language], COUNT(R.movieId) AS TitleCount
FROM MovieDatabase.Movies M
    INNER JOIN MovieDatabase.LanguageRel R ON M.movieId = R.movieId
    INNER JOIN MovieDatabase.[Language] L ON R.languageId = L.languageId
GROUP BY L.[language];

