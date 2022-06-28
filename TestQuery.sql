CREATE TABLE Products (
	Id INT PRIMARY KEY,
	"Name" TEXT
);

INSERT INTO Products
VALUES
	(1, 'Water'),
	(2, 'Beer'),
	(3, 'Chocolate'),
	(4, 'Sneakers'),
	(5, 'Glasses'),
	(6, 'Laptop');

CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	"Name" TEXT
);

INSERT INTO Categories
VALUES
	(1, 'Food'),
	(2, 'Clothes');

CREATE TABLE ProductCategories (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductCategories
VALUES
	(1, 1),
	(2, 1),
	(3, 1),
	(4, 2);


SELECT P.Name, C.Name
FROM Products P
LEFT JOIN ProductCategories PC
	ON P.Id = PC.ProductId
LEFT JOIN Categories C
	ON PC.CategoryId = C.Id;