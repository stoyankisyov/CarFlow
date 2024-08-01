CREATE TABLE ElectricCar
(
	Id INT PRIMARY KEY,
	Horsepower INT NOT NULL,
	Torque INT NOT NULL,
	BatteryCapacity INT NOT NULL,
	Range INT NOT NULL,
	MotorCount INT NOT NULL
	FOREIGN KEY (Id) REFERENCES Car (Id)
)