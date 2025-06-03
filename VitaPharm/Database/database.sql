USE PharmacyDB;
GO

-- 1) Xóa dữ liệu các bảng cũ (theo thứ tự phụ thuộc FK)
DELETE FROM InvoiceDetails;
DELETE FROM Invoices;
DELETE FROM GoodsReceiptDetails;
DELETE FROM GoodsReceipts;
DELETE FROM Batches;
DELETE FROM Commodities;
DELETE FROM Categories;
DELETE FROM Customers;
DELETE FROM Accounts;
DELETE FROM Employees;
GO

-- 2) Reset identity cho các bảng có cột IDENTITY
IF EXISTS (
    SELECT * 
    FROM sys.identity_columns 
    WHERE OBJECT_NAME(object_id) = 'InvoiceDetails'
      AND last_value IS NOT NULL
)
    DBCC CHECKIDENT('InvoiceDetails', RESEED, 0);

IF EXISTS (
    SELECT * 
    FROM sys.identity_columns 
    WHERE OBJECT_NAME(object_id) = 'Invoices'
      AND last_value IS NOT NULL
)
    DBCC CHECKIDENT('Invoices', RESEED, 0);

IF EXISTS (
    SELECT * 
    FROM sys.identity_columns 
    WHERE OBJECT_NAME(object_id) = 'GoodsReceiptDetails'
      AND last_value IS NOT NULL
)
    DBCC CHECKIDENT('GoodsReceiptDetails', RESEED, 0);

IF EXISTS (
    SELECT * 
    FROM sys.identity_columns 
    WHERE OBJECT_NAME(object_id) = 'GoodsReceipts'
      AND last_value IS NOT NULL
)
    DBCC CHECKIDENT('GoodsReceipts', RESEED, 0);

IF EXISTS (
    SELECT * 
    FROM sys.identity_columns 
    WHERE OBJECT_NAME(object_id) = 'Batches'
      AND last_value IS NOT NULL
)
    DBCC CHECKIDENT('Batches', RESEED, 0);

IF EXISTS (
    SELECT * 
    FROM sys.identity_columns 
    WHERE OBJECT_NAME(object_id) = 'Commodities'
      AND last_value IS NOT NULL
)
    DBCC CHECKIDENT('Commodities', RESEED, 0);

IF EXISTS (
    SELECT * 
    FROM sys.identity_columns 
    WHERE OBJECT_NAME(object_id) = 'Categories'
      AND last_value IS NOT NULL
)
    DBCC CHECKIDENT('Categories', RESEED, 0);

IF EXISTS (
    SELECT * 
    FROM sys.identity_columns 
    WHERE OBJECT_NAME(object_id) = 'Customers'
      AND last_value IS NOT NULL
)
    DBCC CHECKIDENT('Customers', RESEED, 0);

IF EXISTS (
    SELECT * 
    FROM sys.identity_columns 
    WHERE OBJECT_NAME(object_id) = 'Accounts'
      AND last_value IS NOT NULL
)
    DBCC CHECKIDENT('Accounts', RESEED, 0);

IF EXISTS (
    SELECT * 
    FROM sys.identity_columns 
    WHERE OBJECT_NAME(object_id) = 'Employees'
      AND last_value IS NOT NULL
)
    DBCC CHECKIDENT('Employees', RESEED, 0);
GO


/*======================================================
  1) EMPLOYEES  –  PK = EmployeeID (IDENTITY)
======================================================*/
SET IDENTITY_INSERT Employees ON;
INSERT INTO Employees
    (EmployeeID, EmployeeName, Sex, Contact, Birthday, EmployeeAddress) VALUES
    (1, N'Nguyễn Văn An'       ,'M','0912345678','1985-05-20',N'123 Đường Láng, Hà Nội'),
	(2, N'Lê Thị Hồng'         ,'F','0918765432','1990-08-15',N'456 Cầu Giấy, Hà Nội'),
	(3, N'Trần Quang Minh'     ,'M','0987654321','1988-12-10',N'789 Tôn Đức Thắng, TP.HCM'),
	(4, N'Phạm Thu Hà'         ,'F','0934567890','1992-03-22',N'123 Nguyễn Văn Cừ, Đà Nẵng'),
	(5, N'Hoàng Thị Lan'       ,'F','0976543210','1995-07-07',N'12 Lý Thường Kiệt, Huế'),
	(6, N'Ngô Văn Hải'         ,'M','0911122233','1987-11-11',N'45 Trần Hưng Đạo, Hà Nội'),
	(7, N'Bùi Thị Hoa'         ,'F','0945566778','1993-06-25',N'78 Nguyễn Huệ, TP.HCM'),
	(8, N'Lý Văn Tùng'         ,'M','0923344556','1984-09-30',N'23 Đinh Tiên Hoàng, Đà Nẵng'),
	(9, N'Phan Thị Kim'        ,'F','0912345689','1991-04-18',N'90 Lê Duẩn, Hà Nội'),
	(10, N'Doãn Thanh Bình'     ,'M','0931122334','1986-02-14',N'50 Hai Bà Trưng, Hải Phòng'),
	(11, N'Lương Thị Hạnh'      ,'F','0978899001','1994-12-24',N'15 Phan Đình Phùng, Huế'),
	(12, N'Phùng Văn Khánh'     ,'M','0903344556','1983-07-19',N'72 Võ Thị Sáu, TP.HCM'),
	(13, N'Vũ Thị Mai'          ,'F','0934455667','1990-05-05',N'68 Điện Biên Phủ, Hà Nội'),
	(14, N'Đinh Công Thắng'     ,'M','0988877665','1989-08-09',N'99 Nguyễn Trãi, Đà Nẵng'),
	(15, N'Phạm Thị Thu'        ,'F','0922233445','1992-10-30',N'25 Trường Chinh, Huế'),
	(16, N'Tô Văn Hoàng'        ,'M','0912233445','1981-03-03',N'10 Lê Lợi, TP.HCM'),
	(17, N'Trịnh Thị Ngọc'      ,'F','0944455667','1996-01-17',N'85 Nguyễn Văn Trỗi, Đà Nẵng'),
	(18, N'Hoàng Minh Đức'      ,'M','0905566778','1985-11-22',N'37 Hùng Vương, Hà Nội'),
	(19, N'Lê Thị Thanh'        ,'F','0928899001','1993-09-09',N'12 Bà Triệu, Hải Phòng'),
	(20, N'Nguyễn Quang Huy'    ,'M','0913344556','1982-06-06',N'19 Phạm Văn Đồng, Hà Nội'),
	(21, N'Châu Thị Ngọc Loan'  ,'F','0398451112','2002-12-25',N'Châu Phú, An Giang'),
	(22, N'Nguyễn Thị Bích Quân','F','0398154414','2003-07-06',N'Phú Tân, An Giang');
