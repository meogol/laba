/*10) Увеличить на 1 количество всех товаров на складах с именем товара «фисташка» и
которые обслуживают магазины с именем «мир пустоты».*/

update stock_product
set count=count+1
from (select product.ID as pID, t1.stock_ID as sID
	from product
	inner join (select stock_ID, magazine_ID
		from magazine 
		inner join stock_magazine on magazine.name='продукты' and magazine.ID=stock_magazine.magazine_ID
		) as t1 on product.name='хлеб') as t2
where stock_product.product_ID=t2.pID and stock_product.stock_ID=t2.sID
