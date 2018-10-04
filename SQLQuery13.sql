/*9) Вывести топ 3 менеджеров на чьих складах большего количества товаров.*/


select top(3) FIO, sum(Count) as SumCount
from stock_product
inner join manager_stock on manager_stock.stock_ID=stock_product.stock_ID
inner join manager on manager.ID=manager_stock.manager_ID
group by FIO, ID
order by sum(Count) DESC