SET IDENTITY_INSERT Employees OFF;


/*======================================================
  2) ACCOUNTS  –  PK = AccountID
======================================================*/
SET IDENTITY_INSERT Accounts ON;
INSERT INTO Accounts
    (AccountID, Username, UserPassword, UserRole, IsActive, EmployeeID) VALUES
	 ( 1 , 'nguyenvana'     , '12345' , 'user'  , 'Active',  1),
    ( 2 , 'lethihong'      , '12345' , 'user'  , 'Active',  2),
    ( 3 , 'tranquangminh'  , '12345' , 'user'  , 'Active',  3),
    ( 4 , 'phamthuha'      , '12345' , 'user'  , 'Active',  4),
    ( 5 , 'hoangthilan'    , '12345' , 'admin' , 'Active',  5),
    ( 6 , 'ngovanhai'      , '12345' , 'user'  , 'Active',  6),
    ( 7 , 'buithihoa'      , '12345' , 'user'  , 'Active',  7),
    ( 8 , 'lyvantung'      , '12345' , 'user'  , 'Active',  8),
    ( 9 , 'phanthikim'     , '12345' , 'user'  , 'Active',  9),
    (10 , 'doanthanhbinh'  , '12345' , 'user'  , 'Active', 10),
    (11 , 'luongthihanh'   , '12345' , 'user'  , 'Active', 11),
    (12 , 'phungvankhanh'  , '12345' , 'user'  , 'Active', 12),
    (13 , 'vuthimai'       , '12345' , 'user'  , 'Active', 13),
    (14 , 'dinhcongthang'  , '12345' , 'user'  , 'Active', 14),
    (15 , 'phamthithu'     , '12345' , 'user'  , 'Active', 15),
    (16 , 'tovanhoang'     , '12345' , 'user'  , 'Active', 16),
    (17 , 'trinhthingoc'   , '12345' , 'user'  , 'Active', 17),
    (18 , 'hoangminhduc'   , '12345' , 'user'  , 'Active', 18),
    (19 , 'lethithanh'     , '12345' , 'user'  , 'Active', 19),
    (20 , 'nguyenquanghuy' , '12345' , 'admin' , 'Active', 20),
    (21 , 'ctnloan'        , '12345' , 'admin' , 'Active', 21),
    (22 , 'ngquan'         , '12345' , 'admin' , 'Active', 22);
SET IDENTITY_INSERT Accounts OFF;


/*======================================================
  3) CUSTOMERS  –  PK = CustomerID
======================================================*/
SET IDENTITY_INSERT Customers ON;
INSERT INTO Customers
    (CustomerID, CustomerName, Sex, Contact, CustomerAddress) VALUES
    ( 1 ,N'Trần Văn Hùng'      ,'M','0901234567',N'12 Láng Hạ, Hà Nội'),
    ( 2 ,N'Lê Thị Nhàn'        ,'F','0912345678',N'34 Kim Mã, Hà Nội'),
    ( 3 ,N'Phạm Ngọc Long'     ,'M','0923456789',N'56 Nguyễn Huệ, TP.HCM'),
    ( 4 ,N'Nguyễn Thị Vân'     ,'F','0934567890',N'78 Đà Nẵng, Đà Nẵng'),
    ( 5 ,N'Hồ Văn Phát'        ,'M','0945678901',N'90 Lê Lợi, Huế'),
    ( 6 ,N'Đặng Thị Phượng'    ,'F','0956789012',N'12 Trần Phú, Hải Phòng'),
    ( 7 ,N'Hoàng Minh Khoa'    ,'M','0967890123',N'45 Điện Biên Phủ, TP.HCM'),
    ( 8 ,N'Lý Ngọc Hân'        ,'F','0978901234',N'67 Lý Thường Kiệt, Hà Nội'),
    ( 9 ,N'Tô Văn Cường'       ,'M','0989012345',N'89 Tôn Đức Thắng, Đà Nẵng'),
    (10 ,N'Vũ Thị Hằng'        ,'F','0990123456',N'123 Hai Bà Trưng, Huế'),
    (11 ,N'Trần Thanh Bình'    ,'M','0902233445',N'34 Lý Tự Trọng, Hà Nội'),
    (12 ,N'Nguyễn Ngọc Bích'   ,'F','0913344556',N'67 Phạm Ngũ Lão, TP.HCM'),
    (13 ,N'Phan Văn Tùng'      ,'M','0924455667',N'23 Võ Văn Kiệt, Đà Nẵng'),
    (14 ,N'Lê Thị Mai'         ,'F','0935566778',N'56 Nguyễn Chí Thanh, Huế'),
    (15 ,N'Hồ Minh Đức'        ,'M','0946677889',N'89 Trần Quý Cáp, Hải Phòng'),
    (16 ,N'Vương Thị Thu'      ,'F','0957788990',N'45 Ngô Quyền, Hà Nội'),
    (17 ,N'Trịnh Minh Phúc'    ,'M','0968899001',N'123 Hùng Vương, TP.HCM'),
    (18 ,N'Ngô Thị Hòa'        ,'F','0979900112',N'67 Nguyễn Thị Minh Khai, Đà Nẵng'),
    (19 ,N'Lý Văn Hiếu'        ,'M','0980011223',N'23 Trường Sa, Huế'),
    (20 ,N'Phạm Thị Hồng'      ,'F','0991122334',N'78 Hoàng Diệu, Hải Phòng');
