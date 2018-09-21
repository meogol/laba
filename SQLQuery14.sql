/*8) Запрос выводит менеджеров, чьи склады обслуживюат более одного магазина.*/
select
	(SELECT count(stock_ID)
	from stock_magazine
	group by stock_ID
	having stock_ID=manager_stock.stock_ID and count(stock_ID)>1) as magazine,
	(select FIO
	from manager
	where ID=manager_stock.manager_ID)
from manager_stock
