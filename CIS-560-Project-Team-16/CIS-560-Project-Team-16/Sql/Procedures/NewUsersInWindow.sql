/*
Description: This determines the number of people that created an account in
a given time window. Knowing the number of individuals making accounts is
vital for tracking the popularity of our application. The query also shows 
the total number of users and the percent increase in users.
Parameters: StartDate: beginning date to include in the analysis.
EndDate: final date to include in the analysis.
Result Columns: UserCount, TotalUsers, PercentIncrease
*/


-- Procedure Part



-- Query Part
DECLARE @beginDate DATETIMEOFFSET;
DECLARE @endDate DATETIMEOFFSET;

SELECT 
    SUM(CASE WHEN createdOn >= @beginDate AND createdOn <= @endDate THEN 1 ELSE 0 END) AS UserCount,
    COUNT(accountId) AS TotalUsers,
    CAST((SUM(CASE WHEN createdOn <= @endDate THEN 1 ELSE 0 END) 
        - SUM(CASE WHEN createdOn < @beginDate THEN 1 ELSE 0 END)) * 100.0
        / SUM(CASE WHEN createdOn < @beginDate THEN 1 ELSE 0 END) AS FLOAT) 
        AS PercentIncrease
FROM MovieDatabase.Account;
