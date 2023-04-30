/*
This procedure is a test procedure that inserts a 
string in the fullName columnof the Directors table. 
It also returns the name that come alphabetically first in the column.

We can use this as a template when we start to write procedures to
accomplish certain tasks.
*/

CREATE OR ALTER PROCEDURE MovieDatabase.TestProc
   @FullName NVARCHAR(128),
   @AlphabetName NVARCHAR(128) OUTPUT -- Parameter to return from procedure
AS

-- Insert first parameter into table
INSERT MovieDatabase.Directors(FullName)
VALUES(@FullName);

-- Find the name that comes first alphabetically in the fullName column
SELECT TOP 1 @AlphabetName = MDD.fullName
FROM MovieDatabase.Directors MDD
ORDER BY MDD.fullName ASC;
GO