﻿/*2) Наполнить бд данных.*/
INSERT INTO manager(ID,FIO) 
VALUES
(0,'Козлов Юрий Александрович'),
(1,'Леонтьев Юрий Владимирович'),
(2,'Трошин Михаил Алексеевич')

INSERT INTO magazine(ID,name) 
VALUES
(0,'Глобус'),
(1,'Магнит'),
(2,'Алекс'),
(3,'Квартал'),
(4,'Продукты'),
(5,'Дикси'),
(6, 'DNS')

INSERT INTO stock(ID,name) 
VALUES
(0,'склад 1'),
(1,'склад 2'),
(2,'склад 3'),
(3,'склад 4'),
(4,'склад 5')

INSERT INTO [type product](ID,Info) 
VALUES 
(0,'Еда'),
(1,'Бытовая техника'),
(2,'Вычислительная техника'),
(3,'Посуда')

INSERT INTO product(ID,manufacturer, name,price, type_product_ID) 
VALUES
(0,'Производитель 1','Сухарики', 10, 0),
(1,'Производитель 2','Чипсы', 40,0),
(2,'Производитель 3','Хлеб', 15,0),
(3,'Производитель 1','Крекер', 7,0),
(4,'Производитель 2','Рис', 20,0),
(5,'Производитель 1','Гречка', 40,0),
(6,'Производитель 4','Стиральная машина', 8000,1),
(7,'Производитель 3','Посудомоечная машина', 15000,1),
(8,'Производитель 1','Ноутбук', 25000,2),
(9,'Производитель 4','Стационарный компьютер', 30000,2),
(10,'Производитель 2','Мультиварка', 3000,1),
(11,'Производитель 6','Тарелки', 100,3),
(12,'Производитель 7','Телефон', 2000,2),
(13,'Производитель 3','Макароны', 15,0),
(14,'Производитель 6','Вилки', 30,3),
(15,'Производитель 5','Холодильник', 35000,1),
(16,'Производитель 8','Ложки', 20,3)

INSERT INTO stock_product(stock_ID,product_ID, count) 
VALUES 
(0,4,100),/*крупы*/
(0,5,100),
(0,13,100),
(1,1,50),/*снеки*/
(1,2,50),
(1,3,120),
(2,6,30),/*быт техника*/
(2,7,25),
(2,10,40),
(2,15,20),
(3,8,40),/*выч техника*/
(3,9,20),
(3,12,50),
(4,11,300),/*посуда*/
(4,14,400),
(4,16,400)

INSERT INTO stock_magazine(magazine_ID,stock_ID) 
VALUES 
(0,0),
(0,1),
(0,2),
(0,3),
(0,4),
(1,0),
(1,1),
(1,4),
(2,0),
(2,1),
(3,0),
(3,1),
(3,4),
(4,0),
(4,1),
(5,0),
(5,1),
(5,4),
(6,2),
(6,3)

INSERT INTO manager_stock(manager_ID,stock_ID) 
VALUES 
(0,0),
(0,1),
(1,2),
(2,3),
(2,4)