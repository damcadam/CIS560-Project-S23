CREATE TABLE MovieDatabase.WatchList
(
	watchListId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	-- I'm assuming that favorites and watchLater would join with movieId,
	-- so they'd be INT?
	favorites INT NULL,
	watchLater INT NULL,
);