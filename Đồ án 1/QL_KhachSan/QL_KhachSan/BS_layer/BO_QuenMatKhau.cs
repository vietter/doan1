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
    class BO_QuenMatKhau
    {
        public DataSet KiemTraSDT(DTO_KhachHang dto)
        {
            DataSet result = new DataSet();
            string sql = @"SELECT * FROM KhachHang WHERE SoDienThoai = @SDT";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@SDT",dto.SDT),
            };
            DataAccess data = new DataAccess();
            result =data.getdataset(sql, para);
            return result;
        }
        public DataSet KiemTraBaoMat(DTO_KhachHang dto)
        {
            DataSet result = new DataSet();
            string sql = @"SELECT * FROM KhachHang WHERE SoDienThoai = @SDT AND CMND = @CMND AND CauHoiBaoMat = @CauHoiBaoMat AND TraLoi = @TraLoi";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@SDT",dto.SDT),
                new SqlParameter("@CMND",dto.CMND),
                new SqlParameter("CauHoiBaoMat",dto.CauHoiBiMat),
                new SqlParameter("TraLoi",dto.TraLoi),
            };
            DataAccess data = new DataAccess();
            result = data.getdataset(sql, para);
            return result;
        }
    }
}
