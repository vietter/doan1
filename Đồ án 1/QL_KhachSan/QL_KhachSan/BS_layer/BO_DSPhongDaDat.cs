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
            string sql = "SELECT ThanhTien FROM HoaDon WHERE SoDienThoai = @SDT AND DapUng != 'Done'";
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
            string sql = "SELECT MaHD FROM HoaDon WHERE SoDienThoai = @SDT AND MaPhong = @MaPhong AND MaChiNhanh = @MaChiNhanh";
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
        public DataSet DSPhong(DTO_Phong phong)
        {
            DataSet result = new DataSet();
            string sql = "SELECT * FROM Phong WHERE NguoiSuDung = @SDT";
            SqlParameter[] para = new SqlParameter[]  
            {
                new SqlParameter ("@SDT",phong.SDT),
            };
            DataAccess data = new DataAccess();
            result = data.getdataset(sql, para);
            return result;
        }

    }
}
