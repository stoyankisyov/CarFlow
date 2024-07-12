CREATE TABLE CarFeature
(
	CarAdId INT NOT NULL,
	FeatureId INT NOT NULL,
	FOREIGN KEY (CarAdId) REFERENCES CarAd(Id),
	FOREIGN KEY (FeatureId) REFERENCES Feature(Id),
	PRIMARY KEY (CarAdId, FeatureId)
)