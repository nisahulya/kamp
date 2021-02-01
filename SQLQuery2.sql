 --Select
--ANSI
Select ContactName Adi, CompanyName Sirketadi,City Sehir from Customers

Select * from Customers where City = 'Berlin'

--case insensitive
select * from Products where CategoryId=1 or CategoryId=3

select * from Products where CategoryId=1 and UnitPrice>=10

select * from Products where CategoryID=1 order by UnitPrice desc

select count(*) from Products 

select CategoryID,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from products inner join Categories
on Products.CategoryID = Categories.CategoryId
where Products.UnitPrice>10

--DTO Data Transformation object

select * from Products p left join [Order Details] od
on p.ProductId = od.ProductId

select * from Customers c left join Orders o on c.CustomerID = o.CustomerID where o.CustomerID is null
