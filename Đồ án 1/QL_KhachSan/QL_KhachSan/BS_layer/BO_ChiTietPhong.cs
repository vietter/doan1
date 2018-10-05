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
    class BO_ChiTietPhong
    {
        public DataSet HienThi(DTO_HoaDon hoadon)
        {
            DataSet result = new DataSet();
            string sql = "SELECT * FROM HoaDon WHERE MaHD = @MaHD";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter ("@MaHD",hoadon.MaHD),
              
            };
            DataAccess data = new DataAccess();
            result = data.getdataset(sql, para);
            return result;
            
        }
        public int ThemDV(DTO_HoaDon hoadon)
        {
            int result = -1;
            string sql = "INSERT INTO HoaDon VALUES (@TenDichVu,@SoLuong,@ThanhTien,@MaHD,@STT,@MaChiNhanh,@MaPhong,@SoDienThoai,@NgayDatPhong,@NgayTraPhong,@MaDV)";
            SqlParameter[] para = new SqlParameter[]
            {   
                new SqlParameter("@TenDichVu",hoadon.TenDichVu),
                new SqlParameter("@SoLuong",hoadon.SoLuong),
                new SqlParameter("@ThanhTien",hoadon.ThanhTien),
                new SqlParameter("@MaHD",hoadon.MaHD),
                new SqlParameter("@STT",hoadon.STT),
                new SqlParameter("@MaChiNhanh",hoadon.MaChiNhanh),
                new SqlParameter("@MaPhong",hoadon.MaPhong),
                new SqlParameter("@SoDienThoai",hoadon.SoDienThoai),
                new SqlParameter("@NgayDatPhong",hoadon.NgayDatPhong),
                new SqlParameter("@NgayTraPhong",hoadon.NgayTraPhong),
                new SqlParameter("@MaDV",hoadon.MaDV),
            };
            DataAccess data = new DataAccess();
            result = data.Execute(sql, para);
            return result;
        }
        public int XoaDV(DTO_HoaDon hoadon)
        {
            int result = -1;
            string sql = "DELETE FROM HoaDon WHERE MaHD = @MaHD AND STT = @STT";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MaHD",hoadon.MaHD),
                new SqlParameter ("@STT",hoadon.STT),
            };
            DataAccess data = new DataAccess();
            result = data.Execute(sql, para);
            return result;
        }
    }
}
