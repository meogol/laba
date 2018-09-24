SELECT (select FIO
		from manager
		where ID=manager_ID),
 COUNT(stock_ID) as stock
from manager_stock
group by manager_ID
/*	7) Запрос выводит количество складов для каждого менеджера*/