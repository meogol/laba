/****** Скрипт для команды SelectTopNRows из среды SSMS  ******/
SELECT TOP (1000) [product_ID]
      ,[stock_ID]
      ,[count]
  FROM [Lab5].[dbo].[stock_product]