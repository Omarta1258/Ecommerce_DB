CREATE TABLE customerCart (
    CustomerID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    Email VARCHAR(255) NOT NULL,
    Fname VARCHAR(100) NOT NULL,
    Lname VARCHAR(100) NOT NULL,
    Minit VARCHAR(10) NOT NULL,
    Age INT NOT NULL,
    Gender VARCHAR(10) NOT NULL,
    Subtotal DECIMAL(10,2) NOT NULL
);
INSERT INTO customerCart (Email, Fname, Lname, Minit, Age, Gender, Subtotal)
VALUES 
('john.doe@example.com', 'John', 'Doe', 'A', 30, 'Male', 250.00),
('jane.smith@example.com', 'Jane', 'Smith', 'B', 27, 'Female', 150.00),
('mike.jones@example.com', 'Mike', 'Jones', 'C', 45, 'Male', 320.00),
('susan.wilson@example.com', 'Susan', 'Wilson', 'D', 22, 'Female', 180.00),
('alex.taylor@example.com', 'Alex', 'Taylor', 'E', 34, 'Female', 75.00);

CREATE TABLE etailer (
    Website VARCHAR(255) PRIMARY KEY,
    Brand VARCHAR(100)
);
INSERT INTO etailer (Website, Brand)
VALUES ('amazon.com', 'Various'),
       ('bestbuy.com', 'Electronics'),
       ('nike.com', 'Nike');


CREATE TABLE employee (
    EmployeeID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    Fname VARCHAR(100) NOT NULL,
    Lname VARCHAR(100) NOT NULL,
    Minit VARCHAR(10) NOT NULL,
    Age INT NOT NULL,
    Gender VARCHAR(10),
    Position VARCHAR(100) NOT NULL,
    Website VARCHAR(255) NOT NULL,
    FOREIGN KEY (Website) REFERENCES etailer(Website)
);
INSERT INTO employee (Fname, Lname, Minit, Age, Gender, Position, Website)
VALUES 
('Alice', 'Brown', 'C', 28, 'Female', 'Shipper', 'amazon.com'),
('Bob', 'Green', 'D', 35, 'Male', 'Warehouse Manager', 'bestbuy.com'),
('Eve', 'White', 'E', 29, 'Female', 'Customer Support', 'nike.com'),
('Dan', 'Black', 'F', 42, 'Male', 'Operations Lead', 'amazon.com'),
('Taylor', 'Gray', 'G', 31, 'Non-binary', 'Logistics Coordinator', 'bestbuy.com');

CREATE TABLE category (
    Name VARCHAR(100) PRIMARY KEY,
    Brand_Affiliation VARCHAR(100) NOT NULL
);
INSERT INTO category (Name, Brand_Affiliation)
VALUES
('Electronics', 'Sony'),
('Clothing', 'Nike'),
('Books', 'Penguin');

CREATE TABLE manufacturer (
    ManufacturerID INT IDENTITY(1,1) PRIMARY KEY,
    Industry VARCHAR(100) NOT NULL
);
INSERT INTO manufacturer (Industry)
VALUES
('Electronics'),
('Apparel'),
('Publishing');

CREATE TABLE product (
    ProductID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    Description VARCHAR(255) NOT NULL,
    Category_Name VARCHAR(100) NOT NULL,
    ManufacturerID INT NOT NULL,
    FOREIGN KEY (Category_Name) REFERENCES category(Name),
    FOREIGN KEY (ManufacturerID) REFERENCES manufacturer(ManufacturerID)
);

INSERT INTO product (Name, Price, Description, Category_Name, ManufacturerID)
VALUES
('Laptop', 1200.99, 'High-performance laptop', 'Electronics', 1),
('Running Shoes', 99.99, 'Nike running shoes', 'Clothing', 2),
('Science Book', 39.95, 'Physics fundamentals', 'Books', 3);

CREATE TABLE orders (
    OrderID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT NOT NULL,
    Products_Price DECIMAL(10,2) NOT NULL,
    Shipping_Price DECIMAL(10,2) NOT NULL,
    Taxes DECIMAL(10,2) NOT NULL,
    Date DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (CustomerID) REFERENCES customerCart(CustomerID)
);
INSERT INTO orders (CustomerID, Products_Price, Shipping_Price, Taxes)
VALUES 
(1, 1200.99, 20.00, 100.00),
(2, 99.99, 10.00, 8.00);


CREATE TABLE address (
    AddressID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Country VARCHAR(100) NOT NULL,
    City VARCHAR(100) NOT NULL,
    CustomerID INT NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES customerCart(CustomerID)
);
INSERT INTO address (Country, City, CustomerID)
VALUES
('USA', 'New York', 1),
('USA', 'Los Angeles', 2);

CREATE TABLE payment (
    PaymentID INT IDENTITY(1,1) PRIMARY KEY,
    OrderID INT NOT NULL,
    Amount DECIMAL(10,2) NOT NULL,
    Method VARCHAR(50) NOT NULL,
    FOREIGN KEY (OrderID) REFERENCES orders(OrderID)
);
INSERT INTO payment (OrderID, Amount, Method)
VALUES 
(1, 1340.99, 'Credit Card'),
(2, 117.99, 'PayPal');