SET IDENTITY_INSERT Customers OFF;


/*======================================================
  4) CATEGORIES  –  PK = CategoryID
======================================================*/
SET IDENTITY_INSERT Categories ON;
INSERT INTO Categories (CategoryID, CategoryName) VALUES
    (1,N'Thuốc'),
    (2,N'Thiết bị y tế');
SET IDENTITY_INSERT Categories OFF;


/*======================================================
  5) COMMODITIES  –  PK = CommodityID
======================================================*/
SET IDENTITY_INSERT Commodities ON;
INSERT INTO Commodities
    (CommodityID, CommodityName, Manufacturer, BaseUnit,
     SellingPrice, IsTerminated, CategoriesCategoryID) VALUES
    (1, N'Augclamox 250'                    ,N'Công ty cổ phần dược phẩm Hà Tây'                       ,N'Hộp 10 gói x 1,5g', 48000,'active'  ,1),
	(2, N'Casoran'                          ,N'Công ty cổ phần công nghệ cao Traphaco'                 ,N'Hộp 10 gói x 1,5g', 55000,'active'  ,1),
	(3, N'Docetaxel 20mg'                   ,N'Teva Pharmaceutical Works Private Limited Company'      ,N'Hộp 10 gói x 1,5g', 65000,'active'  ,1),
	(4, N'Hà thủ ô'                         ,N'Công ty cổ phần dược phẩm Hà Tây'                       ,N'Hộp 10 gói x 1,5g', 35000,'active'  ,1),
	(5, N'1-AL'                             ,N'NFDC Limited'                                           ,N'Hộp 10 gói x 1,5g', 25000,'inactive',1),
	(6, N'20% Fat Emulsion Injection'       ,N'Guangdong Otsuka Pharmaceutical Co., Ltd.'              ,N'Hộp 10 gói x 1,5g', 20000,'active'  ,1),
	(7, N'3B-Medi'                          ,N'Công ty cổ phần dược phẩm Me Di Sun'                    ,N'Hộp 10 gói x 1,5g', 15000,'active'  ,1),
	(8, N'3B-Medi tab'                      ,N'Công ty cổ phần dược phẩm Me Di Sun'                    ,N'Hộp 10 gói x 1,5g', 14000,'active'  ,1),
	(9, N'3BTP'                             ,N'Công ty cổ phần dược phẩm Hà Tây'                       ,N'Hộp 10 gói x 1,5g', 16000,'active'  ,1),
	(10, N'3Bpluzs F'                        ,N'Công ty cổ phần Dược phẩm Phương Đông'                  ,N'Hộp 10 gói x 1,5g', 17000,'active'  ,1),
	(11, N'3Bvit ando'                       ,N'Công ty cổ phần dược phẩm Hà Tây'                       ,N'Hộp 10 gói x 1,5g', 18000,'active'  ,1),
	(12, N'4-Epeedo-50'                      ,N'Naprod Life Sciences Pvt. Ltd.'                         ,N'Hộp 10 gói x 1,5g', 19000,'inactive',1),
	(13, N'4.2% w/v Sodium Bicarbonate'      ,N'B.Braun Melsungen AG'                                   ,N'Hộp 10 gói x 1,5g', 20000,'active'  ,1),
	(14, N'5% Dextrose 500ml inj Infusion'   ,N'Dai Han Pharm. Co., Ltd.'                               ,N'Hộp 10 gói x 1,5g', 21000,'active'  ,1),
	(15, N'5-Fluorouracil "Ebewe"'           ,N'Ebewe Pharma Ges.m.b.H.Nfg.KG'                          ,N'Hộp 10 gói x 1,5g', 22000,'active'  ,1),
	(16, N'8 Horas'                          ,N'Laboratorio Elea S.A.C.I.F.yA'                          ,N'Hộp 10 gói x 1,5g', 23000,'active'  ,1),
	(17, N'9PM'                              ,N'Cipla Ltd'                                              ,N'Hộp 10 gói x 1,5g', 24000,'inactive',1),
	(18, N'A9 - Cerebrazel'                  ,N'Công ty cổ phần dược TW Mediplantex'                    ,N'Hộp 10 gói x 1,5g', 25000,'active'  ,1),
	(19, N'ABAB 500 mg'                      ,N'Công ty cổ phần dược phẩm IMEXPHARM'                    ,N'Hộp 10 gói x 1,5g', 26000,'active'  ,1),
	(20, N'ACC 200 mg'                       ,N'Lindopharm GmbH'                                        ,N'Hộp 10 gói x 1,5g', 27000,'active'  ,1),

	/* -----------------  Nhóm THIẾT BỊ Y TẾ (ID = 2) ---------------- */
	(21, N'Băng y tế'                        ,N'Công ty TNHH Y tế ABC'                                  ,N'Hộp 10 cuộn'      ,  6000,'active'  ,2),
	(22, N'Gạc y tế'                         ,N'Công ty TNHH Y tế XYZ'                                  ,N'Hộp 20 miếng'     ,  4000,'active'  ,2),
	(23, N'Bông y tế'                        ,N'Công ty cổ phần dược phẩm DEF'                          ,N'Hộp 100g'         ,  2500,'inactive',2),
	(24, N'Bộ kit cấp cứu'                   ,N'Công ty TNHH Y tế GHI'                                  ,N'Bộ'               ,160000,'active'  ,2),
	(25, N'Bộ kit chăm sóc vết thương'       ,N'Công ty cổ phần dược phẩm JKL'                          ,N'Bộ'               ,130000,'active'  ,2),
	(26, N'Chất thử nhóm máu'                ,N'Công ty TNHH MNO'                                       ,N'Hộp 50 test'      , 12000,'active'  ,2),
	(27, N'Dung dịch muối'                   ,N'Công ty cổ phần dược phẩm PQR'                          ,N'Hộp 500ml'        ,  9000,'active'  ,2),
	(28, N'Miếng dán sát khuẩn'              ,N'Công ty TNHH STU'                                       ,N'Hộp 10 miếng'     ,  8000,'active'  ,2),
	(29, N'Miếng dán hạ sốt'                 ,N'Công ty cổ phần dược phẩm VWX'                          ,N'Hộp 5 miếng'      , 14000,'inactive',2),
