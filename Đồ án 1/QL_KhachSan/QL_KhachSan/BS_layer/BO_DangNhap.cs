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
    class BO_DangNhap
    {
        public DataSet KT_DangNhap(DTO_KhachHang dto, ref string TenKH)
        {
            DataSet result = new DataSet();
            string sql = @"SELECT * FROM KhachHang WHERE SoDienThoai = @SDT AND MatKhau = @MatKhau";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter ("@SDT",dto.SDT),
                new SqlParameter("@MatKhau",dto.MatKhau),
            };
            DataAccess data = new DataAccess();
            result = data.getdataset(sql, para);
            if(result.Tables.Count >0 && result.Tables[0].Rows.Count>0)
            {
                TenKH = result.Tables[0].Rows[0][1].ToString();
            }
            return result;
        }
    }
}
