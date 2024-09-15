select * from PurchaseItems;

Create Procedure SP_AddNewPurchaseItems
								@ProductID int,
								@PurchaseInvoiceID int,
								@NumberOfUnits int,
								@Price Decimal(8,2),
								
								@PurchaseItemID int output
									
				AS 
					Begin 
						Declare @TotalAmount Decimal(8,2)=(@NumberOfUnits*@Price);
						Insert into PurchaseItems(ProductID,PurchaseInvoiceID,NumberOfUnits,Price,TotalAmount) Values
									(@ProductID,@PurchaseInvoiceID,@NumberOfUnits,@Price,@TotalAmount);
						set @PurchaseItemID =SCOPE_IDENTITY();
					end

					select * from SalesInvoices;

					Create Procedure SP_SalesInvoices 
										@CustomerID int,
										@InvoiceDate Date,
										@TotalValue Decimal(8,2),
										@AdditionalDiscount tinyint,
										@IsCash bit,
										@AmountPaid decimal(8,2),
										@Rest decimal(8,2),
										@SalesInvoiceID int output

					As 
						Begin 
							Insert into SalesInvoices (CustomerID,InvoiceDate,TotalValue,AdditionalDiscount,
							IsCash,AmountPaid,AmountRest) Values
							(@CustomerID,@InvoiceDate,@TotalValue,@AdditionalDiscount,@IsCash,@AmountPaid,@Rest);
							Set @SalesInvoiceID = SCOPE_IDENTITY();
						end;

						select * from SalesItems;

						create Procedure SP_AddNewSalesItem
											@ProductID int,
											@SalesInvoiceID int,
											@NumberOfUnits smallInt,
											@ItemPrice Decimal(8,2),
											@TotalAmount Decimal(8,2),
											@ID int output

											AS
											Begin
												Insert into SalesItems (ProductID,SalesInvoiceID,NumberOfUnits,ItemPrice,
												TotalAmount)values 
												(@ProductID,@SalesInvoiceID,@NumberOfUnits,@ItemPrice,@TotalAmount);
												Set @ID=SCOPE_IDENTITY();
											end;
select * from Stock;
Create Procedure SP_AddProductToStock
							@ProductID int,
							@Amount int ,
							@ExpirationDate date,
							@ID int output
					As
						Begin 
							Insert into Stock (ProductID,Amount,ExpirationDate) Values
												(@ProductID,@Amount,@ExpirationDate);
							set @ID = SCOPE_IDENTITY();
						end ;

						select * from Suppliers;

						Create Procedure SP_AddNewSupplier
													@PersonID int,
													@CompanyName nvarchar(50),
													@TaxIDCard nvarchar(50),
													@CommercialRegister nvarchar(50),
													@SupplierID int output
								As 
									Begin 
										Insert into Suppliers(PersonID,CompanyName,TaxIDCard,CommercialRegister) Values 
											(@PersonID,@CompanyName,@TaxIDCard,@CommercialRegister);
											Set @SupplierID = SCOPE_IDENTITY();
									end;


									select * from Users;
				Create Procedure SP_AddNewUser 
									@PersonID int,
									@UserName nvarchar(20),
									@Password nvarchar(20),
									@IsActive bit ,
									@UserID int output

									As 
										begin	
											Insert into Users(PersonID,UserName,Password,IsActive)values
											(@PersonID,@UserName,@Password,@IsActive);
											Set @UserID=SCOPE_IDENTITY();
										end;