(30, N'Glucovera 500 mg'       ,N'CTCP Dược Trung ương I'   ,N'Hộp 10 vỉ x 10 viên', 29000,'active',1),
(31, N'Telfor 60 mg'           ,N'Stada Việt Nam'           ,N'Hộp 2 vỉ x 10 viên', 34000,'active',1),
(32, N'Khẩu trang y tế 4 lớp'  ,N'Công ty Phú Tài'          ,N'Hộp 50 cái'        , 42000,'active',2),
(33, N'Băng cá nhân Ag+'       ,N'CT TNHH AGCare'           ,N'Hộp 100 miếng'     , 28000,'active',2);
SET IDENTITY_INSERT Commodities OFF;

/*======================================================
  6) BATCHES  –  PK = BatchID
======================================================*/
SET IDENTITY_INSERT Batches ON;
INSERT INTO Batches
    (BatchID, BatchCode, MfgDate, ExpDate, BatchDate, QtyAvailable,
     PurchasePrice, BatchStatus, CommodityID)
VALUES
-- 2024-01-01 ---------------------------------------------------------------
( 1 , 'BA-PARACET-240101-01', '2024-01-01','2026-01-01','2024-01-01', 500, 1000000,'InStock',  1),

-- 2024-02-01  (4 lô) -------------------------------------------------------
( 2 , 'BA-AMOXICI-240201-01', '2024-02-01','2026-02-01','2024-04-01', 600, 1100000,'InStock',  2),
(14 , 'BA-PARACET-240201-01', '2024-02-01','2026-02-01','2024-02-01', 400,   35000,'InStock',  1),
(22 , 'BA-VITAMIN-240201-01', '2024-02-01','2026-02-01','2024-02-01', 800,    4000,'InStock', 21),
(24 , 'BA-MINERAL-240201-01', '2024-02-01','2026-02-01','2024-02-01',1000,    2500,'InStock', 22),

-- 2024-03-01  (5 lô) -------------------------------------------------------
( 3 , 'BA-ASPIRIN-240301-01', '2024-03-01','2026-03-01','2024-03-01', 700, 1200000,'InStock',  3),
(15 , 'BA-PARACET-240301-01', '2024-03-01','2026-03-01','2024-03-01', 300,   36000,'InStock',  1),
(16 , 'BA-AMOXICI-240301-01', '2024-03-01','2026-03-01','2024-03-01', 450,   40000,'InStock',  2),
(23 , 'BA-VITAMIN-240301-01', '2024-03-01','2026-03-01','2024-03-01', 700,    4100,'InStock', 21),
(25 , 'BA-MINERAL-240301-01', '2024-03-01','2026-03-01','2024-03-01', 900,    2600,'InStock', 22),

-- 2024-04-01  (3 lô) -------------------------------------------------------
( 4 , 'BA-IBUPROF-240401-01', '2024-04-01','2026-04-01','2024-04-01', 800, 1300000,'InStock',  4),
(17 , 'BA-AMOXICI-240401-01', '2024-04-01','2026-04-01','2024-04-01', 350,   41000,'InStock',  2),
(18 , 'BA-ASPIRIN-240401-01', '2024-04-01','2026-04-01','2024-04-01', 500,   45000,'InStock',  3),

-- 2024-05-01  (3 lô) -------------------------------------------------------
( 5 , 'BA-CEFALEX-240501-01', '2024-05-01','2026-05-01','2024-05-01', 900, 1400000,'InStock',  5),
(19 , 'BA-ASPIRIN-240501-01', '2024-05-01','2026-05-01','2024-05-01', 400,   46000,'InStock',  3),
(20 , 'BA-IBUPROF-240501-01', '2024-05-01','2026-05-01','2024-05-01', 600,   25000,'InStock',  4),

