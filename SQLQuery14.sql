/*8) Запрос выводит менеджеров, чьи склады обслуживюат более одного магазина.*/

select FIO, CountMagazine
from(
	select COUNT(magazine_ID) as CountMagazine, manager_ID
	from stock_magazine 
	inner join manager_stock on stock_magazine.stock_ID=manager_stock.stock_ID
	group by manager_stock.manager_ID
	having COUNT(magazine_ID)>1) as t1
inner join manager on manager.ID=t1.manager_ID