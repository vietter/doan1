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
    class BO_ThongTinKhachHang
    {
        public DataSet ThongTinKhachHang(DTO_KhachHang khachhang)
        {
            DataSet result = new DataSet();
            string sql = "SELECT * FROM KhachHang WHERE SoDienThoai = @SDT";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@SDT",khachhang.SDT),
            };
            DataAccess data = new DataAccess();
            result = data.getdataset(sql, para);
            return result;
        }
    }
}
