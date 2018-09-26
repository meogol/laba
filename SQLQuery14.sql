/*8) Запрос выводит менеджеров, чьи склады обслуживюат более одного магазина.*/

/*select (select FIO
		from manager
		where ID=manager_stock.manager_ID) as FIO,
		 COUNT(magazine_ID) as [count magazine]
from stock_magazine inner join manager_stock
on stock_magazine.stock_ID=manager_stock.stock_ID
group by manager_ID
having COUNT(magazine_ID)>1*/

select FIO,CountMagazine
from (select FIO, stock_ID
from manager 
inner join  manager_stock
on ID=manager_ID) as t1
inner join (select stock_ID, COUNT(magazine_ID) as CountMagazine
from stock_magazine
group by stock_ID
having COUNT(magazine_ID)>1) as t2
on t1.stock_ID=t2.stock_ID