-- 2024-06-01  (2 lô) -------------------------------------------------------
( 6 , 'BA-CEFUROX-240601-01', '2024-06-01','2026-06-01','2024-06-01', 500, 1500000,'InStock',  6),
(21 , 'BA-IBUPROF-240601-01', '2024-06-01','2026-06-01','2024-06-01', 500,   26000,'InStock',  4),

-- 2024-07-01 ---------------------------------------------------------------
( 7 , 'BA-CEFTRIA-240701-01', '2024-07-01','2026-07-01','2024-07-01', 600, 1600000,'InStock',  7),

-- 2024-08-01 ---------------------------------------------------------------
( 8 , 'BA-CEFOTAX-240801-01', '2024-08-01','2026-08-01','2024-08-01', 700, 1700000,'InStock',  8),

-- 2022-09-01 / 2022-10-01 --------------------------------------------------
( 9 , 'BA-CEFIXIM-220901-01', '2022-09-01','2024-09-01','2022-09-01', 800, 1800000,'Expired',  9),
(10 , 'BA-CEFDINI-221001-01', '2022-10-01','2024-10-01','2022-10-01', 900, 1900000,'Expired', 10),

-- Các lô ngày đơn (không trùng)  ------------------------------------------
(11 , 'BA-CEFPODO-240115-01', '2024-01-15','2026-01-15','2024-01-15', 700,  45000,'InStock', 23),
(12 , 'BA-CEFDINI-240205-01', '2024-02-05','2026-02-05','2024-02-05', 500, 160000,'InStock', 24),
(13 , 'BA-CEFIXIM-240220-01', '2024-02-20','2026-02-20','2024-02-20', 800,   8000,'InStock', 28),
(26 , 'BA-CEFPODO-250101-01', '2025-01-01','2027-01-01','2025-01-02', 600,  17400,'InStock', 30),
(27 , 'BA-CEFDINI-250110-01', '2025-01-10','2027-01-10','2025-01-11', 500,  20400,'InStock', 31),
(28 , 'BA-CEFIXIM-250115-01', '2025-01-15','2026-07-15','2025-01-15', 900,  25200,'InStock', 32),
(29 , 'BA-CEFIXIM-250420-01', '2025-04-20','2026-10-20','2025-04-21', 800,  25200,'InStock', 32),
(30 , 'BA-CEFPODO-250203-01', '2025-02-03','2027-02-03','2025-02-03', 750,  16800,'InStock', 33),
(31 , 'BA-CEFPODO-250510-01', '2025-05-10','2027-05-10','2025-05-10', 650,  16800,'InStock', 33),
(32 , 'BA-PARACET-250301-01', '2025-03-01','2027-03-01','2025-03-02', 350,  28800,'InStock',  1),
(33 , 'BA-AMOXICI-250305-01', '2025-03-05','2027-03-05','2025-03-06', 300,  33000,'InStock',  2),
(34 , 'BA-CEFDINI-250401-01', '2025-04-01','2027-04-01','2025-04-02', 400,  96000,'InStock', 24),
(35 , 'BA-CEFTRIA-250515-01', '2025-05-15','2027-05-15','2025-05-15', 500,   9000,'InStock',  7);

SET IDENTITY_INSERT Batches OFF;
/*======================================================
  7) GOODS RECEIPTS  –  PK = ReceiptID
======================================================*/
SET IDENTITY_INSERT GoodsReceipts ON;
INSERT INTO GoodsReceipts
    (ReceiptID, ReceiptCode, ReceiptDate, SupplierName, Note, ReceiptStatus, EmployeeID) VALUES
    ( 1, 'GR250501001', '2025-05-01', N'Công ty Dược ABC', '', 'Success',  1),
	( 2, 'GR250502001', '2025-05-02', N'Công ty Dược DEF', '', 'Success',  2),
	( 3, 'GR250503001', '2025-05-03', N'Công ty Dược GHI', '', 'Success',  3),
	( 4, 'GR250504001', '2025-05-04', N'Công ty Dược JKL', '', 'Success',  4),
	( 5, 'GR250505001', '2025-05-05', N'Công ty Dược MNO', '', 'Success',  5),
	( 6, 'GR250506001', '2025-05-06', N'Công ty Dược PQR', '', 'Success',  6),
	( 7, 'GR250507001', '2025-05-07', N'Công ty Dược STU', '', 'Success',  7),
	( 8, 'GR250508001', '2025-05-08', N'Công ty Dược VWX', '', 'Success',  8),
	( 9, 'GR250509001', '2025-05-09', N'Công ty Dược YZA', '', 'Success',  9),
	(10, 'GR250510001', '2025-05-10', N'Công ty Dược BCD', '', 'Success', 10),
	(11,'GR250201001','2025-02-01',N'Nhà cung cấp VinaPharm','', 'Success',6),
        (12,'GR250203001','2025-02-03',N'Nhà cung cấp Stada VN','',  'Success',7),
        (13,'GR250304001','2025-03-04',N'CT TNHH Phú Tài','',       'Success',8),
        (14,'GR250401001','2025-04-01',N'AGCare Việt Nam','',       'Success',9),
        (15,'GR250515001','2025-05-15',N'Dược Hà Tây','',           'Success',11);    
SET IDENTITY_INSERT GoodsReceipts OFF;


