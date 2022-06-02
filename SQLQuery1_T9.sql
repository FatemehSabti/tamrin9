CREATE PROCEDURE shownameandcity
     @name varchar(255)
AS
SELECT customers.Name , products.Name , cities.Name
FROM customers INNER JOIN cities
on customers.City_id = cities.ID
INNER JOIN orders
on orders.Customer_id = customers.ID
INNER JOIN products
on products.ID = orders.Product_id
WHERE products.Name = @name

EXEC shownameandcity "iPhone 8 Plus"

CREATE PROCEDURE shownameandprice
     @n varchar(255)
AS
SELECT DISTINCT customers.Name , products.Name , products.Price
FROM customers INNER JOIN orders
on orders.Customer_id = customers.ID
INNER JOIN products
on products.ID = orders.Product_id
WHERE customers.Name = @n

EXEC shownameandprice "Ali Aminzade"

CREATE PROCEDURE dateorder
     @city varchar(255)
AS
SELECT DISTINCT cities.Name , orders.Date
FROM orders INNER JOIN products
on orders.Product_id = products.ID
INNER JOIN customers
on customers.ID = orders.Customer_id
INNER JOIN cities
on cities.ID = customers.City_id
WHERE cities.Name = @city

EXEC dateorder "Tehran"

CREATE PROCEDURE warecheap
     @price varchar(255)
AS
SELECT customers.Name , customers.Address , products.Price
FROM customers INNER JOIN orders
on customers.ID = orders.Customer_id
INNER JOIN products
on products.ID = orders.Product_id
WHERE products.Price < @price

EXEC warecheap "500.0"