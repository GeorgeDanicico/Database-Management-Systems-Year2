USE DB_COURSE
GO

CREATE OR ALTER PROCEDURE uspAddWeaponCaseRecover (@case_id SMALLINT, @case_name VARCHAR(30))
AS
	SET NOCOUNT ON
	BEGIN TRAN
	BEGIN TRY
		IF (dbo.ufValidateName(@case_name) <> 1)
		BEGIN
			RAISERROR('Weapon name is invalid',14,1)
		END

		IF EXISTS (SELECT * FROM Weapon_Cases WHERE case_id = @case_id)
		BEGIN
			RAISERROR('Weapon case already exists',14,1)
		END
		INSERT INTO Weapon_Cases VALUES (@case_id, @case_name)
		INSERT INTO LogTable VALUES('add','weapon case',GETDATE())
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH
GO

CREATE OR ALTER PROCEDURE uspAddMapRecover (@map_id SMALLINT, @map_name VARCHAR(30))
AS
	SET NOCOUNT ON
	BEGIN TRAN
	BEGIN TRY
		IF (dbo.ufValidateName(@map_name) <> 1)
		BEGIN
			RAISERROR('Map is invalid',14,1)
		END
		IF EXISTS (SELECT * FROM Map WHERE map_id = @map_id)
		BEGIN
			RAISERROR('map already exists',14,1)
		END
		INSERT INTO Map VALUES (@map_id, @map_name)
		INSERT INTO LogTable VALUES('add','map',GETDATE())
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH
GO

CREATE OR ALTER PROCEDURE uspAddDropCaseRecover (@case_id SMALLINT, @map_id SMALLINT)
AS
	SET NOCOUNT ON
	BEGIN TRAN
	BEGIN TRY
		IF NOT EXISTS (SELECT * FROM Weapon_Cases WHERE case_id = @case_id)
		BEGIN
			RAISERROR('Invalid case',14,1)
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
		INSERT INTO LogTable VALUES('add','dropcase',GETDATE())
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH
GO

CREATE OR ALTER PROCEDURE uspBadAddScenario
AS
		EXEC uspAddWeaponCaseRecover 10, 'Bajolsta Case'
		EXEC uspAddMapRecover 10, 'd' -- Will fail, but the statements that has been inserted before will remain
		EXEC uspAddDropCaseRecover 10,10
GO

CREATE OR ALTER PROCEDURE uspGoodAddScenario
AS
		EXEC uspAddWeaponCaseRecover 9, 'Bajolsta Case'
		EXEC uspAddMapRecover 9, 'fy_snow'
		EXEC uspAddDropCaseRecover 9,9
GO

EXEC uspBadAddScenario
SELECT * FROM LogTable

EXEC uspGoodAddScenario
SELECT * FROM LogTable

SELECT * FROM Map
SELECT * FROM Weapon_Cases
SELECT * FROM Drop_Case

DELETE FROM Drop_Case WHERE case_id=10 AND map_id=10
DELETE FROM Drop_Case WHERE case_id=9 AND case_id=9

DELETE FROM Map WHERE map_id=9
DELETE FROM Map WHERE map_id=10

DELETE FROM Weapon_Cases WHERE case_id=9
DELETE FROM Weapon_Cases WHERE case_id=10