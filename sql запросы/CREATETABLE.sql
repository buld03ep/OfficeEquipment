USE OfficeEquipmentDB
GO

CREATE TABLE Employees (
    employee_id INT PRIMARY KEY IDENTITY(1,1),
    full_name NVARCHAR(100) NOT NULL,
    position NVARCHAR(50),
    phone NVARCHAR(20),
    email NVARCHAR(100)
);

CREATE TABLE Computers (
    computer_id INT PRIMARY KEY IDENTITY(1,1),
    operating_system NVARCHAR(100),
    employee_id INT,

    FOREIGN KEY (employee_id) REFERENCES Employees(employee_id)
);

CREATE TABLE Software (
    software_id INT PRIMARY KEY IDENTITY(1,1),
    software_name NVARCHAR(100) NOT NULL,
    version NVARCHAR(50),
    software_type NVARCHAR(50),
    license_type NVARCHAR(50)
);

CREATE TABLE Components (
    component_id INT PRIMARY KEY IDENTITY(1,1),
    component_type NVARCHAR(50),
    model NVARCHAR(100),
    manufacturer NVARCHAR(100),
    specifications NVARCHAR(255),
    computer_id INT,

    FOREIGN KEY (computer_id) REFERENCES Computers(computer_id)
);

CREATE TABLE InstalledSoftware (
    install_id INT PRIMARY KEY IDENTITY(1,1),
    computer_id INT,
    software_id INT,
    install_date DATE,

    FOREIGN KEY (computer_id) REFERENCES Computers(computer_id),
    FOREIGN KEY (software_id) REFERENCES Software(software_id)
);
