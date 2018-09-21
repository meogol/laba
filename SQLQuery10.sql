/*5) Запрос выводит минимальную цену для каждого типа товара.*/
SELECT type_product_ID, min(price) as min
from product, [type product]
group by type_product_ID