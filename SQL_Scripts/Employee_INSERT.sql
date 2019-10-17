--INSERT: Employee
BEGIN TRAN

INSERT INTO Employee VALUES ('Smith', 'John', 1, '2019-01-01')
INSERT INTO Employee VALUES ('James', 'Jack', 1, '2019-02-01')
INSERT INTO Employee VALUES ('Wayne', 'Bruce', 2, '2019-03-01')
INSERT INTO Employee VALUES ('Kent', 'Clark', 2, '2019-03-15')
INSERT INTO Employee VALUES ('Hamilton', 'James', 3, '2019-04-01')
INSERT INTO Employee VALUES ('Burr', 'Aaron', 3, '2019-04-10')
INSERT INTO Employee VALUES ('Stark', 'Tony', 4, '2019-04-10')

SELECT * FROM Employee

ROLLBACK TRAN

--COMMIT TRAN
