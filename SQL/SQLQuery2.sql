BEGIN TRANSACTION;

ALTER TABLE dbo."User"
	ADD email_address varchar(100) NULL;

COMMIT;