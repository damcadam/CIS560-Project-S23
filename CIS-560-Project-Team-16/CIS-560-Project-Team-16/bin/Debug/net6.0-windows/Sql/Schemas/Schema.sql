IF NOT EXISTS
   (
      SELECT *
      FROM sys.schemas s
      WHERE s.[name] = N'MovieDatabase'
   )
BEGIN
   EXEC(N'CREATE SCHEMA [MovieDatabase] AUTHORIZATION [dbo]');
END;