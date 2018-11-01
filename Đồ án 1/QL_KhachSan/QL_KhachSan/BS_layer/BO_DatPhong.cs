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
        public DataSet kiemtratronghoadon(DTO_HoaDon dto)
        {
            DataSet result = new DataSet();
            string sql = "SELECT * FROM HoaDon WHERE MaPhong = @MaPhong AND MaChiNhanh =@MaChiNhanh AND TenDichVu LIKE 'Thuê Phòng%' AND DapUng != 'Done'";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MaPhong",dto.MaPhong),
                new SqlParameter("@MaChiNhanh",dto.MaChiNhanh),
            };
            DataAccess data = new DataAccess();
            result = data.getdataset(sql, para);
            return result;
        }
       public DataSet ChonPhong (DTO_HoaDon dto)
        {
            DataSet result = new DataSet();
            string sql = "SELECT * FROM Phong WHERE LoaiPhong = @LoaiPhong AND SoNguoi = @SoNguoi AND MaChiNhanh LIKE @MaChiNhanh +'%'";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@LoaiPhong",dto.LoaiPhong),
                new SqlParameter("@MaChiNhanh",dto.MaChiNhanh),
                new SqlParameter("@SoNguoi",dto.SoNguoi),
            };
            DataAccess data = new DataAccess();
            result = data.getdataset(sql, para);
            return result;
        }
        public DataSet KiemTraNgayPhongDangDuocSuDung(DTO_HoaDon dto)
        {
            DataSet result = new DataSet();
            string sql = "SELECT * FROM HoaDon WHERE MaPhong = @MaPhong AND MaChiNhanh = @MaChiNhanh AND TenDichVu LIKE 'Thuê Phòng%' AND DapUng != 'Done'";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MaPhong",dto.MaPhong),
                new SqlParameter("@MaChiNhanh",dto.MaChiNhanh),
            };
            DataAccess data = new DataAccess();
            result = data.getdataset(sql, para);
            return result;
        }
        public DataSet showall(DTO_HoaDon phong)
        {
            DataSet result;
            string sql = "SELECT * FROM Phong WHERE  MaChiNhanh LIKE @MaChiNhanh +'%'";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MaChiNhanh",phong.MaChiNhanh),
               
            };
            DataAccess data = new DataAccess();
            result = data.getdataset(sql, para);
            return result;
        }
       public int DatPhong(DTO_HoaDon thongtin)
        {
            int result = -1;
            string sql = "INSERT INTO HoaDon VALUES(@TenDichVu,@SoLuong,@ThanhTien,@MaHD,@STT,@MaChiNhanh,@MaPhong,@SDT,@NgayDat,@NgayTra,@MaDV,@DapUng,@DatCoc,@ThoiGianThucHienHoaDon)";
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
                new SqlParameter("@DatCoc",thongtin.DatCoc),
                new SqlParameter("ThoiGianThucHienHoaDon",thongtin.ThoiGianThucHienHoaDon),
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
