alter session set "_ORACLE_SCRIPT"=true; 
-- xoa role
DROP ROLE ROLE_NHANVIEN;
-- tao role nv
CREATE ROLE ROLE_NHANVIEN;

-- xoa role
DROP ROLE ROLE_NGHIENCUU;
-- tao role nv
CREATE ROLE ROLE_NGHIENCUU;

-- xoa role
DROP ROLE ROLE_THANHTRA;
-- tao role nv
CREATE ROLE ROLE_THANHTRA;

-- xoa role
DROP ROLE ROLE_CSYT;
-- tao role nv
CREATE ROLE ROLE_CSYT;

-- xoa role
DROP ROLE ROLE_YBACSI;
-- tao role nv
CREATE ROLE ROLE_YBACSI;


-- xoa role
DROP ROLE ROLE_BENHNHAN;
-- tao role nv
CREATE ROLE ROLE_BENHNHAN;



----------------------------
--TC5
--Tao view
CREATE OR REPLACE VIEW Select_HSBA AS
SELECT HS.*, DVV.MADV, DVV.NGAY AS DV_NGAY, DVV.MAKTV, DVV.KETQUA
FROM HSBA HS, NHANVIEN NV, KHOA K, HSBA_DV DVV
WHERE HS.MACSYT = NV.CSYT
AND NV.USERNAME = SYS_CONTEXT ('USERENV', 'SESSION_USER')
AND HS.MAKHOA = K.MAKHOA 
AND K.TENKHOA = NV.CHUYENKHOA
AND DVV.MA_HSBA = HS.MAHSBA
AND NV.VAITRO = 4;

--TAOUSER&ROLE
DROP USER NGHIENCUU_1 CASCADE ;
DROP USER NGHIENCUU_2 CASCADE ;
DROP USER NGHIENCUU_3 CASCADE ;


-- B2: TAO 3 user NGHIENCUU
alter session set "_ORACLE_SCRIPT"=true; 
CREATE USER NGHIENCUU_1 IDENTIFIED BY 1;
CREATE USER NGHIENCUU_2 IDENTIFIED BY 2;
CREATE USER NGHIENCUU_3 IDENTIFIED BY 3;


GRANT CREATE SESSION TO NGHIENCUU_1;
GRANT CREATE SESSION TO NGHIENCUU_2;
GRANT CREATE SESSION TO NGHIENCUU_3;


-- B5: gan role cho user
GRANT ROLE_NHANVIEN TO NGHIENCUU_1;
GRANT ROLE_NHANVIEN TO NGHIENCUU_2;
GRANT ROLE_NHANVIEN TO NGHIENCUU_3;

GRANT ROLE_NGHIENCUU TO NGHIENCUU_1;
GRANT ROLE_NGHIENCUU TO NGHIENCUU_2;
GRANT ROLE_NGHIENCUU TO NGHIENCUU_3;

--GAN QUYEN CHO ROLE
GRANT SELECT ON Select_HSBA TO ROLE_NHANVIEN;


-----------------------TC2------------------------
-- co 5 nhan vien thuoc so y te voi vai tro "thanh tra"
-- cac nhan vien giu vai tro thanh tra co the Ä‘oc du lieu tren tat ca cac bang
-- nhung khong co quyen them xoa sua cac bang nay

-- B1: drop user
DROP USER THANHTRA_6 CASCADE ;
DROP USER THANHTRA_7 CASCADE ;
DROP USER THANHTRA_8 CASCADE ;
DROP USER THANHTRA_9 CASCADE ;
DROP USER THANHTRA_10 CASCADE ;

-- B2: tao 5 user thanh tra
alter session set "_ORACLE_SCRIPT"=true; 
CREATE USER THANHTRA_6 IDENTIFIED BY 6;
CREATE USER THANHTRA_7 IDENTIFIED BY 7;
CREATE USER THANHTRA_8 IDENTIFIED BY 8;
CREATE USER THANHTRA_9 IDENTIFIED BY 9;
CREATE USER THANHTRA_10 IDENTIFIED BY 10;

GRANT CREATE SESSION TO THANHTRA_6;
GRANT CREATE SESSION TO THANHTRA_7;
GRANT CREATE SESSION TO THANHTRA_8;
GRANT CREATE SESSION TO THANHTRA_9;
GRANT CREATE SESSION TO THANHTRA_10;


-- B5: gan role cho user
GRANT ROLE_THANHTRA TO THANHTRA_6;
GRANT ROLE_THANHTRA TO THANHTRA_7;
GRANT ROLE_THANHTRA TO THANHTRA_8;
GRANT ROLE_THANHTRA TO THANHTRA_9;
GRANT ROLE_THANHTRA TO THANHTRA_10;

GRANT ROLE_NHANVIEN TO THANHTRA_6;
GRANT ROLE_NHANVIEN TO THANHTRA_7;
GRANT ROLE_NHANVIEN TO THANHTRA_8;
GRANT ROLE_NHANVIEN TO THANHTRA_9;
GRANT ROLE_NHANVIEN TO THANHTRA_10;

-- B6: gan quyen cho role
GRANT SELECT ON HSBA_DV TO ROLE_THANHTRA;
GRANT SELECT ON NHANVIEN TO ROLE_THANHTRA;
GRANT SELECT ON BENHNHAN TO ROLE_THANHTRA;
GRANT SELECT ON KHOA TO ROLE_THANHTRA;
GRANT SELECT ON CSYT TO ROLE_THANHTRA;
GRANT SELECT ON HSBA TO ROLE_THANHTRA;

---------------------------TC3----------------------------
-- Co 5 tai khoan thuoc role CSYT
-- Role CSYT co quyen them hoac xoa du lieu phat sinh tu chinh csyt cua minh, trong thang
-- hien tai tu ngay 5 - 27 hang thang
-- Them va xoa dong tren HSBA
-- Them va xoa dong tren HSBA_DV

