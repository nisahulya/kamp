
select Products.ProductName, sum([Order Details].UnitPrice*Quantity) as TotalProceed from [Order Details] 
Join Products on Products.ProductID=[Order Details].ProductID
Group By [Order Details].ProductID,Products.ProductName
