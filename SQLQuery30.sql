﻿	/*10) Увеличить на 1 количество всех товаров на складах с именем товара «фисташка» и
которые обслуживают магазины с именем «мир пустоты».*/
update stock_product
set count=count+1
from stock_product
inner join product on product.name='хлеб' and product.ID=stock_product.product_ID
inner join stock_magazine on stock_product.stock_ID=stock_magazine.stock_ID and stock_magazine.magazine_ID=(
		select ID
		from magazine
		where magazine.name='продукты')
