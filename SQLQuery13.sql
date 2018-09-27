/*	9) Вывести топ 3 менеджеров на чьих складах большего количества товаров.*/

select FIO, Count
from (
	select TOP(3) sum(count) as Count,stock_ID
	from stock_product
	group by stock_ID) as t1
inner join (
	select manager.FIO, manager_stock.stock_ID
	from manager 
	inner join manager_stock on manager.ID=manager_stock.manager_ID
) as t2 on t1.stock_ID=t2.stock_ID


