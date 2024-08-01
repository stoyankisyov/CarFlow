CREATE TABLE Account
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Name NVARCHAR(150) NOT NULL,
	Email NVARCHAR(150) UNIQUE NOT NULL,
	Phone NVARCHAR(50) UNIQUE NOT NULL,
	Password NVARCHAR(100) NOT NULL,
	Address NVARCHAR(500)
)