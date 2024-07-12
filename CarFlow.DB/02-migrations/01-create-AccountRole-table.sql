CREATE TABLE AccountRole (
    AccountId INT,
    RoleId INT,
    PRIMARY KEY (AccountId, RoleId),
    FOREIGN KEY (AccountId) REFERENCES Account(Id),
    FOREIGN KEY (RoleId) REFERENCES Role(Id)
);