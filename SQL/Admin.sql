﻿USE FINAL
GO

-- TẠO BẢNG
DROP TABLE IF EXISTS [ADMIN];
GO

CREATE TABLE [ADMIN] (
    ID NVARCHAR(MAX),
    EMAIL NVARCHAR(MAX),
    [PASSWORD] NVARCHAR(MAX),
    ACTIVE BIT
);
GO

-- TẠO SEQUENCE
DROP SEQUENCE IF EXISTS ADMIN_SEQ;
GO
CREATE SEQUENCE ADMIN_SEQ
    START WITH 1
    INCREMENT BY 1
    MINVALUE 1
    NO MAXVALUE
    CACHE 10;
GO

-- HÀM TẠO BẢNG TỪ CHUỖI
CREATE OR ALTER FUNCTION GETTABLE_ADMIN (@EMAIL NVARCHAR(MAX))
RETURNS TABLE
AS
RETURN
(
    SELECT	*
    FROM ADMIN ACC 
    WHERE ACC.EMAIL = @EMAIL
);
GO

-- HÀM TẠO BẢNG TỪ CHUỖI
CREATE OR ALTER FUNCTION GETTABLE_ADMIN_VI (@EMAIL NVARCHAR(MAX))
RETURNS TABLE
AS
RETURN
(
    SELECT	ACC.ID AS ID
			,ACC.EMAIL AS EMAIL
			,ACC.[PASSWORD] AS [MẬT KHẨU]
			,ACC.ACTIVE AS [KÍCH HOẠT]
    FROM ADMIN ACC 
    WHERE ACC.EMAIL = @EMAIL
);
GO



-- HÀM KIỂM TRA INSERT
CREATE OR ALTER FUNCTION CHECK_INSERT_ADMIN(@EMAIL NVARCHAR(MAX))
RETURNS BIT
AS
BEGIN
    DECLARE @RESULT BIT = 0;
    IF NOT EXISTS (SELECT 1 FROM ADMIN WHERE EMAIL = @EMAIL)
        SET @RESULT = 1;
    RETURN @RESULT;
END;
GO

-- HÀM KIỂM TRA UPDATE
CREATE OR ALTER FUNCTION CHECK_UPDATE_ADMIN(@ID NVARCHAR(10), @EMAIL NVARCHAR(MAX))
RETURNS BIT
AS
BEGIN
    DECLARE @RESULT BIT = 0;
    IF NOT EXISTS (SELECT 1 FROM ADMIN WHERE EMAIL = @EMAIL AND ID <> @ID)
        SET @RESULT = 1;
    RETURN @RESULT;
END;
GO

-- HÀM KIỂM TRA DELETE
CREATE OR ALTER FUNCTION CHECK_DELETE_ADMIN()
RETURNS BIT
AS
BEGIN
    RETURN 1;
END;
GO

-- HÀM INSERT
CREATE OR ALTER PROCEDURE INSERT_ADMIN 
    @EMAIL NVARCHAR(MAX),
    @PASSWORD NVARCHAR(MAX),
    @ACTIVE BIT
AS
BEGIN
    IF DBO.CHECK_INSERT_ADMIN(@EMAIL) = 1
    BEGIN
        DECLARE @ID NVARCHAR(MAX);
        SET @ID = CONCAT('ACC', FORMAT(NEXT VALUE FOR ADMIN_SEQ, '00000000'));
        INSERT INTO ADMIN (
						ID
						,EMAIL
						,[PASSWORD]
						,ACTIVE)
        VALUES 
					(@ID
					,@EMAIL
					,CONVERT(NVARCHAR(MAX), HASHBYTES('SHA2_512',@PASSWORD), 2)
					,@ACTIVE);
		SELECT 1 AS RESULT;
    END
    ELSE
    BEGIN
        THROW 50001, 'EMAIL ALREADY EXISTS', 1;
    END
END;
GO

-- HÀM UPDATE
CREATE OR ALTER PROCEDURE UPDATE_ADMIN 
    @ID NVARCHAR(MAX),
    @EMAIL NVARCHAR(MAX),
    @PASSWORD NVARCHAR(MAX),
    @ACTIVE BIT
AS
BEGIN
    IF DBO.CHECK_UPDATE_ADMIN(@ID, @EMAIL) = 1
    BEGIN
        UPDATE ADMIN
        SET EMAIL = @EMAIL,
            [PASSWORD] = CONVERT(NVARCHAR(MAX), HASHBYTES('SHA2_512',@PASSWORD), 2),
            ACTIVE = @ACTIVE
        WHERE ID = @ID;
    END
    ELSE
    BEGIN
        THROW 50002, 'EMAIL ALREADY EXISTS FOR ANOTHER USER', 1;
    END;
END;
GO

-- HÀM DELETE
CREATE OR ALTER PROCEDURE DELETE_ADMIN 
    @ID NVARCHAR(MAX)
AS
BEGIN
    IF DBO.CHECK_DELETE_ADMIN() = 1
    BEGIN
        DELETE FROM ADMIN WHERE ID = @ID;
    END
    ELSE
    BEGIN
        THROW 50003, 'DELETE OPERATION NOT ALLOWED', 1;
    END
END;
GO

CREATE OR ALTER PROCEDURE TRYLOGIN_ADMIN
    @EMAIL NVARCHAR(MAX),
    @PASSWORD NVARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;

	DECLARE @MYPASS NVARCHAR(MAX);

    SELECT @MYPASS = [PASSWORD]
    FROM ADMIN
    WHERE EMAIL = @EMAIL;

	IF CONVERT(NVARCHAR(MAX), HASHBYTES('SHA2_512', @PASSWORD), 2) = @MYPASS
	BEGIN
		SELECT 1 AS Result;
	END
	ELSE
	BEGIN
		THROW 50005, N'MẬT KHẨU KHÔNG ĐÚNG', 1;
	END
END;
GO


-- Thêm hàng 1
EXEC INSERT_ADMIN @EMAIL = N'admin@admin.com', @PASSWORD = N'admin@123', @ACTIVE = 1;

-- Thêm hàng 2
EXEC INSERT_ADMIN @EMAIL = N'admin1@admin.com', @PASSWORD = N'admin1@123', @ACTIVE = 0;

-- Thêm hàng 3
EXEC INSERT_ADMIN @EMAIL = N'haoden2@gmail.com', @PASSWORD = N'Admin@123', @ACTIVE = 1;


SELECT * FROM GETTABLE_ADMIN(N'admin@admin.com')

EXEC TRYLOGIN_ADMIN @EMAIL = N'haoden2@gmail.com', @PASSWORD = N'Admin@123'