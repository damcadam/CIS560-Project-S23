CREATE TABLE MovieDatabase.Reviews
(
	reviewId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	-- Average score our of count reivews from 0 to 10
	averageIMDb INT NOT NULL,
	[count] INT NOT NULL,
);