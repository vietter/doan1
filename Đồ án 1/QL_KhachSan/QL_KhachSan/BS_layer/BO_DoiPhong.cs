﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;
namespace QL_KhachSan.BS_layer
{
    class BO_DoiPhong
    {
        public DataSet DSPhongHienTrong(DTO_HoaDon hoadon)
        {
            DataSet result = new DataSet();
            string sql = "SELECT * FROM Phong WHERE NguoiSuDung = 'Free' AND MaChiNhanh = @MaChiNhanh";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MaChiNhanh",hoadon.MaChiNhanh),
            };
            DataAccess data = new DataAccess();
            result = data.getdataset(sql, para);
            return result;
        }
        public int DoiNguoiSuDung(DTO_HoaDon hoadon)
        {
            int result = -1;
            string sql = "UPDATE Phong SET NguoiSuDung = @NguoiSuDung WHERE MaPhong = @MaPhong AND MaChiNhanh = @MaChiNhanh ";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@NguoiSuDung", hoadon.SoDienThoai),
                new SqlParameter ("@MaPhong",hoadon.MaPhong),
                new SqlParameter ("@MaChiNhanh",hoadon.MaChiNhanh),
            };
            DataAccess data = new DataAccess();
            result = data.Execute(sql, para);
            return result;
        }
        public int DoiHoaDon(DTO_HoaDon hoadon)
        {
            int result = -1;
            string sql = "UPDATE HoaDon SET MaPhong = @MaPhong WHERE MaHD = @MaHD";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MaPhong",hoadon.MaPhong),
                new SqlParameter("@MaHD",hoadon.MaHD),

            };
            DataAccess data = new DataAccess();
            result = data.Execute(sql, para);
            return result;
        }
        
    }
}
