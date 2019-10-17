--INSERT: Department
BEGIN TRAN

INSERT INTO Department VALUES ('Sales')
INSERT INTO Department VALUES ('Service')
INSERT INTO Department VALUES ('Marketing')
INSERT INTO Department VALUES ('Authorization')

SELECT * FROM Department

ROLLBACK TRAN

--COMMIT TRAN
