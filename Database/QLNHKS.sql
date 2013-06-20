chi_tiet_bang_kephieu_dat_tiecSET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

CREATE SCHEMA IF NOT EXISTS `QLNHKS` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `QLNHKS` ;

-- -----------------------------------------------------
-- Table `QLNHKS`.`NHAN_VIEN`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `QLNHKS`.`NHAN_VIEN` (
  `MaNhanVien` INT NOT NULL AUTO_INCREMENT ,
  `TenNhanVien` VARCHAR(45) CHARACTER SET 'utf8' COLLATE 'utf8_general_ci' NOT NULL ,
  `DiaChi` TEXT CHARACTER SET 'utf8' COLLATE 'utf8_general_ci' NOT NULL ,
  `SDT` VARCHAR(20) NOT NULL ,
  `ChucVu` VARCHAR(20) NOT NULL ,
  `UserName` VARCHAR(45) NOT NULL ,
  `Password` VARCHAR(45) NOT NULL ,
  PRIMARY KEY (`MaNhanVien`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `QLNHKS`.`QUY_DINH`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `QLNHKS`.`QUY_DINH` (
  `ID` INT NOT NULL ,
  `SoKhachToiDaTrongMotPhong` INT NOT NULL ,
  `TyLeCoc` FLOAT NOT NULL ,
  `SoGioThueVoiGiaGoc` INT NOT NULL ,
  `TyLeGiaPhongNeuThueTheoNgay` FLOAT NOT NULL ,
  PRIMARY KEY (`ID`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `QLNHKS`.`LOAI_PHONG`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `QLNHKS`.`LOAI_PHONG` (
  `MaLoaiPhong` INT NOT NULL AUTO_INCREMENT ,
  `TenLoaiPhong` VARCHAR(45) NOT NULL ,
  `DonGia` FLOAT NOT NULL ,
  PRIMARY KEY (`MaLoaiPhong`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `QLNHKS`.`PHONG`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `QLNHKS`.`PHONG` (
  `MaPhong` INT NOT NULL AUTO_INCREMENT ,
  `MaLoaiPhong` INT NOT NULL ,
  `TenPhong` VARCHAR(45) NOT NULL ,
  `TinhTrangHienTai` TINYINT(1) NOT NULL ,
  `MoTa` TEXT CHARACTER SET 'utf8' COLLATE 'utf8_general_ci' NULL ,
  PRIMARY KEY (`MaPhong`) ,
  INDEX `fk_PHONG_LOAI_PHONG_idx` (`MaLoaiPhong` ASC) ,
  CONSTRAINT `fk_PHONG_LOAI_PHONG`
    FOREIGN KEY (`MaLoaiPhong` )
    REFERENCES `QLNHKS`.`LOAI_PHONG` (`MaLoaiPhong` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `QLNHKS`.`PHIEU_DAT_CHO`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `QLNHKS`.`PHIEU_DAT_CHO` (
  `MaPhieuDatCho` INT NOT NULL AUTO_INCREMENT ,
  `TenNguoiDatCho` VARCHAR(45) NOT NULL ,
  `SDT` VARCHAR(45) NOT NULL ,
  `DiaChi` TEXT CHARACTER SET 'utf8' COLLATE 'utf8_lithuanian_ci' NOT NULL ,
  `TongCoc` FLOAT NOT NULL ,
  `ThoiDiemDat` DATETIME NOT NULL ,
  `ThoiDiemDen` DATETIME NOT NULL ,
  `ThoiDiemDi` DATETIME NOT NULL ,
  PRIMARY KEY (`MaPhieuDatCho`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `QLNHKS`.`CHI_TIET_PHIEU_DAT_CHO`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `QLNHKS`.`CHI_TIET_PHIEU_DAT_CHO` (
  `MaChiTietPhieuDatCho` INT NOT NULL AUTO_INCREMENT ,
  `MaPhieuDatCho` INT NOT NULL ,
  `MaPhong` INT NOT NULL ,
  `DonGia` FLOAT NOT NULL ,
  `Coc` FLOAT NOT NULL ,
  PRIMARY KEY (`MaChiTietPhieuDatCho`) ,
  INDEX `fk_CHI_TIET_PHEU_DAT_CHO_PHIEU_DAT_CHO1_idx` (`MaPhieuDatCho` ASC) ,
  INDEX `fk_CHI_TIET_PHEU_DAT_CHO_PHONG1_idx` (`MaPhong` ASC) ,
  CONSTRAINT `fk_CHI_TIET_PHEU_DAT_CHO_PHIEU_DAT_CHO1`
    FOREIGN KEY (`MaPhieuDatCho` )
    REFERENCES `QLNHKS`.`PHIEU_DAT_CHO` (`MaPhieuDatCho` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_CHI_TIET_PHEU_DAT_CHO_PHONG1`
    FOREIGN KEY (`MaPhong` )
    REFERENCES `QLNHKS`.`PHONG` (`MaPhong` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `QLNHKS`.`PHIEU_THU`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `QLNHKS`.`PHIEU_THU` (
  `MaPhieuThu` INT NOT NULL AUTO_INCREMENT ,
  `TenKhach` VARCHAR(45) NOT NULL ,
  `CMND` VARCHAR(20) NOT NULL ,
  `MaNhanVien` INT NOT NULL ,
  `ThoiDiemThu` DATETIME NOT NULL ,
  `TongTienThu` FLOAT NOT NULL ,
  PRIMARY KEY (`MaPhieuThu`) ,
  INDEX `fk_PHIEU_THU_NHAN_VIEN1_idx` (`MaNhanVien` ASC) ,
  CONSTRAINT `fk_PHIEU_THU_NHAN_VIEN1`
    FOREIGN KEY (`MaNhanVien` )
    REFERENCES `QLNHKS`.`NHAN_VIEN` (`MaNhanVien` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `QLNHKS`.`LOAI_PHI`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `QLNHKS`.`LOAI_PHI` (
  `MaLoaiPhi` INT NOT NULL AUTO_INCREMENT ,
  `TenLoaiPhi` VARCHAR(45) NOT NULL ,
  `GhiChu` TEXT CHARACTER SET 'utf8' COLLATE 'utf8_general_ci' NULL ,
  PRIMARY KEY (`MaLoaiPhi`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `QLNHKS`.`CHI_TIET_PHIEU_THU`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `QLNHKS`.`CHI_TIET_PHIEU_THU` (
  `MaChiTietPhieuThu` INT NOT NULL AUTO_INCREMENT ,
  `MaPhieuThu` INT NOT NULL ,
  `MaLoaiPhi` INT NOT NULL ,
  `SoTienThu` FLOAT NOT NULL ,
  PRIMARY KEY (`MaChiTietPhieuThu`) ,
  INDEX `fk_CHI_TIET_PHIEU_THU_PHIEU_THU1_idx` (`MaPhieuThu` ASC) ,
  INDEX `fk_CHI_TIET_PHIEU_THU_LOAI_PHI1_idx` (`MaLoaiPhi` ASC) ,
  CONSTRAINT `fk_CHI_TIET_PHIEU_THU_PHIEU_THU1`
    FOREIGN KEY (`MaPhieuThu` )
    REFERENCES `QLNHKS`.`PHIEU_THU` (`MaPhieuThu` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_CHI_TIET_PHIEU_THU_LOAI_PHI1`
    FOREIGN KEY (`MaLoaiPhi` )
    REFERENCES `QLNHKS`.`LOAI_PHI` (`MaLoaiPhi` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `QLNHKS`.`BAO_CAO_DOANH_THU`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `QLNHKS`.`BAO_CAO_DOANH_THU` (
  `MaBaoCao` INT NOT NULL AUTO_INCREMENT ,
  `MaPhong` INT NOT NULL ,
  `DoanhThu` FLOAT NOT NULL ,
  `TyLeDoanhThu` FLOAT NOT NULL ,
  `ThoiDiemLapBaoCao` DATETIME NOT NULL ,
  PRIMARY KEY (`MaBaoCao`) ,
  INDEX `fk_BAO_CAO_DOANH_THU_PHONG1_idx` (`MaPhong` ASC) ,
  CONSTRAINT `fk_BAO_CAO_DOANH_THU_PHONG1`
    FOREIGN KEY (`MaPhong` )
    REFERENCES `QLNHKS`.`PHONG` (`MaPhong` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `QLNHKS`.`PHIEU_DAT_TIEC`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `QLNHKS`.`PHIEU_DAT_TIEC` (
  `MaPhieuDatTiec` INT NOT NULL AUTO_INCREMENT ,
  `TenKhach` VARCHAR(45) NOT NULL ,
  `MaPhong` INT NOT NULL ,
  `ThoiDiem` DATETIME NOT NULL ,
  `TongTien` FLOAT NOT NULL ,
  `TinhTrangThanhToan` TINYINT(1) NOT NULL DEFAULT FALSE ,
  PRIMARY KEY (`MaPhieuDatTiec`) ,
  INDEX `fk_PHIEU_DAT_TIEC_PHONG1_idx` (`MaPhong` ASC) ,
  CONSTRAINT `fk_PHIEU_DAT_TIEC_PHONG1`
    FOREIGN KEY (`MaPhong` )
    REFERENCES `QLNHKS`.`PHONG` (`MaPhong` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `QLNHKS`.`CHI_TIET_PHIEU_DAT_TIEC`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `QLNHKS`.`CHI_TIET_PHIEU_DAT_TIEC` (
  `MaChiTietPhieuDatTiec` INT NOT NULL AUTO_INCREMENT ,
  `MaPhieuDatTiec` INT NOT NULL ,
  `TenMon` TEXT CHARACTER SET 'utf8' COLLATE 'utf8_general_ci' NOT NULL ,
  `DonGia` FLOAT NOT NULL ,
  `SoLuong` INT NOT NULL ,
  `YeuCau` TEXT CHARACTER SET 'utf8' COLLATE 'utf8_general_ci' NULL ,
  PRIMARY KEY (`MaChiTietPhieuDatTiec`) ,
  INDEX `fk_CHI_TIET_PHIEU_DAT_TIEC_PHIEU_DAT_TIEC1_idx` (`MaPhieuDatTiec` ASC) ,
  CONSTRAINT `fk_CHI_TIET_PHIEU_DAT_TIEC_PHIEU_DAT_TIEC1`
    FOREIGN KEY (`MaPhieuDatTiec` )
    REFERENCES `QLNHKS`.`PHIEU_DAT_TIEC` (`MaPhieuDatTiec` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `QLNHKS`.`BANG_KE`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `QLNHKS`.`BANG_KE` (
  `MaBangKe` INT NOT NULL AUTO_INCREMENT ,
  `MaPhong` INT NOT NULL ,
  `TongChiPhi` FLOAT NOT NULL ,
  `TinhTrangThanhToan` TINYINT(1) NOT NULL DEFAULT FALSE ,
  PRIMARY KEY (`MaBangKe`) ,
  INDEX `fk_BANG_KE_PHONG1_idx` (`MaPhong` ASC) ,
  CONSTRAINT `fk_BANG_KE_PHONG1`
    FOREIGN KEY (`MaPhong` )
    REFERENCES `QLNHKS`.`PHONG` (`MaPhong` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `QLNHKS`.`CHI_TIET_BANG_KE`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `QLNHKS`.`CHI_TIET_BANG_KE` (
  `MaChiTietBangKe` INT NOT NULL AUTO_INCREMENT ,
  `MaBangKe` INT NOT NULL ,
  `TenDichVu` TEXT CHARACTER SET 'utf8' COLLATE 'utf8_general_ci' NOT NULL ,
  `ThoiDiemGoi` DATETIME NOT NULL ,
  `DonGia` FLOAT NOT NULL ,
  `SoLuong` INT NOT NULL ,
  `GhiChu` TEXT CHARACTER SET 'utf8' COLLATE 'utf8_general_ci' NULL ,
  PRIMARY KEY (`MaChiTietBangKe`) ,
  INDEX `fk_CHI_TIET_BANG_KE_BANG_KE1_idx` (`MaBangKe` ASC) ,
  CONSTRAINT `fk_CHI_TIET_BANG_KE_BANG_KE1`
    FOREIGN KEY (`MaBangKe` )
    REFERENCES `QLNHKS`.`BANG_KE` (`MaBangKe` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `QLNHKS`.`PHIEU_DEN`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `QLNHKS`.`PHIEU_DEN` (
  `MaPhieuDen` INT NOT NULL AUTO_INCREMENT ,
  `TenKhachDaiDien` VARCHAR(45) NOT NULL ,
  `CMND` VARCHAR(20) NOT NULL ,
  `ThoiDiemDen` DATETIME NOT NULL ,
  `ThoiDiemDi` DATETIME NOT NULL ,
  `TongChiPhi` FLOAT NOT NULL ,
  `TinhTrangThanhToan` TINYINT(1) NOT NULL DEFAULT FALSE ,
  PRIMARY KEY (`MaPhieuDen`) )
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `QLNHKS`.`CHI_TIET_PHIEU_DEN`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `QLNHKS`.`CHI_TIET_PHIEU_DEN` (
  `MaChiTietPhieuDen` INT NOT NULL AUTO_INCREMENT ,
  `MaPhieuDen` INT NOT NULL ,
  `MaPhong` INT NOT NULL ,
  `TenKhachHang` VARCHAR(45) NOT NULL ,
  `CMND` VARCHAR(20) NOT NULL ,
  `DonGia` FLOAT NOT NULL ,
  PRIMARY KEY (`MaChiTietPhieuDen`) ,
  INDEX `fk_CHI_TIET_PHIEU_DEN_PHIEU_DEN1_idx` (`MaPhieuDen` ASC) ,
  INDEX `fk_CHI_TIET_PHIEU_DEN_PHONG1_idx` (`MaPhong` ASC) ,
  CONSTRAINT `fk_CHI_TIET_PHIEU_DEN_PHIEU_DEN1`
    FOREIGN KEY (`MaPhieuDen` )
    REFERENCES `QLNHKS`.`PHIEU_DEN` (`MaPhieuDen` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_CHI_TIET_PHIEU_DEN_PHONG1`
    FOREIGN KEY (`MaPhong` )
    REFERENCES `QLNHKS`.`PHONG` (`MaPhong` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

USE `QLNHKS` ;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

-- -----------------------------------------------------
-- INSERT SAMPLE DATA INTO TABLES
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Insert sample data for LOAI_PHONG table
-- -----------------------------------------------------
INSERT INTO `qlnhks`.`loai_phong` (`MaLoaiPhong`, `TenLoaiPhong`, `DonGia`) VALUES ('1', 'VIP', '200000');
INSERT INTO `qlnhks`.`loai_phong` (`MaLoaiPhong`, `TenLoaiPhong`, `DonGia`) VALUES ('2', 'MEDIUM', '150000');
INSERT INTO `qlnhks`.`loai_phong` (`MaLoaiPhong`, `TenLoaiPhong`, `DonGia`) VALUES ('3', 'NORMAL', '100000');

-- -----------------------------------------------------
-- Insert sample data for PHONG table
-- -----------------------------------------------------
INSERT INTO `qlnhks`.`phong` (`MaPhong`, `MaLoaiPhong`, `TenPhong`, `TinhTrangHienTai`, `MoTa`) VALUES ('1', '1', 'P101', '1', 'VIP');
INSERT INTO `qlnhks`.`phong` (`MaPhong`, `MaLoaiPhong`, `TenPhong`, `TinhTrangHienTai`, `MoTa`) VALUES ('2', '1', 'P202', '0', 'VIP');
INSERT INTO `qlnhks`.`phong` (`MaPhong`, `MaLoaiPhong`, `TenPhong`, `TinhTrangHienTai`, `MoTa`) VALUES ('3', '2', 'P301', '1', 'MEDIUM');
INSERT INTO `qlnhks`.`phong` (`MaPhong`, `MaLoaiPhong`, `TenPhong`, `TinhTrangHienTai`, `MoTa`) VALUES ('4', '2', 'P402', '0', 'MEDIUM');
INSERT INTO `qlnhks`.`phong` (`MaPhong`, `MaLoaiPhong`, `TenPhong`, `TinhTrangHienTai`, `MoTa`) VALUES ('5', '3', 'P501', '1', 'NORMAL');
INSERT INTO `qlnhks`.`phong` (`MaPhong`, `MaLoaiPhong`, `TenPhong`, `TinhTrangHienTai`, `MoTa`) VALUES ('6', '3', 'P602', '0', 'NORMAL');

-- -----------------------------------------------------
-- Insert sample data for QUY_DINH table
-- -----------------------------------------------------
INSERT INTO `qlnhks`.`quy_dinh` (`ID`, `SoKhachToiDaTrongMotPhong`, `TyLeCoc`, `SoGioThueVoiGiaGoc`, `TyLeGiaPhongNeuThueTheoNgay`) VALUES ('1', '3', '20', '3', '70');

-- -----------------------------------------------------
-- Insert sample data for NHAN_VIEN table
-- -----------------------------------------------------
INSERT INTO `qlnhks`.`nhan_vien` (`MaNhanVien`, `TenNhanVien`, `DiaChi`, `SDT`, `ChucVu`, `UserName`, `Password`) VALUES ('1', 'Admin', 'Paradies', '01238059792', 'Admin', 'admin', 'a');
INSERT INTO `qlnhks`.`nhan_vien` (`MaNhanVien`, `TenNhanVien`, `DiaChi`, `SDT`, `ChucVu`, `UserName`, `Password`) VALUES ('2', 'Reception1', 'Đồng Nai', '02453522424', 'Reception', 'reception1', 'r1');
INSERT INTO `qlnhks`.`nhan_vien` (`MaNhanVien`, `TenNhanVien`, `DiaChi`, `SDT`, `ChucVu`, `UserName`, `Password`) VALUES ('3', 'Reception2', 'Vũng Tàu', '09234242452', 'Reception', 'reception2', 'r2');
INSERT INTO `qlnhks`.`nhan_vien` (`MaNhanVien`, `TenNhanVien`, `DiaChi`, `SDT`, `ChucVu`, `UserName`, `Password`) VALUES ('4', 'Reception3', 'Bình Định', '09235325362', 'Reception', 'reception3', 'r3');
INSERT INTO `qlnhks`.`nhan_vien` (`MaNhanVien`, `TenNhanVien`, `DiaChi`, `SDT`, `ChucVu`, `UserName`, `Password`) VALUES ('5', 'Reception4', 'Phú Yên', '01693453453', 'Reception', 'reception4', 'r4');


-- -----------------------------------------------------
-- Insert sample data for LOAI_PHI table
-- -----------------------------------------------------
INSERT INTO `qlnhks`.`loai_phi` (`MaLoaiPhi`, `TenLoaiPhi`, `GhiChu`) VALUES ('1', 'Thuê Phòng', 'Đây là tiền thuê phòng');
INSERT INTO `qlnhks`.`loai_phi` (`MaLoaiPhi`, `TenLoaiPhi`, `GhiChu`) VALUES ('2', 'Đặt tiệc', 'Đây là tiền đặt tiệc');
INSERT INTO `qlnhks`.`loai_phi` (`MaLoaiPhi`, `TenLoaiPhi`, `GhiChu`) VALUES ('3', 'Dịch vụ', 'Đây là tiền do khách gọi thêm các dịch vụ');