/*======================================================
 8) GOODS RECEIPT DETAILS  –  PK = GoodsReceiptDetailID
======================================================*/
SET IDENTITY_INSERT GoodsReceiptDetails ON;
INSERT INTO GoodsReceiptDetails
    (GoodsReceiptDetailID, QtyIn, BatchID, GoodsReceiptReceiptID) VALUES
    -- Receipt 1  → Batch 1, 2
	( 1 , 250, 1 , 1),
	( 2 , 300, 2 , 1),

	-- Receipt 2  → Batch 3, 4
	( 3 , 350, 3 , 2),
	( 4 , 400, 4 , 2),

	-- Receipt 3  → Batch 5, 6
	( 5 , 450, 5 , 3),
	( 6 , 200, 6 , 3),

	-- Receipt 4  → Batch 7, 8
	( 7 , 220, 7 , 4),
	( 8 , 240, 8 , 4),

	-- Receipt 5  → Batch 9, 10
	( 9 , 260, 9 , 5),
	(10 , 280,10 , 5),

	-- Receipt 6  → Batch 1, 2 (nhập bổ sung)
	(11 , 150, 1 , 6),
	(12 , 170, 2 , 6),

	-- Receipt 7  → Batch 3, 4
	(13 , 130, 3 , 7),
	(14 , 140, 4 , 7),

	-- Receipt 8  → Batch 5, 6
	(15 , 160, 5 , 8),
	(16 , 180, 6 , 8),

	-- Receipt 9  → Batch 7, 8
	(17 , 190, 7 , 9),
	(18 , 210, 8 , 9),

	-- Receipt 10 → Batch 9, 10
	(19 , 230, 9 ,10),
	(20 , 250,10 ,10),
(21,400,26,11),(22,350,27,12),
(23,500,28,13),(24,450,29,13),
(25,380,30,14),(26,360,31,14),
(27,200,32,15),(28,180,33,15),
(29,150,34,15),(30,170,35,15);
SET IDENTITY_INSERT GoodsReceiptDetails OFF;
GO

/*======================================================
  9) INVOICES  –  PK = InvoiceID
======================================================*/
SET IDENTITY_INSERT Invoices ON;
INSERT INTO Invoices
    (InvoiceID, InvoiceCode, CreatedDate, Note, InvoiceStatus, TaxRate, EmployeeID, CustomerID) VALUES
    ( 1, 'INV230801001', '2023-08-01', N'Hóa đơn bán thuốc', 'Success', 5,  1,  1),
    ( 2, 'INV230802001', '2023-08-02', N'Hóa đơn bán thiết bị y tế' , 'Success', 5,  2,  2),
    ( 3, 'INV230803001', '2023-08-03', N'Hóa đơn bán thuốc'         , 'Success', 5,  3,  3),
    ( 4, 'INV230804001', '2023-08-04', N'Hóa đơn bán thuốc'         , 'Success', 5,  4,  4),
    ( 5, 'INV230805001', '2023-08-05', N'Hóa đơn bán thiết bị y tế' , 'Success', 5,  5,  5),
    ( 6, 'INV230806001', '2023-08-06', N'Hóa đơn bán thuốc'         , 'Success', 5,  6,  6),
    ( 7, 'INV230807001', '2023-08-07', N'Hóa đơn bán thiết bị y tế' , 'Canceled', 5,  7,  7),
    ( 8, 'INV230808001', '2023-08-08', N'Hóa đơn bán thuốc'         , 'Success', 5,  8,  8),
    ( 9, 'INV230809001', '2023-08-09', N'Hóa đơn bán thuốc'         , 'Success', 5,  9,  9),
    (10, 'INV230810001', '2023-08-10', N'Hóa đơn bán thiết bị y tế' , 'Canceled', 5, 10, 10),
    (11, 'INV241201001', '2024-12-01', N'Hóa đơn bán thuốc', 'Success', 5, 1, 1),
    (12, 'INV241201002', '2024-12-01', N'Hóa đơn bán thiết bị y tế', 'Success', 5, 2, 2),
    (13, 'INV241201003', '2024-12-01', N'Hóa đơn bán thuốc', 'Success', 5, 3, 3),
    (14, 'INV241201004', '2024-12-02', N'Hóa đơn bán thuốc', 'Success', 5, 4, 4),
    (15, 'INV241201005', '2024-12-02', N'Hóa đơn bán thiết bị y tế', 'Success', 5, 6, 5),
    (16, 'INV241201006', '2024-12-03', N'Hóa đơn bán thuốc', 'Success', 5, 7, 6),
    (17, 'INV241201007', '2024-12-03', N'Hóa đơn bán thiết bị y tế', 'Canceled', 5, 8, 7),
    (18, 'INV241201008', '2024-12-04', N'Hóa đơn bán thuốc', 'Success', 5, 9, 8),
    (19, 'INV241201009', '2024-12-04', N'Hóa đơn bán thuốc', 'Success', 5, 11, 9),
    (20, 'INV241201010', '2024-12-05', N'Hóa đơn bán thiết bị y tế', 'Success', 5, 12, 10),
    (21, 'INV241201011', '2024-12-05', N'Hóa đơn bán thuốc', 'Success', 5, 13, 11),
    (22, 'INV241201012', '2024-12-06', N'Hóa đơn bán thuốc', 'Success', 5, 14, 12),
    (23, 'INV241201013', '2024-12-06', N'Hóa đơn bán thiết bị y tế', 'Success', 5, 15, 13),
    (24, 'INV241201014', '2024-12-07', N'Hóa đơn bán thuốc', 'Success', 5, 16, 14),
    (25, 'INV241201015', '2024-12-07', N'Hóa đơn bán thuốc', 'Success', 5, 17, 15),
    (26, 'INV241201016', '2024-12-08', N'Hóa đơn bán thiết bị y tế', 'Success', 5, 18, 16),
    (27, 'INV241201017', '2024-12-08', N'Hóa đơn bán thuốc', 'Success', 5, 19, 17),
    (28, 'INV241201018', '2024-12-09', N'Hóa đơn bán thuốc', 'Success', 5, 1, 18),
    (29, 'INV241201019', '2024-12-09', N'Hóa đơn bán thiết bị y tế', 'Success', 5, 2, 19),
    (30, 'INV241201020', '2024-12-10', N'Hóa đơn bán thuốc', 'Success', 5, 3, 20),
    (31, 'INV250101001', '2025-01-01', N'Hóa đơn bán thuốc', 'Success', 5, 4, 1),
    (32, 'INV250101002', '2025-01-01', N'Hóa đơn bán thiết bị y tế', 'Success', 5, 6, 2),
    (33, 'INV250101003', '2025-01-02', N'Hóa đơn bán thuốc', 'Success', 5, 7, 3),
    (34, 'INV250101004', '2025-01-02', N'Hóa đơn bán thuốc', 'Success', 5, 8, 4),
    (35, 'INV250101005', '2025-01-03', N'Hóa đơn bán thiết bị y tế', 'Success', 5, 9, 5),
    (36, 'INV250101006', '2025-01-03', N'Hóa đơn bán thuốc', 'Success', 5, 11, 6),
    (37, 'INV250101007', '2025-01-04', N'Hóa đơn bán thuốc', 'Success', 5, 12, 7),
    (38, 'INV250101008', '2025-01-04', N'Hóa đơn bán thiết bị y tế', 'Success', 5, 13, 8),
    (39, 'INV250101009', '2025-01-05', N'Hóa đơn bán thuốc', 'Success', 5, 14, 9),
    (40, 'INV250101010', '2025-01-05', N'Hóa đơn bán thuốc', 'Success', 5, 15, 10),
