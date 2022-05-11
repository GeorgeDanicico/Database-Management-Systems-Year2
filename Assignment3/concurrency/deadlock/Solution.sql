USE DB_COURSE
GO

-- set deadlock priority to high for the second transaction now and
-- T1 will be chosen as the deadlock victim, as it has a lower priority

SET DEADLOCK_PRIORITY HIGH
BEGIN TRAN
--exclusive lock on table Weapon_Cases
UPDATE Weapon_Cases SET case_type = 'bloodhunt case' WHERE case_id = 10
WAITFOR DELAY '00:00:10'

UPDATE Map SET map_name = 'de_dust2' WHERE map_id = 10

COMMIT TRAN
