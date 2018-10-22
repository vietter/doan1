using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_KhachSan.BS_layer
{
    public class BO_DangNhapNhanVien
    {
        public DataSet KT_DangNhap(DTO_NhanVien dto, ref string tennv, ref string manv)
        {
            DataSet result = new DataSet();
            string sql = "SELECT * FROM NhanVien WHERE MaNV = @MaNV and MatKhau =@MatKhau ";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter ("@MaNV",dto.MaNhanVien),
                new SqlParameter("@MatKhau",dto.MatKhau),

            };
            DataAccess data = new DataAccess();
            result = data.getdataset(sql, para);
            if (result.Tables.Count > 0 && result.Tables[0].Rows.Count > 0)
            {
                tennv = result.Tables[0].Rows[0][1].ToString();
                manv = result.Tables[0].Rows[0][0].ToString();
            }
            return result;
        }
        public DataSet LayMaChiNhanh(DTO_ChiNhanh chinhanh)
        {
            DataSet result = new DataSet();
            string sql = "SELECT  * FROM ChiNhanh WHERE MaNguoiQuanLy = @MaNguoiQuanLy";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MaNguoiQuanLy",chinhanh.MaNguoiQuanLy),
            };
            DataAccess data = new DataAccess();
            result = data.getdataset(sql, para);
            return result;
        }
    }
}
