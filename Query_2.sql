use [RestaurantManagement]
go
------------------------FOOD-------------------------
--SELECT * FROM Food -- Xem món ăn từ bảng Food
--GO
--drop PROCEDURE InsertFood
CREATE PROCEDURE [InsertFood] -- THÊM MÓN ĂN
@Name nvarchar(3000), 
@FoodCategoryID int, 
@Price int
AS
	INSERT INTO Food (Name, FoodCategoryID, Price)
	VALUES ( @Name, @FoodCategoryID, @Price)
go

--EXEC [dbo].[InsertFood] 
--    @Name = N'Xoài',
--    @FoodCategoryID = 5,
--    @Price = 10000;
--GO

--drop PROCEDURE UpdateFood
CREATE PROCEDURE [UpdateFood] -- Sửa món ăn từ bảng Food dựa trên ID
@ID int output,
@Name nvarchar(3000), 
@FoodCategoryID int, 
@Price int
as
UPDATE [Food] set 
[Name] = @Name, [FoodCategoryID] = @FoodCategoryID,[Price]=@Price
where ID = @ID

if @@ERROR <> 0
return 0
else
return 1
GO

--EXEC [dbo].[UpdateFood] 
--    @ID = 1,
--    @Name = N'Gỏi cuốn',
--    @FoodCategoryID = 1,
--    @Price = 25000;

--drop PROCEDURE DeleteFood
CREATE PROCEDURE [dbo].[DeleteFood] -- Xóa món ăn từ bảng Food dựa trên ID
    @FoodID INT
AS
BEGIN
    DELETE FROM [dbo].[Food]
    WHERE [ID] = @FoodID;
END
GO

--EXEC [dbo].[DeleteFood] @FoodID = 11
--------------------CATEGORY-------------------------
--SELECT * FROM Category -- Xem danh mục món ăn từ bảng Category
--GO
--drop PROCEDURE Category_Insert 
CREATE PROCEDURE Category_Insert -- THÊM DANH MỤC
    @Name nvarchar(1000),
    @Type int
AS
BEGIN
    INSERT INTO Category (Name, Type)
    VALUES (@Name, @Type);
END;
GO
--EXECUTE Category_Insert @Name = 'Danh mục mới', @Type = 1;

--drop PROCEDURE Category_Update -- CHỈNH SỬA DANH MỤC
CREATE PROCEDURE Category_Update
    @ID int,
    @Name nvarchar(1000),
    @Type int
AS
BEGIN
    UPDATE Category
    SET Name = @Name, Type = @Type
    WHERE ID = @ID;
END;
GO
--EXECUTE Category_Update @ID = 1, @Name = 'Danh mục sửa', @Type = 2;

--drop PROCEDURE Category_Delete -- XÓA DANH MỤC
CREATE PROCEDURE Category_Delete
    @ID int
AS
BEGIN
    DELETE FROM Category
    WHERE ID = @ID;
END
GO
--EXECUTE Category_Delete @ID = 1;
-----------------------TABLE-------------------------
--SELECT * FROM [dbo].[Table] -- Xem bàn từ bảng Table
--GO
--drop PROCEDURE Table_Insert -- THÊM BÀN
CREATE PROCEDURE Table_Insert
    @Name nvarchar(1000),
    @Status int
AS
BEGIN
    INSERT INTO [Table] (Name, Status)
    VALUES (@Name, @Status);
END;
GO
--EXECUTE Table_Insert @Name = 'Bàn mới', @Status = 1;

--drop PROCEDURE Table_Update -- CHỈNH SỬA BÀN
CREATE PROCEDURE Table_Update
    @ID int,
    @Name nvarchar(1000),
    @Status int
AS
BEGIN
    UPDATE [Table]
    SET Name = @Name, Status = @Status
    WHERE ID = @ID;
END;
GO
--EXECUTE Table_Update @ID = 1, @Name = 'Bàn sửa', @Status = 2;

--drop PROCEDURE Table_Delete -- XÓA BÀN
CREATE PROCEDURE Table_Delete
    @ID int
AS
BEGIN
    DELETE FROM [Table]
    WHERE ID = @ID;
END
GO
--EXECUTE Table_Delete @ID = 1;
--------------------ACCOUNT--------------------------
--SELECT * FROM [dbo].[Account] -- Xem danh sách tài khoản từ bảng Account
--GO
--drop PROCEDURE Account_Insert
create procedure Account_Insert
(
	@AccountName nvarchar(100),
	@Pass nvarchar(200)
)
as
begin
	if (not exists (select AccountName from Account where AccountName = @AccountName))
		insert into Account(AccountName,Password) values (@AccountName, @Pass)
