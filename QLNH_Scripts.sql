use [RestaurantManagement]
go
------------------------FOOD-------------------------
CREATE PROCEDURE [InsertFood] -- THÊM MÓN ĂN
@Name nvarchar(3000), 
@FoodCategoryID int, 
@Price int
AS
	INSERT INTO Food (Name, FoodCategoryID, Price)
	VALUES ( @Name, @FoodCategoryID, @Price)
go

--EXEC InsertFood 
--   @Name = 'Mon an moi',
--   @FoodCategoryID = 1,
--   @Price = 10000;

CREATE PROCEDURE [UpdateFood] -- SỬA MÓN ĂN
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

--DECLARE @ID int, @Name nvarchar(3000), @FoodCategoryID int, @Price int;
--SET @ID = 26; -- ID của món ăn cần cập nhật
--SET @Name = N'Tên món ăn mới';
--SET @FoodCategoryID = 2; -- ID của danh mục thức ăn mới
--SET @Price = 15000; -- Giá mới
--EXEC UpdateFood 
--   @ID = @ID OUTPUT,
--   @Name = @Name,
--   @FoodCategoryID = @FoodCategoryID,
--   @Price = @Price;

CREATE PROCEDURE [dbo].[DeleteFood] -- XÓA MÓN ĂN
    @FoodID INT
AS
BEGIN
    DELETE FROM [dbo].[Food]
    WHERE [ID] = @FoodID;
END
GO

--DECLARE @FoodID INT;
--SET @FoodID = 26; -- ID của món ăn cần xóa
--EXEC DeleteFood 
--   @FoodID = @FoodID;
--------------------CATEGORY-------------------------
CREATE PROCEDURE Category_Insert -- THÊM DANH MỤC
    @Name nvarchar(1000),
    @Type int
AS
BEGIN
    INSERT INTO Category (Name, Type)
    VALUES (@Name, @Type);
END;
GO

--EXEC Category_Insert
--    @Name = N'Tên danh mục',
--    @Type = 1;


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
CREATE PROCEDURE Table_Insert -- THÊM BÀN
@Name nvarchar(1000),
@Status int
AS
BEGIN
DECLARE @TableCount int;
SELECT @TableCount = COUNT(*) FROM [Table];
IF @TableCount < 50
	BEGIN
		INSERT INTO [Table] (Name, Status)
		VALUES (@Name, @Status);
	END
ELSE
	BEGIN
		PRINT N'Đã đạt đến giới hạn số lượng bàn. Không thể thêm bàn mới.';
	END
END;
GO
--EXEC Table_Insert
--    @Name = N'Tên bàn',
--    @Status = 1;

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
--EXEC Table_Update
--    @ID = 1,
--    @Name = N'Tên bàn mới',
--    @Status = 2;

CREATE PROCEDURE Table_Delete -- XÓA BÀN
@ID int
AS
	BEGIN
		DELETE FROM [Table]
		WHERE ID = @ID;
	END
GO
--EXEC Table_Delete
--    @ID = 1;
--------------------ACCOUNT--------------------------
CREATE PROCEDURE [dbo].[InsertAccount] -- Thêm tài khoản
    @AccountName NVARCHAR(100),
    @DisplayName NVARCHAR(100),
    @Password NVARCHAR(200),
    @RoleName NVARCHAR(1000)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @RoleID INT;
    SELECT @RoleID = ID
    FROM [dbo].[Role]
    WHERE RoleName = @RoleName;

 
    INSERT INTO [dbo].[Account] (AccountName, DisplayName, Password)
    VALUES (@AccountName, @DisplayName, @Password);

    INSERT INTO [dbo].[RoleAccount] (RoleID, AccountName, Actived)
    VALUES (@RoleID, @AccountName, 1); -- Giả sử Actived = 1 cho tài khoản mới

    SELECT N'Tài khoản đã được thêm thành công' AS Message;
END
GO 
--EXEC [dbo].[InsertAccount]
--    @AccountName = N'Tên tài khoản',
--    @DisplayName = N'Tên hiển thị',
--    @Password = N'Mật khẩu',
--    @RoleName = N'Tên vai trò';

CREATE PROCEDURE [dbo].[UpdateAccount]
    @AccountName NVARCHAR(100),
    @DisplayName NVARCHAR(100),
    @Password NVARCHAR(200)
AS
BEGIN
    SET NOCOUNT ON;


    UPDATE [dbo].[Account]
    SET DisplayName = @DisplayName,
        Password = @Password
    WHERE AccountName = @AccountName;

    SELECT 'Thông tin tài khoản đã được cập nhật thành công' AS Message;
END
GO
--EXEC [dbo].[UpdateAccount]
--    @AccountName = N'Tên tài khoản',
--    @DisplayName = N'Tên hiển thị mới',
--    @Password = N'Mật khẩu mới';

CREATE PROCEDURE [dbo].[UpdateAccountWithRoleID] -- Cập nhật tài khoản
    @AccountName NVARCHAR(100),
    @DisplayName NVARCHAR(100),
    @Password NVARCHAR(200),
    @NewRoleID INT
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (
        SELECT 1
        FROM [dbo].[RoleAccount]
        WHERE AccountName = @AccountName
    )
    BEGIN
        UPDATE [dbo].[Account]
        SET DisplayName = @DisplayName,
            Password = @Password
        WHERE AccountName = @AccountName;
        UPDATE [dbo].[RoleAccount]
        SET RoleID = @NewRoleID
        WHERE AccountName = @AccountName;
        SELECT N'Thông tin tài khoản và RoleID đã được cập nhật thành công' AS Message;
    END
    ELSE
    BEGIN
        SELECT N'Không tìm thấy AccountName trong bảng RoleAccount' AS Message;
    END
