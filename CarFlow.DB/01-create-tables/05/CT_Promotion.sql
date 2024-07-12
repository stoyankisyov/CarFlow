CREATE TABLE Promotion
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	CarAdId INT NOT NULL,
	PromotionTypeId INT NOT NULL,
	ExpirationDate DATETIME NOT NULL
	FOREIGN KEY (CarAdId) REFERENCES CarAd(Id),
	FOREIGN KEY (PromotionTypeId) REFERENCES PromotionType(Id)
)