-- Tháng 01
(41,'INV250106001','2025-01-06',N'Hóa đơn bán thuốc'         ,'Success',5, 6,  3),
(42,'INV250110001','2025-01-10',N'Hóa đơn thiết bị y tế'    ,'Success',5, 7, 12),
-- Tháng 02
(43,'INV250205001','2025-02-05',N'Hóa đơn bán thuốc'         ,'Success',5, 8,  4),
(44,'INV250212001','2025-02-12',N'Hóa đơn bán thuốc'         ,'Canceled',5, 9,  6),
(45,'INV250218001','2025-02-18',N'Hóa đơn thiết bị y tế'    ,'Success',5,11, 15),
-- Tháng 03
(46,'INV250305001','2025-03-05',N'Hóa đơn bán thuốc'         ,'Success',5,12,  8),
(47,'INV250312001','2025-03-12',N'Hóa đơn thiết bị y tế'    ,'Success',5,13, 10),
(48,'INV250320001','2025-03-20',N'Hóa đơn bán thuốc'         ,'Success',5,14,  2),
-- Tháng 04
(49,'INV250405001','2025-04-05',N'Hóa đơn bán thuốc'         ,'Success',5,16,  5),
(50,'INV250412001','2025-04-12',N'Hóa đơn thiết bị y tế'    ,'Success',5,17, 18),
(51,'INV250420001','2025-04-20',N'Hóa đơn bán thuốc'         ,'Canceled',5,18,  7),
-- Tháng 05
(52,'INV250506001','2025-05-06',N'Hóa đơn thiết bị y tế'    ,'Success',5, 1, 14),
(53,'INV250512001','2025-05-12',N'Hóa đơn bán thuốc'         ,'Success',5, 2,  9),
(54,'INV250520001','2025-05-20',N'Hóa đơn bán thuốc'         ,'Success',5, 3, 11),
-- Tháng 06
(55,'INV250604001','2025-06-04',N'Hóa đơn bán thuốc'         ,'Success',5, 4, 13),
(56,'INV250610001','2025-06-10',N'Hóa đơn thiết bị y tế'    ,'Success',5, 6, 16),
(57,'INV250615001','2025-06-15',N'Hóa đơn bán thuốc'         ,'Success',5, 7, 19),
(58,'INV250621001','2025-06-21',N'Hóa đơn bán thuốc'         ,'Canceled',5, 8, 20),
(59,'INV250626001','2025-06-26',N'Hóa đơn thiết bị y tế'    ,'Success',5, 9,  1),
(60,'INV250630001','2025-06-30',N'Hóa đơn bán thuốc'         ,'Success',5,11,  2);
SET IDENTITY_INSERT Invoices OFF;


/*======================================================
  10) INVOICE DETAILS  –  PK = InvoiceDetailID
======================================================*/
SET IDENTITY_INSERT InvoiceDetails ON;
INSERT INTO InvoiceDetails
    (InvoiceDetailID, Quantity, UnitPrice, InvoiceID, BatchID)
