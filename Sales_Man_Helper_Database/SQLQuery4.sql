select * from Collection;

Create Procedure SP_AddNewCollection 
					@CustomerID int ,
					@Amount Decimal(8,2),
					@CollectionDate Date ,
					@CollectionType tinyint ,
					@CollectionID int output
		
		As 
			Begin
				Insert into Collection (CustomerID,Amount,CollectionDate,Type)
					values (@CustomerID,@Amount,@CollectionDate,@CollectionType);
				set @CollectionID=SCOPE_IDENTITY();
			end



			select * from Customers;
			create Procedure SP_AddNewCustomer
								@PersonID int ,
								@CreditLimit Decimal(8,2),
								@Debit Decimal(8,2),
								@CustomerID int output
			as	
				begin 
					Insert into Customers(PersonID,CreditLimit,Debit) Values
											(@PersonID,@CreditLimit,@Debit);
					Set @CustomerID=SCOPE_IDENTITY();
				end

				Select * from People;
				Create Procedure SP_AddNewPerson
									@Name nvarchar(100),
									@Phone nvarchar(30),
									@Emil varchar(100),
									@Address nvarchar(200),
									@ImagePath nvarchar(200),
									@PersonID int output

						As 
							begin 
								Insert into People (Name,Phone,Email,Address,ImagePath) Values
													(@Name,@Phone,@Emil,@Address,@ImagePath);
								set @PersonID=SCOPE_IDENTITY();
							end;

							select * from Products;
							Create Procedure SP_AddNewProduct
												@ProductName nvarchar(100),
												@Brand nvarchar(30),
												@Unit smallInt ,
												@Type tinyInt ,
												@BuyingPrice Decimal(10,2),
												@SalesPrice Decimal(10,2),
												@ProductionDate Date,
												@ExpirationDate Date,
												@ActiveIngrediant nvarchar(50),
												@Concentration Tinyint ,
												@Notes nvarchar(100),
												@ProductID int output
									as 
										Begin	
											Insert into Products (ProductName,Brand,Unit,Type,BuyingPrice,SalesPrice,
											ProductionDate,ExpirationDate,Activeingrediant,Concentration,Notes) Values
											(@ProductName,@Brand,@Unit,@Type,@BuyingPrice,@SalesPrice,@ProductionDate,
											@ExpirationDate,@ActiveIngrediant,@Concentration,@Notes);
											Set @ProductID=SCOPE_IDENTITY();
										end;
										select * from PurchaseInvoices;

										Create Procedure SP_AddNewPuchaseInvoice
															@SupplierID int,
															@PurchaseInvoiceTotalValue decimal(8,2),
															@AdditionalDiscount tinyint ,
															@PaidAmount decimal(8,2),
															@RestAmount decimal(8,2),
															@PurchaseInvoiceID int output

								As
									Begin
										Insert into PurchaseInvoices(SupplierID,PurchaseInvoiceTotalValue,
										AdditionalDiscount,PaidAmount,RestAmount) Values
										(@SupplierID,@PurchaseInvoiceTotalValue,@AdditionalDiscount,
										@PaidAmount,@RestAmount);

										set @PurchaseInvoiceID=SCOPE_IDENTITY();
									end;

									select * from PurchaseItems;

