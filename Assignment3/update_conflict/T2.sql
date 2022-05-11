USE DB_COURSE
GO

-- update conflict
SET TRAN ISOLATION LEVEL SNAPSHOT
BEGIN TRAN

WAITFOR DELAY '00:00:05'

-- T1 has now updated and obtained a lock on the Map table
-- trying to update the same row from the table Map will result in a error, because the process will be blocked
UPDATE Map SET map_name = 'fy_snow2' WHERE map_id = 10
COMMIT TRAN