SELECT manager_ID, COUNT(stock_ID)
from manager_stock
group by manager_ID
/*	7) Запрос выводит количество складов для каждого менеджера*/