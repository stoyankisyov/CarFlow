CREATE TABLE ModelStandardFeature
(
	ModelId INT,
	FeatureId INT,
	FOREIGN KEY (ModelId) REFERENCES Model(Id),
	FOREIGN KEY (FeatureId) REFERENCES Feature(Id),
	PRIMARY KEY(ModelId, FeatureId)
)