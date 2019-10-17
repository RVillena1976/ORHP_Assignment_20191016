CREATE TABLE Department (
	DepartmentID INT IDENTITY(1,1),
	DepartmentNm VARCHAR(255) NOT NULL UNIQUE,
	PRIMARY KEY (DepartmentID),
);

CREATE TABLE Employee (
	EmployeeID INT IDENTITY(1,1),
	LastName VARCHAR(255) NOT NULL,
	FirstName VARCHAR(255) NOT NULL,
	DepartmentID INT NOT NULL,
	HireDt DATETIME NULL,
	PRIMARY KEY (EmployeeID),
	FOREIGN KEY (DepartmentID) REFERENCES Department(DepartmentID)
);
