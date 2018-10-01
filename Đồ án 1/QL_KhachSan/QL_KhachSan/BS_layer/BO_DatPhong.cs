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
       public DataSet KiemTraPhongTrong (DTO_HoaDon MaChiNhanh, ref string GiaTriMaPhong)
        {
            DataSet result = new DataSet();
            string sql = "SELECT TOP 1 (MaPhong) FROM Phong WHERE MaChiNhanh LIKE @MaChiNhanh + '%' AND NguoiSuDung = 'Free'";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter ("@MaChiNhanh",MaChiNhanh.MaChiNhanh),
            };
            DataAccess data = new DataAccess();
            result = data.getdataset(sql, para);
            if(result.Tables.Count >0 && result.Tables[0].Rows.Count > 0)
            {
                GiaTriMaPhong = result.Tables[0].Rows[0][0].ToString();
            }
            return result;
        }
       public int DatPhong(DTO_HoaDon thongtin)
        {
            int result = -1;
            string sql = "INSERT INTO HoaDon VALUES(@MaHD,@STT,@MaChiNhanh,@MaPhong,@SDT,@NgayDat,@NgayTra,@MaDV,@SoLuong,@ThanhTien)";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter ("@MaHD",thongtin.MaHD),
                new SqlParameter ("@STT",thongtin.STT),
                new SqlParameter("@MaChiNhanh",thongtin.MaChiNhanh),
                new SqlParameter("@MaPhong",thongtin.MaPhong),
                new SqlParameter("@SDT",thongtin.SoDienThoai),
                new SqlParameter("@NgayDat",thongtin.NgayDatPhong),
                new SqlParameter("@NgayTra",thongtin.NgayTraPhong),
                new SqlParameter("@MaDV",thongtin.MaDV),
                new SqlParameter("@SoLuong",thongtin.SoLuong),
                new SqlParameter("@ThanhTien",thongtin.ThanhTien),
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
            string sql = @"UPDATE Phong SET NguoiSuDung = @SDT WHERE MaPhong = @MaPhong AND MaChiNhanh = @MaChiNhanh";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter ("@SDT",phong.SDT),
                new SqlParameter("@MaPhong",phong.MaPhong),
                new SqlParameter ("@MaChiNhanh",phong.MaChiNhanh),

            };
            DataAccess data = new DataAccess();
            result = data.Execute(sql, para);
            return result;

        }
        public DataSet KiemTraMaHD(DTO_HoaDon hoadon)
        {
            DataSet result = new DataSet();
            string sql = "SELECT TOP 1 (MaHD) FROM HoaDon WHERE MaHD LIKE @MaHD + '%' ORDER BY MaHD DESC ";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MaHD",hoadon.MaHD),
            };
            DataAccess data = new DataAccess();
            result = data.getdataset(sql, para);
            return result;
        }

    }

    
}
