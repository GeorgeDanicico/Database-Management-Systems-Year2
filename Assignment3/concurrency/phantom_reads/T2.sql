USE DB_COURSE
GO

-- phantom read - because T1 has generated a new row while T2 is executing, we will get an extra row in the second select
SET TRAN ISOLATION LEVEL REPEATABLE READ
BEGIN TRAN
--inserted value does not exist yet
SELECT * FROM Map
WAITFOR DELAY '00:00:05'
--we can see the inserted value during the second read
SELECT * FROM Map
COMMIT TRAN