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
    class BO_DSPhongDaDat
    {
        public DataSet TongTien(DTO_HoaDon hoadon)
        {
            DataSet result = new DataSet();
            string sql = "SELECT ThanhTien FROM HoaDon WHERE SoDienThoai = @SDT AND DapUng != 'Done' AND DatCoc = 'Yes'";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@SDT",hoadon.SoDienThoai),
            };
            DataAccess data = new DataAccess();
            result = data.getdataset(sql, para);
            return result;
        }
        public DataSet LayMaHD(DTO_HoaDon hoadon)
        {
            DataSet result = new DataSet();
            string sql = "SELECT MaHD FROM HoaDon WHERE SoDienThoai = @SDT AND MaPhong = @MaPhong AND MaChiNhanh = @MaChiNhanh AND DapUng != 'Done' ";
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
        public DataSet HienThiPhong(DTO_Phong phong)
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
        public DataSet DSPhong(DTO_HoaDon phong)
        {
            DataSet result = new DataSet();
            string sql = "SELECT * FROM HoaDon WHERE SoDienThoai =@SDT AND DatCoc ='Yes' AND DapUng != 'Done' AND TenDichVu LIKE 'Thuê Phòng%'";
            SqlParameter[] para = new SqlParameter[]  
            {
                new SqlParameter ("@SDT",phong.SoDienThoai),
                
            };
            DataAccess data = new DataAccess();
            result = data.getdataset(sql, para);
            return result;
        }

    }
}
