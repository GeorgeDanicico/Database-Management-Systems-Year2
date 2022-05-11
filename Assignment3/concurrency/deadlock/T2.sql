

USE DB_COURSE
GO

SELECT * FROM Map
SELECT * FROM Weapon_Cases

BEGIN TRAN
--exclusive lock on table Weapon_Cases
UPDATE Weapon_Cases SET case_type = 'bloodhunt case' WHERE case_id = 10
WAITFOR DELAY '00:00:10'

-- the transaction will be blocked, because T2 already has an exclusive lock on Weapon_Cases
UPDATE Map SET map_name = 'de_dust2' WHERE map_id = 10


COMMIT TRAN