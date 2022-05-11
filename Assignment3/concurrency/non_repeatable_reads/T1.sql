USE DB_COURSE
GO

--part 1
INSERT INTO Map(map_id, map_name) VALUES (15,'de_mirage')
BEGIN TRAN
WAITFOR DELAY '00:00:04'
UPDATE Map 
SET map_name = 'de_mirage2'
WHERE map_name = 'de_mirage'
COMMIT TRAN