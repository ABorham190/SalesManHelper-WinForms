
create Table Products
			(ProductID smallint primary key not null,
			ProductName nvarchar(20) not null,
			Brand nvarchar(20) not null,
			Unit smallint ,
			Type Tinyint ,
			BuyingPrice Decimal(10,2) not null,
			SalesPrice Decimal(10,2) not null,
			ProductionDate Date,
			ExpirationDate Date,
			Activeingrediant nvarchar(30),
			Concentration Tinyint ,
			Notes nvarchar(100)
			)



create Table ProductTypes(
ID int Primary Key Not null,
Name nvarchar (20) Not null,
State nvarchar(20) Not null
)
select * from ProductTypes;
select * from Products;
declare @Salary Decimal(6,2)=5000;
select @Salary;


Create Table People 
					(PersonID int Primary key,
					Name nvarchar(30) not null,
					Phone nvarchar(20) ,
					Email nvarchar (50),
					Address nvarchar(50),
					ImagePath nvarchar(100)
					)

					select * from People;
Create Table Customers 
						(CustomerID int primary key,
						PersonID int not null,
						CreditLimit Decimal(8,2) ,
						Debit decimal(8,2),
						)

Create table Users
					(UserID int Primary key ,
					PersonID int not null,
					UserName nvarchar(20) not null,
					Password nvarchar(20)not null
					)

Create Table SalesInvoices 
							(SalesInvoiceID int Primary key,
							CustomerID int not null,
							InvoiceDate Date not null,
							TotalValue Decimal(8,2) not null,
							AdditionalDiscount tinyint ,
							IsCash bit ,
							AmountPaid Decimal(8,2) ,
							AmountRest Decimal(8,2)
							)

Create table SalesItems
							(ID int primary key,
							ProductID int not null,
							SalesInvoiceID int not null,
							ItemPrice Decimal(8,2) not null)

							Create table Suppliers( SupplierID int primary key ,
							PersonID int not null,
							CompanyName nvarchar(50),
							TaxIDCard nvarchar(20) ,
							CommercialRegister nvarchar(20)
							)
select * from suppliers

Create Table Collection
						(

						   CollectionID int Primary key,
						   CustomerID int not null,
						   Amount Decimal(8,2) not null,
						   CollectionDate Date not null,
						   Type tinyint not null

						)

Create Table CollectionTypes
(
CollectionTypeID int primary key,
CollectionTypeName nvarchar(20) not null
)

select * from Collection;

Create Table Stock
					(ProductID int Primary key,
					 Amount int not null)


