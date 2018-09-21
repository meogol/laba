/*3) Запрос, который выводит название товара, название типа и название производителя
тех товаров цена которых больше 50*/
SELECT name, manufacturer, Info
FROM product, [type product]
WHERE price>50