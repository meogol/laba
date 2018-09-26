/*3) Запрос, который выводит название товара, название типа и название производителя
тех товаров цена которых больше 50*/
SELECT name, manufacturer, Info
FROM product 
inner join [type product]
on type_product_ID=[type product].ID
WHERE price>50