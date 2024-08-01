CREATE TABLE Car
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	ModelId INT NOT NULL,
	Generation NVARCHAR(150) DEFAULT NULL,
	BodyVariantId INT NOT NULL,
	TransmissionVariantId INT NOT NULL,
	DrivetrainId INT NOT NULL,
	StartYear DATE NOT NULL,
	EndYear DATE DEFAULT NULL
	FOREIGN KEY (ModelId) REFERENCES Model (Id),
	FOREIGN KEY (BodyVariantId) REFERENCES BodyVariant (Id),
	FOREIGN KEY (TransmissionVariantId) REFERENCES TransmissionVariant (Id),
	FOREIGN KEY (DrivetrainId) REFERENCES Drivetrain (Id)
)