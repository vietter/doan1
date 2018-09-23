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
    class BO_DatPhong
    { 
       public int DatPhong(DTO_HoaDon thongtin)
        {
            int result = -1;
            string sql = "INSERT INTO HoaDon VALUES(@MaHD,@MaChiNhanh,@MaPhong,@SDT,@NgayDat,@NgayTra,@MaDV,DATEDIFF(day,'@NgayDat','@NgayTra'),400000*DATEDIFF(day,'@NgayDat','@NgayTra'))";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter ("@MaHD",thongtin.MaHD),
                new SqlParameter("@MaChiNhanh",thongtin.MaChiNhanh),
                new SqlParameter("@MaPhong",thongtin.MaPhong),
                new SqlParameter("@SDT",thongtin.SoDienThoai),
                new SqlParameter("@NgayDat",thongtin.NgayDatPhong),
                new SqlParameter("@NgayTra",thongtin.NgayTraPhong),
                new SqlParameter("@MaDV",thongtin.MaDV),
            };
            DataAccess data = new DataAccess();
            result = data.Execute(sql, para);
            return result;

        }
        public int Huy( DTO_HoaDon hoadon)
        {
            int result = -1;
            string sql = @"DELETE FROM HoaDon WHERE MaHD = @MaHD";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MaHD",hoadon.MaHD),
            };
            DataAccess data = new DataAccess();
            result = data.Execute(sql, para);
            return result;
        }
        public int SuDungPhong( DTO_Phong phong)
        {
            int result = -1;
            string sql = @"UPDATE Phong SET NguoiSuDung = @SDT WHERE MaPhong = @MaPhong";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter ("@SDT",phong.SDT),

            };
            DataAccess data = new DataAccess();
            result = data.Execute(sql, para);
            return result;

        }

    }

    
}
