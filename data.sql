﻿CREATE database QUANLYNHAHANG
GO

USE QUANLYNHAHANG
GO

-- FOOD 
-- TABLE
-- FOODCATERY
-- ACCOUNT
-- BILL
-- BILLINFO
CREATE TABLE TABLEfood
(
	ID INT IDENTITY  PRIMARY KEY,
	NAME NVARCHAR(30) NOT NULL DEFAULT N'CHƯA ĐẶT TÊN',
	STATUS NVARCHAR(30) NOT NULL DEFAULT N'Trống' -- TRỐNG HOẶC CÓ NGƯỜI
)
GO

CREATE TABLE ACCOUNT
(
	USERNAME VARCHAR(50) PRIMARY KEY,
	PASSWORD VARCHAR(100) NOT NULL  DEFAULT 1111,
	FULLNAME NVARCHAR(50) NOT NULL,
	TYPE INT NOT NULL DEFAULT 0,-- 1 LÀ ADMIN, O LÀ USER THƯỜNG
	AVT VARCHAR(1000)
)
GO

CREATE TABLE FOODCATERY
(	
	ID INT IDENTITY  PRIMARY KEY,
	NAME NVARCHAR(50) NOT NULL  DEFAULT N'CHƯA ĐẶT TÊN'
)
GO

CREATE TABLE FOOD
(	
	ID INT IDENTITY  PRIMARY KEY,
	NAME NVARCHAR(50) NOT NULL DEFAULT N'CHƯA ĐẶT TÊN',
	IDCATERY INT NOT NULL,
	GIA FLOAT NOT NULL  DEFAULT 0,
	FOREIGN KEY(IDCATERY) REFERENCES DBO.FOODCATERY(ID)
)
GO

CREATE TABLE BILL
(
	ID INT IDENTITY  PRIMARY KEY,
	DATECHECKIN DATETIME NOT NULL DEFAULT GETDATE(),
	DATECHECKOUT DATETIME,
	IDTABLE INT  NOT NULL,
	STATUS INT NOT NULL DEFAULT 0, -- 1 ĐÃ THANH TOÁN, 0 CHƯA
	GIAMGIA INT NOT NULL DEFAULT 0,
	FOREIGN KEY(IDTABLE) REFERENCES DBO.TABLEFOOD(ID)
)
GO

CREATE TABLE BILLINFO
(
	ID INT IDENTITY  PRIMARY KEY,
	IDBILL INT NOT NULL,
	IDFOOD INT NOT NULL,
	COUNT INT NOT NULL DEFAULT 0,
	FOREIGN KEY(IDBILL) REFERENCES DBO.BILL(ID),
	FOREIGN KEY(IDFOOD) REFERENCES DBO.FOOD(ID)

)
GO

INSERT INTO ACCOUNT(USERNAME,PASSWORD,FULLNAME,TYPE,AVT)
VALUES(N'phanhai',N'hai123',N'Vũ Văn Hải',0,NULL)


GO

-- THỦ TỤC LẤY ACC TỪ USERNAME
CREATE proc USP_GETACCOUNTLIST(
	@USERNAME VARCHAR(30)
)
AS BEGIN
	SELECT * FROM DBO.ACCOUNT WHERE USERNAME = @USERNAME
END
GO

-- THỦ TỤC ĐĂNG NHẬP
CREATE proc USP_Login
(
	@username varchar(100),
	@password varchar(100)
)
AS 
BEGIN
	SELECT * FROM dbo.ACCOUNT 
	WHERE USERNAME = @username AND PASSWORD = @password
END
GO

-- thêm bàn bằng hàm
DECLARE @i int = 1
WHILE @i <=12
BEGIN
	INSERT dbo.TABLEfood(NAME)
	VALUES(N'Bàn '+ CAST(@i as nvarchar(10))) -- do i kiểu int , không cùng với kiểu với cột NAME: nvarchar, nên tiến hành ép kiểu
	SET @i = @i +1
END
GO

--UPDATE dbo.TABLEfood set STATUS =N'CÓ KHÁCH' WHERE ID =5

