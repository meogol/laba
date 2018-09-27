/*7) Запрос выводит количество складов для каждого менеджера*/
SELECT FIO, stock
from manager
inner join (select COUNT(stock_ID) as stock,
	manager_ID
	from manager_stock
	group by manager_ID) as t1 on ID=manager_ID
