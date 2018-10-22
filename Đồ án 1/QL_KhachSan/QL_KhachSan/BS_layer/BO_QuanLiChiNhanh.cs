using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;
namespace QL_KhachSan.BS_layer
{
    class BO_QuanLiChiNhanh
    {
        public DataSet HienThiDSPhongDaDatCuaKhachHang(DTO_Phong phong)
        {
            DataSet result = new DataSet();
            string sql = "SELECT * FROM Phong WHERE MaChiNhanh = @MaChiNhanh AND NguoiSuDung != 'Free' ";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MaChiNhanh",phong.MaChiNhanh),
            };
            DataAccess data = new DataAccess();
            result = data.getdataset(sql, para);
            return result;
        }
    }
}