-- LẤY DANH SÁCH BÀN 
CREATE proc USP_GetTableList
AS
BEGIN
	 SELECT * FROM dbo.TABLEfood
END
GO

EXEC USP_GetTableList
GO


-- THÊM VÀO FOODCATERY
insert dbo.FOODCATERY(NAME)
values(N'Hải sản')
go

insert dbo.FOODCATERY(NAME)
values(N'Đặc sản ')
go

insert dbo.FOODCATERY(NAME)
values(N'Đồ uống Có cồn')
go

insert dbo.FOODCATERY(NAME)
values(N'Đồ uống giải khát')
go

-- THÊM VÀO BẢNG FOOD
-- THÊM HẢI SẢN
insert dbo.FOOD(NAME, IDCATERY, GIA)
values(N'MỰC HẤP',1,150000)
GO

insert dbo.FOOD(NAME, IDCATERY, GIA)
values(N'TÔM HÙM HẤP BIA',1,300000)
GO
-- THÊM ĐẶC SẢN RỪNG
insert dbo.FOOD(NAME, IDCATERY, GIA)
values(N'LỢN RỪNG XÀO XẢ',2,150000)
GO

insert dbo.FOOD(NAME, IDCATERY, GIA)
values(N'CÁ SUỐI NƯỚNG',2,150000)
GO

insert dbo.FOOD(NAME, IDCATERY, GIA)
values(N'THỊT TRÂU GÁC BẾP',2,250000)
GO

--THÊM ĐỒ UỐNG CÓ CỒN
insert dbo.FOOD(NAME, IDCATERY, GIA)
values(N'VANG PHÁP',3,2000000)
GO

insert dbo.FOOD(NAME, IDCATERY, GIA)
values(N'NAPONEOL',3,10000000)
GO

insert dbo.FOOD(NAME, IDCATERY, GIA)
values(N'CHIVAS 18',3,9000000)
GO

insert dbo.FOOD(NAME, IDCATERY, GIA)
values(N'VOTCA',3,90000)
GO

insert dbo.FOOD(NAME, IDCATERY, GIA)
values(N'RƯỢU NẾP',3,60000)
GO

-- THÊM ĐỒ GIẢI KHÁT
insert dbo.FOOD(NAME, IDCATERY, GIA)
values(N'CAM VẮT',4,30000)
GO

insert dbo.FOOD(NAME, IDCATERY, GIA)
values(N'SINH TỐ XOÀI',4,40000)
GO

insert dbo.FOOD(NAME, IDCATERY, GIA)
values(N'SINH TỐ DƯA HẤU',4,40000)
GO

insert dbo.FOOD(NAME, IDCATERY, GIA)
values(N'RED BUL',4,30000)
GO

insert dbo.FOOD(NAME, IDCATERY, GIA)
values(N'CAFE',4,30000)
GO

insert dbo.FOOD(NAME, IDCATERY, GIA)
values(N'NƯỚC SUỐI',4,10000)
GO

-- THÊM BILL
-- STATUS: 1 ĐÃ CHECKOUT

INSERT DBO.BILL(DATECHECKIN, DATECHECKOUT,IDTABLE, STATUS)
VALUES(GETDATE(), GETDATE(),1,1)
GO

INSERT DBO.BILL(DATECHECKIN, DATECHECKOUT,IDTABLE, STATUS)
VALUES(GETDATE(),NULL,5,0)
GO

INSERT DBO.BILL(DATECHECKIN, DATECHECKOUT,IDTABLE, STATUS)
VALUES(GETDATE(), GETDATE(),7,1)
GO