VALUES
    -- I001: Augclamox 250  → BatchID = 1
    ( 1,  2,   48000,   1,  1),
    -- I002: Casoran        → BatchID = 2
    ( 2,  1,   55000,   2,  2),
    -- I003: Bông y tế      → BatchID = 11  (mới tạo)
    ( 3,  4,    2500,   3, 11),
    -- I004: Bộ kit cấp cứu → BatchID = 12  (mới tạo)
    ( 4,  1,  160000,   4, 12),
    -- I005: 1-AL           → BatchID = 5
    ( 5,  3,   25000,   5,  5),
    -- I006: 20% Fat Emul.  → BatchID = 6
    ( 6,  1,   20000,   6,  6),
    -- I007: 3B-Medi        → BatchID = 7
    ( 7,  4,   15000,   7,  7),
    -- I008: Miếng dán SK   → BatchID = 13  (mới tạo)
    ( 8,  6,    8000,   8, 13),
    -- I009: 3BTP           → BatchID = 9
    ( 9,  1,   16000,   9,  9),
    -- I010: 3Bpluzs F      → BatchID = 10
    (10,  3,   17000,  10, 10),

       (11, 2, 48000, 11, 14),
    (12, 3, 55000, 11, 16),
    
    -- Invoice 12
    (13, 5, 6000, 12, 22),
    (14, 10, 4000, 12, 24),
    
    -- Invoice 13
    (15, 2, 65000, 13, 18),
    (16, 1, 35000, 13, 20),
    
    -- Invoice 14
    (17, 3, 48000, 14, 15),
    (18, 2, 55000, 14, 17),
    
    -- Invoice 15
    (19, 4, 6000, 15, 23),
    (20, 8, 4000, 15, 25),
    
    -- Invoice 16
    (21, 2, 65000, 16, 19),
    (22, 3, 35000, 16, 21),
    
    -- Invoice 17 (Canceled)
    (23, 1, 48000, 17, 14),
    (24, 2, 55000, 17, 16),
    
    -- Invoice 18
    (25, 3, 65000, 18, 18),
    (26, 2, 35000, 18, 20),
    
    -- Invoice 19
    (27, 4, 48000, 19, 15),
    (28, 1, 55000, 19, 17),
    
    -- Invoice 20
    (29, 6, 6000, 20, 22),
    (30, 12, 4000, 20, 24),
    
    -- Invoice 21
    (31, 2, 65000, 21, 19),
    (32, 3, 35000, 21, 21),
    
    -- Invoice 22
    (33, 3, 48000, 22, 14),
    (34, 2, 55000, 22, 16),
    
    -- Invoice 23
    (35, 4, 6000, 23, 23),
    (36, 8, 4000, 23, 25),
    
    -- Invoice 24
    (37, 2, 65000, 24, 18),
    (38, 1, 35000, 24, 20),
    
    -- Invoice 25
    (39, 3, 48000, 25, 15),
    (40, 2, 55000, 25, 17),
    
    -- Invoice 26
    (41, 5, 6000, 26, 22),
    (42, 10, 4000, 26, 24),
    
    -- Invoice 27
    (43, 2, 65000, 27, 19),
    (44, 3, 35000, 27, 21),
    
    -- Invoice 28
    (45, 3, 48000, 28, 14),
    (46, 2, 55000, 28, 16),
    
    -- Invoice 29
    (47, 4, 6000, 29, 23),
    (48, 8, 4000, 29, 25),
    
    -- Invoice 30
    (49, 2, 65000, 30, 18),
    (50, 1, 35000, 30, 20),
    
    -- Invoice 31
    (51, 3, 48000, 31, 15),
    (52, 2, 55000, 31, 17),
    
    -- Invoice 32
    (53, 5, 6000, 32, 22),
    (54, 10, 4000, 32, 24),
    
    -- Invoice 33
    (55, 2, 65000, 33, 19),
    (56, 3, 35000, 33, 21),
    
    -- Invoice 34
    (57, 3, 48000, 34, 14),
    (58, 2, 55000, 34, 16),
    
    -- Invoice 35
    (59, 4, 6000, 35, 23),
    (60, 8, 4000, 35, 25),
    
    -- Invoice 36
    (61, 2, 65000, 36, 18),
    (62, 1, 35000, 36, 20),
    
    -- Invoice 37
    (63, 3, 48000, 37, 15),
    (64, 2, 55000, 37, 17),
    
    -- Invoice 38
    (65, 5, 6000, 38, 22),
    (66, 10, 4000, 38, 24),
    
    -- Invoice 39
    (67, 2, 65000, 39, 19),
    (68, 3, 35000, 39, 21),
    
    -- Invoice 40
    (69, 3, 48000, 40, 14),
    (70, 2, 55000, 40, 16),
-- 41
(71,2,48000,41,32),(72,1,17400,41,26),
-- 42
(73,3,25200,42,28),(74,2,16800,42,30),
-- 43
(75,1,55000,43,16),(76,2,20400,43,27),
-- 44 (Canceled vẫn ghi chi tiết)
(77,4,48000,44,15),(78,1,25200,44,29),
-- 45
(79,2,96000,45,34),(80,3,16800,45,31),
-- 46
(81,3,65000,46,18),(82,1,28800,46,32),
-- 47
(83,5,25200,47,29),(84,2,16800,47,30),
-- 48
(85,2,33000,48,33),(86,1,26000,48,23),
-- 49
(87,3,45000,49,18),(88,2,17400,49,26),
-- 50
(89,4,25200,50,28),(90,2,16800,50,31),
-- 51 (Canceled)
(91,1,55000,51,17),(92,2,20400,51,27),
-- 52
(93,2,96000,52,34),(94,4,25200,52,28),
-- 53
(95,3,48000,53,14),(96,2,20400,53,27),
-- 54
(97,1,28800,54,32),(98,3,17400,54,26),
-- 55
(99,2,26000,55,23),(100,2,16800,55,30),
-- 56
(101,4,25200,56,29),(102,1,96000,56,34),
-- 57
(103,3,45000,57,19),(104,2,17400,57,26),
-- 58 (Canceled)
(105,2,28800,58,32),(106,1,20400,58,27),
-- 59
(107,2,33000,59,33),(108,3,25200,59,28),
-- 60
(109,1,55000,60,16),(110,2,16800,60,31);
SET IDENTITY_INSERT InvoiceDetails OFF;
GO