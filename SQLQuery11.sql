/*6) Запрос выводит минимальную цену для каждого типа товара сумма цен,
больше 1000*/
SELECT min(price) as [min price], 
(select Info
from [type product]
where [type product].ID=product.type_product_ID) as type
from product inner join [type product]
on type_product_ID=[type product].ID
group by type_product_ID
HAVING SUM(price) > 1000
