USE DB_COURSE
GO

-- transaction isolation level repeatable read
SET TRAN ISOLATION LEVEL REPEATABLE READ
BEGIN TRAN
SELECT * FROM Map
WAITFOR DELAY '00:00:05'
--now we can see the value before the update 
SELECT * FROM Map
COMMIT TRAN
