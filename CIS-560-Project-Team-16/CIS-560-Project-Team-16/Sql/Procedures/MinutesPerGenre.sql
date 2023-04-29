/*
Description: This query lists the total runtime in minutes for every
genre. Knowing what genres we have lets us prioritize adding movies
for genres with less runtime.
Parameters: None
Result Columns: Genre, TotalRuntime
*/

-- Procedure Part



-- Query Part
SELECT GV.genreName,
    -- Length is a string in our table
    SUM(CAST(M.[length] AS INT)) AS TotalRuntime
FROM MovieDatabase.GenreValues GV
    INNER JOIN MovieDatabase.Genre G ON GV.genreId = G.genreId
    INNER JOIN MovieDatabase.Movies M ON G.movieId = M.movieId
GROUP BY GV.genreName;