-- THÊM BILLINFO
 INSERT DBO.BILLINFO(IDBILL, IDFOOD,COUNT)
 VALUES(4,1,2)
 GO

 INSERT DBO.BILLINFO(IDBILL, IDFOOD,COUNT)
 VALUES(4,4,2)
 GO

 INSERT DBO.BILLINFO(IDBILL, IDFOOD,COUNT)
 VALUES(4,3,1)
 GO

 INSERT DBO.BILLINFO(IDBILL, IDFOOD,COUNT)
 VALUES(5,1,3)
 GO

 INSERT DBO.BILLINFO(IDBILL, IDFOOD,COUNT)
 VALUES(5,4,1)
 GO

 INSERT DBO.BILLINFO(IDBILL, IDFOOD,COUNT)
 VALUES(5,5,1)
 GO

 INSERT DBO.BILLINFO(IDBILL, IDFOOD,COUNT)
 VALUES(6,1,1)
 GO

 INSERT DBO.BILLINFO(IDBILL, IDFOOD,COUNT)
 VALUES(6,3,1)
 GO


 -- Tạo proc thêm Hóa Đơn
 CREATE proc USP_InsertBill
 (	
	@IDTABLE int
 )
 AS 
 BEGIN
	insert dbo.BILL(DATECHECKIN, DATECHECKOUT,IDTABLE,STATUS,GIAMGIA)
	values(GETDATE(),NULL,@IDTABLE,0,0)
END
GO

 -- thêm BillInfo
--
CREATE proc USP_InsertBillInfo
  (
	@IDBILL int,
	@IDFOOD int,
	@COUNT int
  )
 AS
 BEGIN
	declare @isExitBillnfo int;
	declare @foodCount int = 1;
	select @isExitBillnfo = ID , @foodCount = COUNT 
	from dbo.BILLINFO 
	where IDBILL = @IDBILL and IDFOOD = @IDFOOD
	if(@isExitBillnfo >0)
	BEGIN
		declare @newCount int = @foodCount + @COUNT
		IF(@newCount >0)
			update dbo.BILLINFO set COUNT = @foodCount + @COUNT
			where IDBILL = @IDBILL and IDFOOD = @IDFOOD
		else 
			DELETE dbo.BILLINFO where IDBILL = @IDBILL and IDFOOD = @IDFOOD
	END
	else
	BEGIN
		insert dbo.BILLINFO(IDBILL , IDFOOD , COUNT)
		values(@IDBILL  ,@IDFOOD , @COUNT)
	END
 END
GO



--
CREATE proc USP_UpdateAcc(
	@username nvarchar(50),
	@fullname nvarchar(50),
	@password varchar(50),
	@newpass varchar(50),
	@linkavt nvarchar(1000)
)
AS
BEGIN
	declare @passOK int =0
	select @passOK = count(*) from dbo.ACCOUNT where USERNAME = @username and PASSWORD = @password

	if(@passOK = 1)
	BEGIN
		if(@newpass = null or @newpass ='')
		BEGIN
			update dbo.ACCOUNT set FULLNAME = @fullname,AVT = @linkavt where USERNAME = @username and PASSWORD = @password
		END
		else
			update dbo.ACCOUNT set FULLNAME = @fullname, AVT = @linkavt, PASSWORD = @newpass where USERNAME = @username
	END
END
GO 



-- tạo thủ tục show food
CREATE PROC SHOWFOOD_CATERRY(
	@IDFOOD INT
)
AS
BEGIN
	SELECT A.NAME AS 'TÊN MÓN ĂN', B.NAME AS 'DANH MỤC', A.GIA AS 'GIÁ'
	FROM DBO.FOOD A , DBO.FOODCATERY B
	WHERE A.IDCATERY = B.ID
END
GO

-- 
create trigger UTG_UPDATEBILLINFO
ON dbo.BILLINFO for insert, update
AS
BEGIN
	DECLARE @IDBILL int

	SELECT @IDBILL = IDBILL from inserted

	DECLARE @IDTABLE int

	SELECT @IDTABLE = IDTABLE from dbo.BILL where id= @IDBILL and status = 0

	DECLARE @COUNT INT
	SELECT @COUNT = COUNT(*) FROM DBO.BILLINFO WHERE IDBILL = @IDBILL

	IF(@COUNT>0)
		UPDATE dbo.TABLEfood set STATUS =N'Có Khách' where id = @IDTABLE
	ELSE
		UPDATE dbo.TABLEfood set STATUS =N'Trống' where id = @IDTABLE

END
GO

