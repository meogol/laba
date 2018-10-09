/*5) Запрос выводит минимальную цену для каждого типа товара.*/
SELECT min(price) as min,
(select Info
from [type product]
where [type product].ID=product.type_product_ID) as name

from product 
group by type_product_ID