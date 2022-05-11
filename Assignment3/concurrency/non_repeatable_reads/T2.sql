USE DB_COURSE
GO

-- the row is changed while T2 is in progress => we'll see both values for the name of the Map
SET TRAN ISOLATION LEVEL READ COMMITTED
BEGIN TRAN
-- insert
SELECT * FROM Map
WAITFOR DELAY '00:00:05'
-- update
SELECT * FROM Map
COMMIT TRAN