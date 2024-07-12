CREATE TABLE Engine
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Model NVARCHAR(100) DEFAULT NULL,
	Displacement INT NOT NULL,
	Horsepower INT NOT NULL,
	Torque INT NOT NULL,
	FuelTypeId INT NOT NULL,
	ConfigurationId INT  NOT NULL,
	AspirationId INT NOT NULL
	FOREIGN KEY (FuelTypeId) REFERENCES FuelType(Id),
	FOREIGN KEY (ConfigurationId) REFERENCES EngineConfiguration(Id),
	FOREIGN KEY (AspirationId) REFERENCES EngineAspiration(Id)
)