end
go

--DECLARE @AccountNameToAdd nvarchar(100) = 'new_account';
--DECLARE @PasswordToAdd nvarchar(200) = 'new_password';
--EXEC Account_Insert @AccountNameToAdd, @PasswordToAdd;

--drop PROCEDURE Account_Update
create procedure Account_Update
(
	@AccountName nvarchar(100),
	@Pass nvarchar(200)
)
as
begin
	update Account
	set AccountName = @AccountName, Password = @Pass
	where AccountName = @AccountName
end
go

--DECLARE @AccountNameToUpdate nvarchar(100) = 'existing_account';
--DECLARE @NewPassword nvarchar(200) = 'new_password';
--EXEC Account_Update @AccountNameToUpdate, @NewPassword;

--drop PROCEDURE Account_Delete
CREATE PROCEDURE Account_Delete
    @AccountName nvarchar(100)
AS
BEGIN
    DELETE FROM Account
    WHERE AccountName = @AccountName
END
GO

--DECLARE @AccountNameToDelete nvarchar(100) = 'example_account';
--EXEC Account_Delete @AccountNameToDelete;
-----------------------------------------------------
--SELECT AccountName,HashBytes('MD5', Password) as Password
--from Account
--go
---------------PASSWORD------------------------------
--drop PROCEDURE Password_Update
create procedure Password_Update
(
	@AccountName nvarchar(100),
	@Pass nvarchar(200)
)
as
begin
	update Account
	set Password = @Pass
	where AccountName = @AccountName
end
go

--DECLARE @AccountNameToUpdate nvarchar(100) = 'existing_account';
--DECLARE @NewPassword nvarchar(200) = 'new_password';
--EXEC Password_Update @AccountNameToUpdate, @NewPassword;
-----------------------BILLS-------------------------
--drop procedure BillDetail_Insert
create procedure BillDetail_Insert
@id int output,
@InvoiceID int,
@FoodID int,
@Quantity int
as
begin
	insert into BillDetails(InvoiceID, FoodID, Quantity) values (@InvoiceID, @FoodID, @Quantity)
	SELECT @id = SCOPE_IDENTITY()
end
go
--drop procedure BillDetail_Update
create procedure BillDetail_Update
@ID int,
@BillId int,
@Quantity int
as
begin
	update BillDetails
	set Quantity = @Quantity
	where ID = @ID and InvoiceID = @BillId
end
go
--drop procedure Bills_Insert
create procedure Bills_Insert
@id int output,
@Name nvarchar(1000),
@TableID int,
@Amount int,
@Status bit,
@CheckoutDate smalldatetime,
@Account nvarchar(100)
as
begin
	insert into Bills(Name, TableID, Amount, Status, CheckoutDate, Account) values (@Name, @TableID, @Amount, @Status,@CheckoutDate, @Account)
	SELECT @id = SCOPE_IDENTITY()
end
go
--------------------TABLE_STATUS---------------------
--drop proc UpdateTableStatus
CREATE PROCEDURE UpdateTableStatus
    @TableID INT,
    @IsOccupied BIT
AS
BEGIN
    UPDATE [dbo].[Table]
    SET [Status] = @IsOccupied
    WHERE [ID] = @TableID
END
GO
--DECLARE @TableID INT = 1;
--DECLARE @IsOccupied BIT = 1;
--EXEC UpdateTableStatus @TableID, @IsOccupied;
--------------------BILL_STATUS---------------------
--drop proc UpdateBillStatus
CREATE PROCEDURE UpdateBillStatus
    @BillID INT,
    @IsPaid BIT
AS
BEGIN
    UPDATE [dbo].[Bills]
    SET [Status] = @IsPaid
    WHERE [ID] = @BillID
END
GO
--DECLARE @BillID INT = 1;
--DECLARE @IsPaid BIT = 1;
--EXEC UpdateBillStatus @BillID, @IsPaid;
------------------AMOUNT----------------------------
--drop procedure Amount_Update
create procedure Amount_Update
@ID int
as
begin
	UPDATE dbo.Bills 
	SET Amount = (	SELECT SUM(Food.Price*BillDetails.Quantity) 
					FROM dbo.BillDetails, dbo.Food 
					WHERE BillDetails.InvoiceID=Bills.ID and Food.ID = BillDetails.FoodID)
	where Bills.ID = @ID
end
go
--DECLARE @ID INT = 1; -- Thay đổi giá trị ID tương ứng với hóa đơn cần cập nhật tổng số tiền
--EXEC Amount_Update @ID;
-----------------------------------------------------