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
    class BO_GiaoDienQuanLi
    {
        public DataSet KT_QuyenQL(DTO_ChiNhanh dto, ref string TenCn)
        {
            DataSet result = new DataSet();
            string sql = @"SELECT * FROM ChiNhanh WHERE MaNguoiQuanLy = @MaNV and MaChiNhanh =@MaCN ";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter ("@MaNV",dto.MaNguoiQuanLy),
                new SqlParameter("@MaCN",dto.MaChiNhanh),

            };
            DataAccess data = new DataAccess();
            result = data.getdataset(sql, para);
            if (result.Tables.Count > 0 && result.Tables[0].Rows.Count > 0)
            {
                TenCn = result.Tables[0].Rows[0][1].ToString();
            }
            return result;
        }
    }
}
