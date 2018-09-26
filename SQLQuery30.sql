/*10) Увеличить на 1 количество всех товаров на складах с именем товара «фисташка» и
которые обслуживают магазины с именем «мир пустоты».*/
update stock_product
set count=count+1
where product_ID=(select product.ID
from product
where product.name='хлеб')
and stock_ID=(select stock_ID
from stock_magazine
where magazine_ID=(select ID
from magazine
where name='продукты'))