CREATE TABLE AccountFavouriteCar
(
	AccountId INT NOT NULL,
	CarAdId INT NOT NULL
	FOREIGN KEY (AccountId) REFERENCES Account(Id),
	FOREIGN KEY (CarAdId) REFERENCES CarAd(Id),
	PRIMARY KEY(AccountId, CarAdId)
)
