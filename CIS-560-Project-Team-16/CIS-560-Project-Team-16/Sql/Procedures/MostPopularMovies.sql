/*
Description: This query returns the most popular movies in our application. 
Movies’ popularity is represented by the number of users that have the 
movie on their watchlist. Since the popularity is based on what the users 
currently have in their watchlist this query tracks the movies that are 
most popular right now. 
Parameters: None.
Result Columns: MovieName, WatchListCount
*/


-- Procedure Part



-- Query Part
SELECT M.[name] AS MovieName, COUNT(W.movieId) AS WatchListCount
FROM MovieDatabase.Movies M
    LEFT JOIN  MovieDatabase.WatchList W ON M.movieId = W.movieId
GROUP BY M.movieId, M.[name]
ORDER BY M.[name];