--
CREATE trigger UTG_UPDATEBILL
ON dbo.BILL for UPDATE
AS
BEGIN
	DECLARE @IDBILL int

	SELECT @IDBILL = ID from inserted

	DECLARE @IDTABLE int

	SELECT @IDTABLE = IDTABLE from dbo.BILL where ID = @IDBILL

	DECLARE @count int = 0

	SELECT @count = COUNT(*) from DBO.BILL where IDTABLE = @IDTABLE and STATUS = 0

	if(@count = 0)
		update dbo.TABLEfood set STATUS =N'Trống' where ID = @IDTABLE
END
GO


-- TẠO THỦ TỤC LẤY RA DS BILLINFO TỪNG BÀN
create PROC USP_SWITCHTABLE(
	@IDTABLE_1 INT,
	@IDTABLE_2 INT
 )
 AS
 BEGIN
	DECLARE @IDBILL_1 INT
	DECLARE @IDBILL_2 INT

	DECLARE @IS_TABLE_1_EMPTY INT = 1
	DECLARE @IS_TABLE_2_EMPTY INT = 1

	-- LẤY RA IDBILL CỦA 2 BÀN MÀ CẦN CHUYỂN BÀN CHO NHAU
	SELECT @IDBILL_2 = ID FROM BILL WHERE IDTABLE = @IDTABLE_2 AND STATUS = 0
	SELECT @IDBILL_1 = ID FROM BILL WHERE IDTABLE = @IDTABLE_1 AND STATUS = 0

	IF(@IDBILL_1 is NULL)
	BEGIN
		INSERT DBO.BILL(DATECHECKIN, DATECHECKOUT,IDTABLE,STATUS)
		VALUES(GETDATE(),NULL,@IDTABLE_1,0)

		SELECT @IDBILL_1 = MAX(ID) FROM BILL WHERE IDTABLE = @IDTABLE_1 AND STATUS = 0
		
		
	END

	SELECT @IS_TABLE_1_EMPTY = COUNT(*) FROM DBO.BILLINFO WHERE IDBILL = @IDBILL_1

	IF(@IDBILL_2 is NULL)
	BEGIN
		INSERT DBO.BILL(DATECHECKIN, DATECHECKOUT,IDTABLE,STATUS)
		VALUES(GETDATE(),NULL,@IDTABLE_2,0)
		
		SELECT @IDBILL_2 = MAX(ID) FROM BILL WHERE IDTABLE = @IDTABLE_2 AND STATUS = 0

	END

	SELECT @IS_TABLE_2_EMPTY = COUNT(*) FROM DBO.BILLINFO WHERE IDBILL = @IDBILL_2

	--
	SELECT ID INTO IDBILLINFO_TABLE FROM DBO.BILLINFO WHERE IDBILL = @IDBILL_2

	-- CHUYỂN HẾT BILLINFO TỪ BÀN 1 SANG CHO BÀN 2
	UPDATE BILLINFO SET IDBILL = @IDBILL_2 WHERE IDBILL = @IDBILL_1

	-- CHUYỂN HẾT BILLINFO TỪ BÀN 2 SANG CHO BÀN 1 VỚI ĐIỀU KIỆN
	UPDATE BILLINFO SET IDBILL = @IDBILL_1 WHERE ID IN (SELECT * FROM IDBILLINFO_TABLE)

	-- XÓA TABLE TỰ TẠO RA 
	DROP TABLE IDBILLINFO_TABLE

	IF(@IS_TABLE_1_EMPTY = 0)
		UPDATE DBO.TABLEfood SET STATUS = N'Trống'WHERE ID = @IDTABLE_2

	IF(@IS_TABLE_2_EMPTY = 0)
		UPDATE DBO.TABLEfood SET STATUS = N'Trống'WHERE ID = @IDTABLE_1
 END
 GO

 -- 
 ALTER TABLE BILL ADD TONGTIEN_HOADON FLOAT DEFAULT 0
 GO
 ALTER TABLE BILL ADD TONGTIEN_THANHTOAN FLOAT DEFAULT 0
 GO
 --

 -- 
 CREATE PROC USP_GETLISTBILLBYDATE
 (
	@datecheckin datetime,
	@datecheckout datetime
 )

 AS
 BEGIN
	SELECT T.NAME, B.TONGTIEN_HOADON, B.TONGTIEN_THANHTOAN, B.GIAMGIA, B.DATECHECKIN, B.DATECHECKOUT
	FROM BILL AS B, TABLEfood AS T
	WHERE DATECHECKIN >= @datecheckin AND DATECHECKOUT <= @datecheckout AND B.STATUS =1 AND B.IDTABLE = T.ID 
 END
 GO

 CREATE PROC SHOWFOOD_CATERY(
	@IDFOOD INT
)