END
GO
--EXEC [dbo].[UpdateAccountWithRoleID]
--    @AccountName = N'Tên tài khoản',
--    @DisplayName = N'Tên hiển thị mới',
--    @Password = N'Mật khẩu mới',
--    @NewRoleID = 2;

CREATE PROCEDURE [dbo].[DeleteAccountWithRole] -- Xóa tài khoản
    @AccountName NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @HashedPassword NVARCHAR(32);
    SELECT @HashedPassword = Password
    FROM [dbo].[Account]
    WHERE AccountName = @AccountName;
    IF @HashedPassword IS NOT NULL
    BEGIN
        DELETE FROM [dbo].[RoleAccount]
        WHERE AccountName = @AccountName;
        DELETE FROM [dbo].[Account]
        WHERE AccountName = @AccountName;
        SELECT N'Tài khoản đã được xóa thành công từ cả bảng Account và bảng RoleAccount' AS Message;
    END
    ELSE
    BEGIN
        SELECT N'Tài khoản không tồn tại' AS Message;
    END
END
GO
--EXEC [dbo].[DeleteAccountWithRole]
--    @AccountName = N'Tên tài khoản';
---------------PASSWORD------------------------------
CREATE PROCEDURE Password_Update -- CẬP NHẬT MẬT KHẨU
(
    @AccountName NVARCHAR(100),
    @Pass NVARCHAR(200)
)
AS
BEGIN
    SET NOCOUNT ON;

    

    UPDATE Account
    SET Password = @Pass
    WHERE AccountName = @AccountName;
END
GO
--EXEC Password_Update
--    @AccountName = N'Tên tài khoản',
--    @Pass = N'Mật khẩu mới';
-----------------------BILLS-------------------------
CREATE PROCEDURE Bills_Insert
    @id INT OUTPUT,
    @TableID INT,
    @Amount INT,
    @Status BIT,
    @CheckoutDate Date,
    @Account NVARCHAR(100)
AS
BEGIN
    DECLARE @Name NVARCHAR(1000)
    DECLARE @NextID INT
    SELECT @NextID = ISNULL(MAX(id), 0) + 1 FROM Bills
    SET @Name = N'Hóa đơn ' + CAST(@NextID AS NVARCHAR(10))
    INSERT INTO Bills (Name, TableID, Amount, Status, CheckoutDate, Account)
    VALUES (@Name, @TableID, @Amount, @Status, @CheckoutDate, @Account)
    SELECT @id = SCOPE_IDENTITY()
END
GO
--DECLARE @BillID INT;
--EXEC Bills_Insert
--    @id = @BillID OUTPUT,
--    @TableID = 1,
--    @Amount = 100,
--    @Status = 1,
--    @CheckoutDate = '2023-11-21',
--    @Account = N'Tên tài khoản';
--SELECT @BillID AS BillID;

create procedure Bills_GetByDate -- XUẤT DANH SÁCH HÓA ĐƠN THEO NGÀY
@date smalldatetime
as 
begin
	select * from Bills
	where CheckoutDate = @date
end
go
--EXEC Bills_GetByDate
--    @date = '2023-11-21';

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
--DECLARE @BillDetailID INT;
--EXEC BillDetail_Insert
--    @id = @BillDetailID OUTPUT,
--    @InvoiceID = 1,
--    @FoodID = 1,
--    @Quantity = 2;
--SELECT @BillDetailID AS BillDetailID;

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
--EXEC BillDetail_Update
--    @ID = 1,
--    @BillId = 1,
--    @Quantity = 3;

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
--EXEC BillDetail_GetByIdWithFood
--    @ID = 1;
------------GET_BY_ID_FOR_BILLDETAILS-----------------
CREATE PROCEDURE Amount_GetById
@ID int
AS 
BEGIN
    SELECT b.Amount
    FROM Bills b
    WHERE b.ID = @ID
END
GO
--EXEC Amount_GetById
--    @ID = 1;

CREATE PROCEDURE Date_GetById
@ID int
AS 
BEGIN
    SELECT b.CheckoutDate
    FROM Bills b
    WHERE b.ID = @ID
END
GO
--EXEC Date_GetById
--    @ID = 1;

CREATE PROCEDURE GetID
@ID int
AS 
BEGIN
    SELECT b.ID
    FROM Bills b
    WHERE b.ID = @ID
END
GO
--EXEC GetID
--    @ID = 1;
--------------------TABLE_STATUS---------------------
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
--EXEC UpdateTableStatus
--    @TableID = 1,
--    @IsOccupied = 1;
--------------------BILL_STATUS---------------------
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
--EXEC UpdateBillStatus
--    @BillID = 1,
--    @IsPaid = 1;
------------------AMOUNT----------------------------
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
--EXEC Amount_Update
--    @ID = 1;
-----------------------------------------------------
CREATE PROC USP_LOGIN
@userName nvarchar(100),
@passWord nvarchar(100)
AS 
BEGIN
	SELECT * FROM dbo.Account WHERE AccountName =@userName AND Password = @passWord
END
GO