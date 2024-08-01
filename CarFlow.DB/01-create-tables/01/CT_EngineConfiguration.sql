CREATE TABLE EngineConfiguration
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL,
	CylinderCount INT NOT NULL
	UNIQUE(Name, CylinderCount)
)