AS
BEGIN
	SELECT a.ID ,a.NAME as 'Name' , B.NAME as 'Catery', A.GIA as 'Gia'FROM DBO.FOOD a, DBO.FOODCATERY B 
	WHERE A.IDCATERY = B.ID
END


SELECT a.ID ,a.NAME as 'Name' , B.NAME as 'Catery', A.GIA as 'Gia' FROM DBO.FOOD a, DBO.FOODCATERY B  where a.IDCATERY=b.ID and a.name like N'%t%'


select * from FOODCATERY
GO

CREATE proc SHOWFOODBYCATERYID(
	@idCATERY int
	)
as
begin
	SELECT a.ID ,a.NAME as 'Name' , B.NAME as 'Catery', A.GIA as 'Gia'FROM DBO.FOOD a, DBO.FOODCATERY B 
	WHERE A.IDCATERY = B.ID AND A.IDCATERY=@idCATERY
end
go
create table BANDAT
(
	id int identity primary key,
	TENKH NVARCHAR(50),
	SDT VARCHAR(11),
	IDBAN INT,
	SOKHACH INT,
	GIO varchar(20),
	NGAY DATETIME,
	GHICHU NVARCHAR(100)
)
go

alter PROC SHOWBANDATBYID(
@id int
)
AS
BEGIN
	SELECT TENKH,SDT,SOKHACH,B.NAME as 'ban',GIO,NGAY,GHICHU
	FROM BANDAT A, TABLEfood B
	WHERE A.IDBAN=B.ID and b.ID=@id
END


insert into BANDAT values('phung1','0168361501','2','2','10-01-2019','10-01-2018','10-09-2018','aa')
select * from BANDAT

go
------------------

alter PROC GETLISTBANDAT(
@SDT VARCHAR(10)
)
AS
BEGIN
	SELECT a.id,TENKH,SDT,SOKHACH,B.NAME as 'ban',GIO,NGAY,GHICHU
	FROM BANDAT A, TABLEfood B
	WHERE A.IDBAN=B.ID
END
go


alter PROC SHOWBANDATBYID(
@id int
)
AS
BEGIN
	SELECT a.id,TENKH,SDT,SOKHACH,B.NAME as 'ban',GIO,NGAY,GHICHU
	FROM BANDAT A, TABLEfood B
	WHERE A.IDBAN=B.ID and b.ID=@id
END
go
--------------------------
alter PROC USP_GETBILL_BYTABLE
 (
	@idTable int
 )

 AS
 BEGIN
	select BILL.IDTABLE, Food.NAME , BiIfo.COUNT , Food.GIA , Food.GIA*BiIfo.COUNT
	 from dbo.BILLINFO as BiIfo, dbo.BILL as Bill, dbo.FOOD as Food 
	 where BiIfo.IDBILL = Bill.ID and BiIfo.IDFOOD = Food.ID and Bill.status =0 and IDTABLE= @idTable
 END

 -------------GỘP BÀN
 Gộp bàn trong phần mềm quản lí cafe
2
CTP
Gộp bàn trong phần mềm quản lí cafe
Mọi người xem giúp mình proc này sai ở đâu mà sao khi mình gộp 2 bàn với nhau thì bill bàn 2 vẫn chuyển qua được bàn 1 nhưng status bàn 2 vẫn không nhảy về " Trống "
------

