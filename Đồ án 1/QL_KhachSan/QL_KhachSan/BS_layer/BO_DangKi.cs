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
    class BO_DangKi
    {
        public int DangKi(DTO_KhachHang dto)
        {
            int result = -1;
            string sql = @"IF EXISTS (SELECT * FROM dbo.KhachHang WHERE SoDienThoai=@SDT AND MatKhau='')
                      UPDATE dbo.KhachHang SET MatKhau=@MatKhau, TenKhachHang=@TenKH, CMND=@CMND, CauHoiBaoMat=@CauHoiBaoMat, TraLoi=@TraLoi WHERE SoDienThoai=@SDT
                             ELSE  INSERT INTO KhachHang VALUES (@SDT,@TenKH,@TichLuy,@MatKhau,@CMND,@CauHoiBaoMat,@TraLoi)";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@SDT",dto.SDT),
                new SqlParameter("@TenKH",dto.TenKH),
                new SqlParameter("@TichLuy",dto.TichLuy),
                new SqlParameter("@MatKhau",dto.MatKhau),
                new SqlParameter("@CMND",dto.CMND),
                new SqlParameter("@CauHoiBaoMat",dto.CauHoiBiMat),
                new SqlParameter("@TraLoi",dto.TraLoi),
            };
            DataAccess data = new DataAccess();
            result = data.Execute(sql, para);
            return result;
        }
    }
}
