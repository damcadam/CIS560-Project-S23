CREATE TABLE MovieDatabase.Account
(
	username NVARCHAR(128) NOT NULL PRIMARY KEY,
	accountRegion NVARCHAR(128)  NOT NULL,
	[password] NVARCHAR(128)  NOT NULL
);