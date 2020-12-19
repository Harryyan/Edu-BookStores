BEGIN TRANSACTION;

ALTER TABLE dbo.Author ADD
	email_address varchar(100) NULL;

ALTER TABLE dbo.Job
	DROP COLUMN min_lvl, max_lvl;

ALTER TABLE dbo.BookAuthor
ALTER COLUMN royality_percentage int;

COMMIT;