USE DB_COURSE
GO

-- t1
BEGIN TRAN
UPDATE Map
SET map_name = 'Caesar Salad' 
WHERE map_id = 10
WAITFOR DELAY '00:00:04'
ROLLBACK TRAN