/*	9) Вывести топ 3 менеджеров на чьих складах большего количества товаров.*/
select (select FIO
				from manager
				where ID=manager_stock.manager_ID) as FIO,
(SELECT  sum(count)
from stock_product
where stock_product.stock_ID=manager_stock.stock_ID
group by stock_ID
) as count
from manager_stock order by 2 DESC
SET ROWCOUNT 3

