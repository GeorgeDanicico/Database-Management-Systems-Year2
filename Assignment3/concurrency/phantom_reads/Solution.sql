USE DB_COURSE
GO

-- set transaction isolation level to serializable
SET TRAN ISOLATION LEVEL SERIALIZABLE
BEGIN TRAN
SELECT * FROM Map
WAITFOR DELAY '00:00:05'
SELECT * FROM Map
COMMIT TRAN