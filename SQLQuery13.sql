/*9) Вывести топ 3 менеджеров на чьих складах большего количества товаров.*/
SELECT FIO, stock
from manager
inner join (
	select top(3)  sum(count) as stock, manager_stock.manager_ID
	from stock_product
	inner join manager_stock on stock_product.stock_ID= manager_stock.stock_ID
	group by manager_stock.manager_ID
	order by stock DESC) as t1 on manager.ID=t1.manager_ID
