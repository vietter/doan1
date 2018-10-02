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
    class BO_ChiTietHoaDon
    {
        public DataSet HienThi(DTO_HoaDon hoadon)
        {
            DataSet result = new DataSet();
            string sql = "SELECT * FROM HoaDon WHERE SoDienThoai = @SDT AND MaPhong = @MaPhong AND MaChiNhanh = @MaChiNhanh";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@SDT",hoadon.SoDienThoai),
                new SqlParameter("@MaPhong",hoadon.MaPhong),
                new SqlParameter("@MaChiNhanh",hoadon.MaChiNhanh),
            };
            DataAccess data = new DataAccess();
            result = data.getdataset(sql, para);
            return result;
        }
        //public int ThemDichVu(DTO_HoaDon hoaDon)
        //{
        //    int result = -1;
        //    string sql = "INSERT INTO HoaDon VALUES (@)"
        //}
    }
}