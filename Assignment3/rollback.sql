USE DB_COURSE
GO

DROP TABLE IF EXISTS LogTable 
CREATE TABLE LogTable(
	Lid INT IDENTITY PRIMARY KEY,
	TypeOperation VARCHAR(50),
	TableOperation VARCHAR(50),
	ExecutionDate DATETIME
);

GO

--use m:n relation Weapon cases - Map
SELECT * FROM Weapon_Cases
SELECT * FROM Map
SELECT * FROM Drop_Case
GO

CREATE OR ALTER FUNCTION ufValidateName (@name VARCHAR(30))
RETURNS INT
AS
BEGIN
	DECLARE @return INT
	SET @return=1
	IF (@name IS NULL OR LEN(@name)<2)
	BEGIN
		SET @return=0
	END
	RETURN @return
END
GO

CREATE OR ALTER PROCEDURE uspAddWeaponCase (@case_id SMALLINT, @case_name VARCHAR(30))
AS
	SET NOCOUNT ON
	IF (dbo.ufValidateName(@case_name) <> 1)
	BEGIN
		RAISERROR('Case Name is invalid',14,1)
	END

	IF EXISTS (SELECT * FROM Weapon_Cases WHERE case_id = @case_id)
	BEGIN
		RAISERROR('Case already exists',14,1)
	END
	INSERT INTO Weapon_Cases VALUES (@case_id, @case_name)
	INSERT INTO LogTable VALUES('add','weapon case',GETDATE())
GO

CREATE OR ALTER PROCEDURE uspAddMap (@map_id SMALLINT, @map_name VARCHAR(30))
AS
	SET NOCOUNT ON
	IF (dbo.ufValidateName(@map_name) <> 1)
	BEGIN
		RAISERROR('Map Name is invalid',14,1)
	END
	IF EXISTS (SELECT * FROM Map WHERE map_id = @map_id)
	BEGIN
		RAISERROR('Allergen already exists',14,1)
	END
	INSERT INTO Map VALUES (@map_id, @map_name)
	INSERT INTO LogTable VALUES('add','map',GETDATE())
GO

CREATE OR ALTER PROCEDURE uspAddDropCase (@case_id SMALLINT, @map_id SMALLINT)
AS
	SET NOCOUNT ON
	IF NOT EXISTS (SELECT * FROM Weapon_Cases WHERE case_id = @case_id)
	BEGIN
		RAISERROR('Invalid weapon case',14,1)
	END
	IF NOT EXISTS (SELECT * FROM Map WHERE map_id = @map_id)
	BEGIN
		RAISERROR('Invalid map',14,1)
	END
	IF EXISTS (SELECT * FROM Drop_Case WHERE case_id = @case_id AND map_id = @map_id)
	BEGIN
		RAISERROR('Pair already exists',14,1)
	END
	INSERT INTO Drop_Case VALUES (@map_id, @case_id)
	INSERT INTO LogTable VALUES('add','drop_case',GETDATE())
GO

CREATE OR ALTER PROCEDURE uspAddCommitScenario
AS
	BEGIN TRAN
	BEGIN TRY
		EXEC uspAddWeaponCase 11, 'Bajolsta Case'
		EXEC uspAddMap 11, 'de_dust2'
		EXEC uspAddDropCase 11,11
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		RETURN
	END CATCH
GO

CREATE OR ALTER PROCEDURE uspAddRollbackScenario
AS
	BEGIN TRAN
	BEGIN TRY
		EXEC uspAddWeaponCase 10, 'Bajolsta Case'
		EXEC uspAddMap 10, 'd' -- Will fail, thus all the statements will be rolled back
		EXEC uspAddDropCase 10,10
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
		RETURN
	END CATCH
GO

EXEC uspAddRollbackScenario
EXEC uspAddCommitScenario

SELECT * FROM LogTable

DELETE FROM Drop_Case WHERE map_id = 11
DELETE FROM Weapon_Cases WHERE case_id = 11
DELETE FROM Map WHERE map_id = 11