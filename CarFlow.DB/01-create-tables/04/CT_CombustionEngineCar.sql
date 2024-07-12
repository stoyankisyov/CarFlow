CREATE TABLE CombustionEngineCar
(
	Id INT PRIMARY KEY,
	EngineId INT NOT NULL,
	EuroStandardId INT NOT NULL,
	CityFuel DECIMAL(3,1) DEFAULT NULL,
	CombinedFuel DECIMAL(3,1) DEFAULT NULL,
	HighwayFuel DECIMAL(3,1) DEFAULT NULL
	FOREIGN KEY (Id) REFERENCES Car (Id),
	FOREIGN KEY (EngineId) REFERENCES Engine (Id),
	FOREIGN KEY (EuroStandardId) REFERENCES EuroStandard (Id)
)