-- B1: drop user
DROP USER CSYT_1 CASCADE ;
DROP USER CSYT_2 CASCADE ;
DROP USER CSYT_3 CASCADE ;
DROP USER CSYT_4 CASCADE ;
DROP USER CSYT_5 CASCADE ;

-- B2: tao 5 user thanh tra
alter session set "_ORACLE_SCRIPT"=true; 
CREATE USER CSYT_1 IDENTIFIED BY 1;
CREATE USER CSYT_2 IDENTIFIED BY 2;
CREATE USER CSYT_3 IDENTIFIED BY 3;
CREATE USER CSYT_4 IDENTIFIED BY 4;
CREATE USER CSYT_5 IDENTIFIED BY 5;

GRANT CREATE SESSION TO CSYT_1;
GRANT CREATE SESSION TO CSYT_2;
GRANT CREATE SESSION TO CSYT_3; 
GRANT CREATE SESSION TO CSYT_4; 
GRANT CREATE SESSION TO CSYT_5;


-- B5: gan role cho user
GRANT ROLE_NHANVIEN TO CSYT_1;
GRANT ROLE_NHANVIEN TO CSYT_2;
GRANT ROLE_NHANVIEN TO CSYT_3;
GRANT ROLE_NHANVIEN TO CSYT_4;
GRANT ROLE_NHANVIEN TO CSYT_5;

GRANT ROLE_CSYT TO CSYT_1;
GRANT ROLE_CSYT TO CSYT_2;
GRANT ROLE_CSYT TO CSYT_3;
GRANT ROLE_CSYT TO CSYT_4;
GRANT ROLE_CSYT TO CSYT_5;

-- B6: gan quyen cho role
GRANT EXECUTE ON DELETE_HSBA    TO ROLE_CSYT;
GRANT EXECUTE ON DELETE_HSBA_DV TO ROLE_CSYT;
GRANT EXECUTE ON INSERT_HSBA    TO ROLE_CSYT;
GRANT EXECUTE ON INSERT_HSBA_DV TO ROLE_CSYT;

----------------------TC4-------------------------------
--5 nhan vien co vai tro la y/bac si thuoc role YBACSI
-- role YBACSI co quyen xem HSBA ma ho da chua tri, ket qua dich vu tra ve va thong tin benh nhan.
CREATE OR REPLACE VIEW View_YBacSi_Select_HSBA AS
SELECT HS.*
FROM HSBA HS, NHANVIEN NV
WHERE HS.MACSYT = NV.CSYT
AND NV.USERNAME = SYS_CONTEXT ('USERENV', 'SESSION_USER')
AND NV.MANV = HS.MABS
AND NV.VAITRO = 3;

CREATE OR REPLACE VIEW View_YBacSi_Select_KetQua_HSBADV AS
SELECT HS.*, DV.KETQUA
FROM HSBA HS, NHANVIEN NV, HSBA_DV DV
WHERE HS.MACSYT = NV.CSYT
AND NV.USERNAME = SYS_CONTEXT ('USERENV', 'SESSION_USER')
AND NV.MANV = HS.MABS
AND HS.MAHSBA = DV.MA_HSBA 
AND NV.VAITRO = 3;

CREATE OR REPLACE VIEW View_YBacSi_Select_BenhNhan AS
SELECT BN.*
FROM HSBA HS, NHANVIEN NV, BENHNHAN BN
WHERE HS.MACSYT = NV.CSYT
AND NV.USERNAME = SYS_CONTEXT ('USERENV', 'SESSION_USER')
AND NV.MANV = HS.MABS
AND HS.MABN = BN.MABN
AND NV.VAITRO = 3;


-- B1: drop user
DROP USER BACSI_1 CASCADE ;
DROP USER BACSI_2 CASCADE ;
DROP USER BACSI_3 CASCADE ;
DROP USER BACSI_4 CASCADE ;
DROP USER BACSI_5 CASCADE ;

-- B2: TAO 5 user NV
alter session set "_ORACLE_SCRIPT"=true; 
CREATE USER BACSI_1 IDENTIFIED BY 1;
CREATE USER BACSI_2 IDENTIFIED BY 2;
CREATE USER BACSI_3 IDENTIFIED BY 3;
CREATE USER BACSI_4 IDENTIFIED BY 4;
CREATE USER BACSI_5 IDENTIFIED BY 5;

GRANT CREATE SESSION TO BACSI_1; 
GRANT CREATE SESSION TO BACSI_2; 
GRANT CREATE SESSION TO BACSI_3; 
GRANT CREATE SESSION TO BACSI_4; 
GRANT CREATE SESSION TO BACSI_5;


-- B5: gan role cho user
GRANT ROLE_NHANVIEN TO BACSI_1; 
GRANT ROLE_NHANVIEN TO BACSI_2; 
GRANT ROLE_NHANVIEN TO BACSI_3; 
GRANT ROLE_NHANVIEN TO BACSI_4; 
GRANT ROLE_NHANVIEN TO BACSI_5; 

GRANT ROLE_YBACSI TO BACSI_1; 
GRANT ROLE_YBACSI TO BACSI_2; 
GRANT ROLE_YBACSI TO BACSI_3; 
GRANT ROLE_YBACSI TO BACSI_4; 
GRANT ROLE_YBACSI TO BACSI_5; 

--GAN QUYEN CHO ROLE
GRANT SELECT ON View_YBacSi_Select_HSBA TO ROLE_YBACSI;
GRANT SELECT ON View_YBacSi_Select_KetQua_HSBADV TO ROLE_YBACSI;
GRANT SELECT ON View_YBacSi_Select_BenhNhan TO ROLE_YBACSI;

