/*8) Запрос выводит менеджеров, чьи склады обслуживюат более одного магазина.*/

select (select FIO
		from manager
		where ID=manager_stock.manager_ID) as FIO,
		 COUNT(magazine_ID) as [count magazine]
from stock_magazine inner join manager_stock
on stock_magazine.stock_ID=manager_stock.stock_ID
group by manager_ID
having COUNT(magazine_ID)>1

