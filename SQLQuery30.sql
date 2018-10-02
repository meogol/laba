/*10) Увеличить на 1 количество всех товаров на складах с именем товара «фисташка» и
которые обслуживают магазины с именем «мир пустоты».*/
update stock_product
set count=count+1
from product
inner join magazine on magazine.name='продукты' and product.name='хлеб'
inner join stock_magazine on stock_magazine.magazine_ID= magazine.ID
where stock_product.stock_ID=stock_magazine.stock_ID and stock_product.product_ID=product.ID
