CREATE TABLE TransmissionVariant
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	TransmissionId INT NOT NULL,
	GearCount INT NOT NULL
	FOREIGN KEY (TransmissionId) REFERENCES Transmission(Id),
	UNIQUE (TransmissionId, GearCount)
)