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
       public DataSet KiemTraPhongTrong (DTO_Phong phong)
        {
            DataSet result = new DataSet();
            string sql = "SELECT * FROM Phong WHERE MaChiNhanh LIKE @MaChiNhanh + '%' AND NguoiSuDung = 'Free' AND SoNguoi = @SoNguoi AND LoaiPhong = @LoaiPhong";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter ("@MaChiNhanh",phong.MaChiNhanh),
                new SqlParameter("@SoNguoi",phong.SoNguoi),
                new SqlParameter("@LoaiPhong",phong.LoaiPhong),
            };
            DataAccess data = new DataAccess();
            result = data.getdataset(sql, para);
            return result;
        }
        public DataSet showall(DTO_Phong phong)
        {
            DataSet result;
            string sql = "SELECT * FROM Phong WHERE MaChiNhanh LIKE @MaChiNhanh + '%' AND NguoiSuDung = @SDT";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MaChiNhanh",phong.MaChiNhanh),
                new SqlParameter("@SDT",phong.SDT),
            };
            DataAccess data = new DataAccess();
            result = data.getdataset(sql, para);
            return result;
        }
       public int DatPhong(DTO_HoaDon thongtin)
        {
            int result = -1;
            string sql = "INSERT INTO HoaDon VALUES(@TenDichVu,@SoLuong,@ThanhTien,@MaHD,@STT,@MaChiNhanh,@MaPhong,@SDT,@NgayDat,@NgayTra,@MaDV,@DapUng)";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@TenDichVu",thongtin.TenDichVu),
                new SqlParameter("@SoLuong",thongtin.SoLuong),
                new SqlParameter("@ThanhTien",thongtin.ThanhTien),
                new SqlParameter ("@MaHD",thongtin.MaHD),
                new SqlParameter ("@STT",thongtin.STT),
                new SqlParameter("@MaChiNhanh",thongtin.MaChiNhanh),
                new SqlParameter("@MaPhong",thongtin.MaPhong),
                new SqlParameter("@SDT",thongtin.SoDienThoai),
                new SqlParameter("@NgayDat",thongtin.NgayDatPhong),
                new SqlParameter("@NgayTra",thongtin.NgayTraPhong),
                new SqlParameter("@MaDV",thongtin.MaDV),
                new SqlParameter("@DapUng",thongtin.DapUng),
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
