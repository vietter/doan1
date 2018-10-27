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
    class BO_QuanLiChiNhanh
    {
        public DataSet HienThiDSPhongDaDatCuaKhachHang(DTO_Phong phong)
        {
            DataSet result = new DataSet();
            string sql = "SELECT * FROM Phong WHERE MaChiNhanh = @MaChiNhanh AND NguoiSuDung != 'Free' ";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MaChiNhanh",phong.MaChiNhanh),
            };
            DataAccess data = new DataAccess();
            result = data.getdataset(sql, para);
            return result;
        }
        public int SetHoaDon(DTO_HoaDon dto)
        {

            int result = -1;
            string sql = "UPDATE HoaDon SET DapUng = 'Done' WHERE MaHD = @MaHD";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MaHD",dto.MaHD),
            };
            DataAccess data = new DataAccess();
            result = data.Execute(sql, para);
            return result;
        }
       public DataSet HienThiYeuCau (DTO_HoaDon dto)
        {
            DataSet result = new DataSet();
            string sql = "SELECT * FROM HoaDon WHERE MaChiNhanh = @MaChiNhanh AND DapUng = 'No'";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MaChiNhanh",dto.MaChiNhanh),

            };
            DataAccess data = new DataAccess();
            result = data.getdataset(sql, para);
            return result;
        }
        public DataSet LayTenPhong(DTO_Phong phong )
        {
            DataSet result = new DataSet();
            string sql = "SELECT * FROM Phong WHERE MaPhong = @MaPhong AND MaChiNhanh = @MaChiNhanh";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MaPhong",phong.MaPhong),
                new SqlParameter("@MaChiNhanh",phong.MaChiNhanh),
            };
            DataAccess data = new DataAccess();
            result = data.getdataset(sql, para);
            return result;
        }
        public int ThucHienYeuCau(DTO_HoaDon dto)
        {
            int result = -1;
            string sql = "UPDATE HoaDon SET DapUng = 'Yes' WHERE MaHD = @MaHD AND MaPhong = @MaPhong AND MaChiNhanh = @MaChiNhanh AND STT = @STT";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MaPhong",dto.MaPhong),
                new SqlParameter("@MaChiNhanh",dto.MaChiNhanh),
                new SqlParameter("@STT",dto.STT),
                new SqlParameter("@MaHD",dto.MaHD),
            };
            DataAccess data = new DataAccess();
            result = data.Execute(sql, para);
            return result;
        }
        public int XoaYeuCau(DTO_HoaDon hoadon)
        {
            int result = -1;
            string sql = "DELETE FROM HoaDon WHERE MaHD = @MaHD AND MaPhong = @MaPhong AND MaChiNhanh = @MaChiNhanh AND STT = @STT";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MaHD",hoadon.MaHD),
                new SqlParameter("@MaChiNhanh",hoadon.MaChiNhanh),
                new SqlParameter("@MaPhong",hoadon.MaPhong),
                new SqlParameter("@STT",hoadon.STT),
            };
            DataAccess data = new DataAccess();
            result = data.Execute(sql, para);
            return result;
        }
        public int TichLuyDiem(DTO_HoaDon hoadon)
        {
            int result = -1;
            string sql = "UPDATE KhachHang SET TichLuy = @Tong WHERE SoDienThoai = @SDT";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@Tong",hoadon.ThanhTien/1000),
                new SqlParameter("@SDT",hoadon.SoDienThoai),
            };
            DataAccess data = new DataAccess();
            result = data.Execute(sql, para);
            return result;
        }
    }
}