USE OfficeEquipmentDB
GO

INSERT INTO Employees (full_name, position, phone, email) VALUES
(N'Александров Сергей Викторович', N'Системный администратор', '+79190936589', 'alexandrov@gmail.com'),
(N'Морозов Илья Андреевич', N'Программист', '+749902320502', 'ilyamorozov@mail.ru'),
(N'Крылова Анастасия Игоревна', N'Бухгалтер', '+79193054813', 'krylova@gmail.com'),
(N'Беляев Дмитрий Сергеевич', N'Менеджер', '+79120457641', 'dimaa-098@yandex.ru'),
(N'Фёдорова Марина Олеговна', N'Инженер технической поддержки', '+79997653215', 'fedorova19maria@gmail.com'),
(N'Никитин Михаил Павлович', N'Инженер технической поддержки', '+79190238956', 'nikitinartem777@gmail.com'),
(N'Соловьёв Максим Денисович', N'Инженер технической поддержки', '+79810192311', 'quickdmb88@gmail.com'),
(N'Орлова Екатерина Максимовна', N'Офис-менеджер', '+79990526708', 'madamorel@gmail.com'),
(N'Тарасов Андрей Игоревич', N'Тестировщик ПО', '+79210015642', 'tarasovandruha987@gmail.com'),
(N'Власова Юлия Сергеевна', N'Специалист по закупкам', '+79219870641', 'vlasova@gmail.com');

INSERT INTO Computers (operating_system, employee_id) VALUES
('Windows 11', 1),
('Windows 11 Pro', 2),
('Windows 10', 3),
('Windows 11', 4),
('Windows 11', 5),
('Windows 10 Pro', 6),
('Windows 11 Pro', 7),
('Windows 10', 8),
('Windows 11 Enterprise', 9),
('Windows 11 Enterprise', 10);

INSERT INTO Software (software_name, version, software_type, license_type) VALUES
(N'Microsoft Office', N'2016', N'Офисное ПО', N'Коммерческая'),
(N'Visual Studio Code', N'1.89', N'Среда разработки', N'Бесплатная'),
(N'Google Chrome', N'125', N'Браузер', N'Бесплатная'),
(N'Kaspersky Endpoint Security', N'12.0', N'Антивирус', N'Коммерческая'),
(N'Adobe Acrobat Reader', N'2024', N'Просмотр PDF', N'Бесплатная'),
(N'7-Zip', N'24.01', N'Архиватор', N'Бесплатная'),
(N'Telegram Desktop', N'5.1', N'Мессенджер', N'Бесплатная'),
(N'PyCharm Community', N'2024.1', N'Среда разработки', N'Бесплатная'),
(N'Microsoft SQL Server Management Studio', N'20', N'СУБД', N'Бесплатная');

INSERT INTO Components (component_type, model, manufacturer, specifications, computer_id) VALUES
(N'Процессор', N'Core i5-12400', N'Intel', N'6 ядер, 12 потоков', 1),
(N'Оперативная память', N'Kingston Fury', N'Kingston', N'16 GB DDR4', 1),
(N'Процессор', N'Ryzen 5 5600X', N'AMD', N'6 ядер, 12 потоков', 2),
(N'Видеокарта', N'RTX 3060', N'MSI', N'12 GB GDDR6', 2),
(N'Накопитель', N'970 EVO Plus', N'Samsung', N'512 GB SSD', 3),
(N'Оперативная память', N'HyperX Fury', N'Kingston', N'8 GB DDR4', 3),
(N'Блок питания', N'RM750x', N'Corsair', N'750W', 4),
(N'Видеокарта', N'RTX 3070', N'Gigabyte', N'8 GB GDDR6', 4),
(N'Процессор', N'Ryzen 7 5800X', N'AMD', N'8 ядер, 16 потоков', 5),
(N'Накопитель', N'SN770', N'WD', N'1 TB SSD', 5),
(N'Процессор', N'Core i5-11400', N'Intel', N'6 ядер, 12 потоков', 6),
(N'Оперативная память', N'Corsair Vengeance', N'Corsair', N'16 GB DDR4', 6),
(N'Процессор', N'Ryzen 5 3600', N'AMD', N'6 ядер, 12 потоков', 7),
(N'Накопитель', N'Barracuda', N'Seagate', N'1 TB HDD', 7),
(N'Процессор', N'Core i5-10400', N'Intel', N'6 ядер, 12 потоков', 8),
(N'Оперативная память', N'Patriot', N'Patriot', N'8 GB DDR4', 8),
(N'Видеокарта', N'RTX 3080', N'ASUS', N'10 GB GDDR6X', 9),
(N'Блок питания', N'Chieftec Proton', N'Chieftec', N'700W', 9),
(N'Процессор', N'Ryzen 9 5900X', N'AMD', N'12 ядер, 24 потока', 10),
(N'Накопитель', N'980 Pro', N'Samsung', N'2 TB SSD', 10);

INSERT INTO InstalledSoftware (computer_id, software_id, install_date) VALUES
(1, 1, '2025-05-01'),
(1, 3, '2025-05-01'),
(1, 4, '2025-05-02'),
(2, 1, '2025-05-03'),
(2, 2, '2025-05-03'),
(2, 8, '2025-05-03'),
(3, 1, '2025-05-04'),
(3, 5, '2025-05-04'),
(3, 6, '2025-05-04'),
(4, 1, '2025-05-05'),
(4, 3, '2025-05-05'),
(4, 7, '2025-05-05'),
(5, 1, '2025-05-06'),
(5, 4, '2025-05-06'),
(6, 2, '2025-05-06'),
(6, 8, '2025-05-06'),
(7, 3, '2025-05-07'),
(7, 6, '2025-05-07'),
(8, 1, '2025-05-07'),
(8, 5, '2025-05-07'),
(9, 2, '2025-05-08'),
(9, 9, '2025-05-08');
