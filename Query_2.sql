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

--drop PROCEDURE UpdateFood
CREATE PROCEDURE [UpdateFood] -- SỬA MÓN ĂNS
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

--drop PROCEDURE DeleteFood
CREATE PROCEDURE [dbo].[DeleteFood] -- XÓA MÓN ĂN
    @FoodID INT
AS
BEGIN
    DELETE FROM [dbo].[Food]
    WHERE [ID] = @FoodID;
END
GO
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

--drop PROCEDURE Category_Update 
CREATE PROCEDURE Category_Update -- CHỈNH SỬA DANH MỤC
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

--drop PROCEDURE Category_Delete 
CREATE PROCEDURE Category_Delete -- XÓA DANH MỤC
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
--drop PROCEDURE Table_Insert 
CREATE PROCEDURE Table_Insert -- THÊM BÀN
    @Name nvarchar(1000),
    @Status int
AS
BEGIN
    INSERT INTO [Table] (Name, Status)
    VALUES (@Name, @Status);
END;
GO

--drop PROCEDURE Table_Update 
CREATE PROCEDURE Table_Update-- CHỈNH SỬA BÀN
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

--drop PROCEDURE Table_Delete 
CREATE PROCEDURE Table_Delete -- XÓA BÀN
    @ID int
AS
BEGIN
    DELETE FROM [Table]
    WHERE ID = @ID;
END
GO
--------------------ACCOUNT--------------------------
--SELECT * FROM [dbo].[Account] -- Xem danh sách tài khoản từ bảng Account
--GO
--drop PROCEDURE Account_Insert
create procedure Account_Insert -- THÊM TÀI KHOẢN
(
	@AccountName nvarchar(100),
	@DisplayName nvarchar(100),
	@Pass nvarchar(200)
)
as
begin
	if (not exists (select AccountName from Account where AccountName = @AccountName))
		insert into Account(AccountName,DisplayName,Password) values (@AccountName,@DisplayName, @Pass)
end
go

--drop PROCEDURE Account_Update
CREATE procedure Account_Update -- CẬP NHẬT TÀI KHOẢN
(
	@AccountName nvarchar(100),
	@DisplayName nvarchar(100),
	@Pass nvarchar(200)
)
as
begin
	update Account
	set AccountName = @AccountName, Password = @Pass , DisplayName = @DisplayName
	where AccountName = @AccountName
end
go

--drop PROCEDURE Account_Delete
CREATE PROCEDURE Account_Delete -- XÓA TÀI KHOẢN
    @AccountName nvarchar(100)
AS
BEGIN
    DELETE FROM Account
    WHERE AccountName = @AccountName
END
GO
-----------------------------------------------------
--SELECT AccountName,HashBytes('MD5', Password) as Password
--from Account
--go
---------------PASSWORD------------------------------
--drop PROCEDURE Password_Update
create procedure Password_Update -- CẬP NHẬT MẬT KHẨU
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
-----------------------BILLS-------------------------
--drop procedure Bills_Insert
create procedure Bills_Insert -- THÊM HÓA ĐƠN
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

--drop procedure Bills_GetByDate
create procedure Bills_GetByDate -- XUẤT DANH SÁCH HÓA ĐƠN THEO NGÀY
@date smalldatetime
as 
begin
	select * from Bills
	where CheckoutDate = @date
end
go
--drop procedure [CreateBillReport]
create procedure [CreateBillReport] -- THỐNG KÊ HÓA ĐƠN THEO KHOẢNG THỜI GIAN
	@StartDate DATE,
    @EndDate DATE
as 
begin
	select * from Bills
	where [CheckoutDate] >= @StartDate AND [CheckoutDate] <= @EndDate;
end
go
--EXEC [CreateBillReport] '2023-01-01', '2024-12-31';
--GO
--drop procedure BillDetail_Insert
create procedure BillDetail_Insert -- THÊM CHI TIẾT HÓA ĐƠN
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
create procedure BillDetail_Update -- CẬP NHẬT SỐ LƯỢNG TRONG CHI TIẾT HÓA ĐƠN
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
--drop procedure BillDetail_GetByIdWithFood
CREATE PROCEDURE BillDetail_GetByIdWithFood
@ID int
AS 
BEGIN
    SELECT bd.ID, f.Name AS FoodName, bd.Quantity, f.Price, b.Amount
    FROM BillDetails bd
    INNER JOIN Food f ON bd.FoodID = f.ID
    INNER JOIN Bills b ON b.ID = bd.InvoiceID
    WHERE bd.InvoiceID = @ID
END
GO

CREATE PROCEDURE Amount_GetById
@ID int
AS 
BEGIN
    SELECT b.Amount
    FROM Bills b
    WHERE b.ID = @ID
END
GO

CREATE PROCEDURE Date_GetById
@ID int
AS 
BEGIN
    SELECT b.CheckoutDate
    FROM Bills b
    WHERE b.ID = @ID
END
GO

CREATE PROCEDURE GetID
@ID int
AS 
BEGIN
    SELECT b.ID
    FROM Bills b
    WHERE b.ID = @ID
END
GO
--------------------TABLE_STATUS---------------------
--drop proc UpdateTableStatus
CREATE PROCEDURE UpdateTableStatus -- CẬP NHẬT TRẠNG THÁI BÀN
    @TableID INT,
    @IsOccupied BIT
AS
BEGIN
    UPDATE [dbo].[Table]
    SET [Status] = @IsOccupied
    WHERE [ID] = @TableID
END
GO
--------------------BILL_STATUS---------------------
--drop proc UpdateBillStatus
CREATE PROCEDURE UpdateBillStatus -- CẬP NHẬT TRẠNG THÁI BILL
    @BillID INT,
    @IsPaid BIT
AS
BEGIN
    UPDATE [dbo].[Bills]
    SET [Status] = @IsPaid
    WHERE [ID] = @BillID
END
GO
------------------AMOUNT----------------------------
--drop procedure Amount_Update
create procedure Amount_Update -- CẬP NHẬT TỔNG TIỀN 
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
-----------------------------------------------------

CREATE PROC USP_LOGIN
@userName nvarchar(100),
@passWord nvarchar(100)
AS 
BEGIN
	SELECT * FROM dbo.Account WHERE AccountName =@userName AND Password = @passWord
END
GO