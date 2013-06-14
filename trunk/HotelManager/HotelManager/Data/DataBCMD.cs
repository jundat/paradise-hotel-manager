using HotelManager.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace HotelManager.Data
{
    /// <summary>
    /// Quản lý thao tác với bảng BCMD
    /// </summary>
    class DataBCMD : DataAbstract
    {
        /// <summary>
        /// Tìm kiếm 1 báo cáo theo tháng
        /// </summary>
        /// <returns>Trả về BCMD nếu tìm thấy, trả về null nếu ko tìm thấy</returns>
        public static BCMD FindThangBaoCao(int thang)
        {
            //mo ket noi
            OleDbConnection ObjCn = DataProvider.ConnectionData();

            //tao chuoi strSQL thao tac CSDL
            string StrSQL = "SELECT * FROM BCMD WHERE ThangBaoCao = ?";

            OleDbCommand ObjCmd = new OleDbCommand(StrSQL, ObjCn);

            ObjCmd.Parameters.Add("@ThangBaoCao", OleDbType.Integer).Value = thang;

            OleDbDataReader ObjReader;
            ObjReader = ObjCmd.ExecuteReader();

            BCMD baocao = new BCMD();

            if(ObjReader.Read())
            {
                baocao.MaBCMD = (int)ObjReader["MaBCMD"];
                baocao.ThangBaoCao = thang;

                return baocao;
            }
            else
                return null;
        }

        public static BCMD FindMaBCMD(int maBCMD)
        {
            //mo ket noi
            OleDbConnection ObjCn = DataProvider.ConnectionData();

            //tao chuoi strSQL thao tac CSDL
            string StrSQL = "SELECT * FROM BCMD WHERE MaBCMD = ?";

            OleDbCommand ObjCmd = new OleDbCommand(StrSQL, ObjCn);

            ObjCmd.Parameters.Add("@MaBCMD", OleDbType.Integer).Value = maBCMD;

            OleDbDataReader ObjReader;
            ObjReader = ObjCmd.ExecuteReader();

            BCMD baocao = new BCMD();

            if (ObjReader.Read())
            {
                baocao.MaBCMD = maBCMD;
                baocao.ThangBaoCao = (int)ObjReader["ThangBaoCao"];

                return baocao;
            }
            else
                return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="thangDuocChon"></param>
        /// <returns>Return MaBCMD</returns>
        public static int Add(int thang)
        {
            OleDbConnection ObjCn = DataProvider.ConnectionData();
            string StrSQL = "INSERT INTO BCMD(ThangBaoCao) values(?)";
            OleDbCommand cmd = new OleDbCommand(StrSQL, ObjCn);

            cmd.Parameters.Add("@ThangBaoCao", OleDbType.Integer).Value = thang;

            cmd.ExecuteNonQuery();

            StrSQL = "SELECT @@IDENTITY";
            cmd = new OleDbCommand(StrSQL, ObjCn);
            int maBCMD = (int)cmd.ExecuteScalar();

            ObjCn.Close();
            return maBCMD;
        }
    }
}
