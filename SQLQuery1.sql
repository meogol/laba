SELECT manager_ID, COUNT(stock_ID)
from manager_stock
group by manager_ID