alter PROC USP_GroupTable(
@idtable1 INT, @idtable2 INT
)
AS
BEGIN
	DECLARE @idfirstBill INT
	DECLARE @idsecondBill INT

	DECLARE @isfirstTableEmpty INT =1
	DECLARE @issecondTableEmpty INT =1

	SELECT @idfirstBill=id FROM dbo.Bill WHERE idTable = @idtable1 AND STATUS = 0
	SELECT @idsecondBill=id FROM dbo.Bill WHERE idTable = @idtable2 AND STATUS = 0

	IF(@idfirstBill IS NULL)
	BEGIN
		INSERT dbo.Bill
		        ( DateCheckin ,
		          DateCheckout ,
		          idTable ,
		          STATUS ,
		          GIAMGIA ,
		          TONGTIEN_HOADON,
				  TONGTIEN_THANHTOAN
		        )
		VALUES  ( GETDATE() , -- DateCheckin - date
		          NULL , -- DateCheckout - date
		          @idtable1, -- idTable - int
		          0 , -- statusBill - int
		          0 , -- Discout - int
		          0.0,  -- TotalPrice - float
				  0.0
		        )
		SELECT @idfirstBill=MAX(id) FROM dbo.Bill WHERE idTable =@idtable1 AND status = 0
	END
	 SELECT @isfirstTableEmpty = COUNT(*) FROM dbo.Billinfo WHERE idBill = @idfirstBill

	IF(@idsecondBill IS NULL)
	BEGIN
		INSERT dbo.Bill
		        ( DateCheckin ,
		          DateCheckout ,
		          idTable ,
		          status ,
		          GIAMGIA ,
		          TONGTIEN_HOADON,
				  TONGTIEN_THANHTOAN
		        )
		VALUES  ( GETDATE() , -- DateCheckin - date
		          NULL , -- DateCheckout - date
		          @idtable2 , -- idTable - int
		          0 , -- statusBill - int
		          0 , -- Discout - int
		          0.0,  -- TotalPrice - float
				  0.0
		        )
		SELECT @idsecondBill=MAX(id) FROM dbo.Bill WHERE idTable =@idtable2 AND status = 0
    END
	SELECT @issecondTableEmpty =COUNT(*) FROM dbo.Billinfo WHERE idBill = @idsecondBill
    
    UPDATE dbo.Billinfo SET idBill=@idfirstBill WHERE idBill = @idfirstBill
	UPDATE dbo.Billinfo SET idBill =@idfirstBill WHERE idBill = @idsecondBill

	SELECT @issecondTableEmpty =COUNT(*) FROM dbo.Billinfo WHERE idBill = @idsecondBill

	--IF(@isfirstTableEmpty = 0)
--	UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idtable2
	IF(@issecondTableEmpty = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idtable2
END	
GO

 -- Tạo proc xóa Hóa Đơn
 CREATE proc USP_DelBill
 (	
	@IDTABLE int
 )
 AS 
 BEGIN
	delete  dbo.BILL where IDTABLE=@IDTABLE
END
-----------
CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) 
AS 
BEGIN 
	IF @strInput IS NULL RETURN @strInput 
	IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) 
	
	DECLARE @SIGN_CHARS NCHAR(136) 
	DECLARE @UNSIGN_CHARS NCHAR (136) 
	
	SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) 
	SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' 
	DECLARE @COUNTER int
	 DECLARE @COUNTER1 int 
	 SET @COUNTER = 1 
	 WHILE (@COUNTER <=LEN(@strInput)) 
	 BEGIN 
		SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1)
		BEGIN 
			IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) 
			BEGIN 
				IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
				ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) 
				BREAK 
			END 
			SET @COUNTER1 = @COUNTER1 +1 
		END 
		SET @COUNTER = @COUNTER +1 
	END 
	SET @strInput = replace(@strInput,' ','-') RETURN @strInput 
END

GO

SELECT a.ID ,a.NAME as 'Name' , B.NAME as 'Catery', A.GIA as 'Gia' FROM DBO.FOOD a, DBO.FOODCATERY B where a.name like  N'%a%' and a.IDCATERY=b.ID