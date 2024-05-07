﻿USE Final
GO

-- TẠO BẢNG
DROP TABLE IF EXISTS COURSE;
GO

CREATE TABLE COURSE (
    ID NVARCHAR(MAX),
    [LABEL] NVARCHAR(MAX),
	SEMESTER NVARCHAR(MAX),
    [PERIOD] NVARCHAR(MAX),
    [DESCRIPTION] NVARCHAR(MAX)
);
GO

-- TẠO SEQUENCE
DROP SEQUENCE IF EXISTS COURSE_SEQ;
GO
CREATE SEQUENCE COURSE_SEQ
    START WITH 1
    INCREMENT BY 1
    MINVALUE 1
    NO MAXVALUE
    CACHE 10;
GO

-- HÀM TẠO BẢNG TỪ CHUỖI
CREATE OR ALTER FUNCTION GETTABLE_COURSE (@ID NVARCHAR(MAX))
RETURNS TABLE
AS
RETURN
(
    SELECT * 
    FROM COURSE C 
    WHERE C.ID LIKE '%' + @ID + '%' or @ID = N''
);
GO

-- HÀM TẠO BẢNG TỪ CHUỖI
CREATE OR ALTER FUNCTION GETTABLE_COURSE_VI (@ID NVARCHAR(MAX))
RETURNS TABLE
AS
RETURN
(
    SELECT	C.ID AS ID
			,C.[LABEL] AS [TÊN KHÓA HỌC]
			,C.SEMESTER AS [HỌC KỲ]
			,C.[DESCRIPTION] AS [MÔ TẢ]
			,C.[PERIOD] AS [THỜI GIAN HỌC]
    FROM COURSE C 
    WHERE C.ID LIKE '%' + @ID + '%' or @ID = N''
);
GO



-- HÀM KIỂM TRA INSERT
CREATE OR ALTER FUNCTION CHECK_INSERT_COURSE(@ID NVARCHAR(MAX))
RETURNS BIT
AS
BEGIN
    DECLARE @RESULT BIT = 0;
    IF NOT EXISTS (SELECT 1 FROM COURSE WHERE ID = @ID)
        SET @RESULT = 1;
    RETURN @RESULT;
END;
GO

-- HÀM KIỂM TRA UPDATE
CREATE OR ALTER FUNCTION CHECK_UPDATE_COURSE(@ID NVARCHAR(10))
RETURNS BIT
AS
BEGIN
    DECLARE @RESULT BIT = 0;
    SET @RESULT = 1;
    RETURN @RESULT;
END;
GO

-- HÀM KIỂM TRA DELETE
CREATE OR ALTER FUNCTION CHECK_DELETE_COURSE()
RETURNS BIT
AS
BEGIN
    RETURN 1;
END;
GO

-- HÀM INSERT
CREATE OR ALTER PROCEDURE INSERT_COURSE 
	@ID NVARCHAR(MAX),
    @LABEL NVARCHAR(MAX),
	@SEMESTER NVARCHAR(MAX),
    @PERIOD NVARCHAR(MAX),
    @DESCRIPTION NVARCHAR(MAX)
AS
BEGIN
    IF DBO.CHECK_INSERT_COURSE(@ID) = 1
    BEGIN
        --DECLARE @ID NVARCHAR(MAX);
        --SET @ID = CONCAT('CRS', FORMAT(NEXT VALUE FOR COURSE_SEQ, '00000000'));
        INSERT INTO COURSE (
						ID
						,[LABEL]
						,SEMESTER
						,[PERIOD]
						,[DESCRIPTION])
        VALUES 
					(@ID
					,@LABEL
					,@SEMESTER
					,@PERIOD
					,@DESCRIPTION);
		SELECT 1 AS RESULT;
    END
    ELSE
    BEGIN
        THROW 50001, 'ID ALREADY EXISTS', 1;
    END
END;
GO

-- HÀM UPDATE
CREATE OR ALTER PROCEDURE UPDATE_COURSE 
    @ID NVARCHAR(MAX),
    @LABEL NVARCHAR(MAX),
	@SEMESTER NVARCHAR(MAX),
    @PERIOD NVARCHAR(MAX),
    @DESCRIPTION NVARCHAR(MAX)
AS
BEGIN
    IF DBO.CHECK_UPDATE_COURSE(@ID) = 1
    BEGIN
        UPDATE COURSE
        SET [LABEL] = @LABEL,
			SEMESTER = @SEMESTER,
            [PERIOD] = @PERIOD,
            [DEsCRIPTION] = @DESCRIPTION
        WHERE ID = @ID;
    END
    ELSE
    BEGIN
        THROW 50002, 'ERR', 1;
    END;
END;
GO

-- HÀM DELETE
CREATE OR ALTER PROCEDURE DELETE_COURSE 
    @ID NVARCHAR(MAX)
AS
BEGIN
    IF DBO.CHECK_DELETE_COURSE() = 1
    BEGIN
        DELETE FROM COURSE WHERE ID = @ID;
    END
    ELSE
    BEGIN
        THROW 50003, 'ERR', 1;
    END
END;
GO



-- Thêm hàng 1
EXEC INSERT_COURSE @ID = N'test', @SEMESTER = N'2', @LABEL = N'KHOA HOC 01', @PERIOD = N'15', @DESCRIPTION = N'FIRST TEST'

SELECT * FROM GETTABLE_COURSE(N'')