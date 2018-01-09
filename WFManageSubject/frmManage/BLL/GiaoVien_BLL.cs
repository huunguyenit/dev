using frmManage.DAL;
using frmManage.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmManage.BLL
{
    class GiaoVien_BLL
    {
        ConnectDB connData = new ConnectDB();

        //Hàm lấy tất cả danh sách Nhân Viên để hiển thị
        public DataTable GetListGiaoVien()
        {
            string sql = "SELECT  MaGV, TenGV, (CASE GioiTinh WHEN 'true' THEN N'Nam' ELSE N'Nữ' END) AS GioiTinh, NgaySinh, SDT, DiaChi, Email, MatKhau, (CASE Admin WHEN 'true' THEN N'Admin' ELSE N'User' END) AS Admin FROM GIAOVIEN";
            return connData.GetData(sql);
        }

        //Lấy thông tin Nhân Viên cho Đăng nhập
        public GiaoVien_DTO GetInfoLogin(string MaGV)
        {
            string sql = "SELECT MaGV, MatKhau, Admin FROM GIAOVIEN WHERE MaGV='" + MaGV + "'";
            DataTable tbUser = connData.GetData(sql);
            GiaoVien_DTO user = new GiaoVien_DTO();
            if (tbUser.Rows.Count > 0)
            {
                DataRow rowUser = tbUser.Rows[0];
                user.MaGV = rowUser["MaGV"].ToString();
                user.MatKhau = rowUser["MatKhau"].ToString();
                user.Admin = (rowUser["Admin"].ToString() == "True") ? 1 : 0;
            }
            else
            {
                user.MaGV = "";
                user.MatKhau = "";
                user.Admin = 0;
            }
            return user;
        }

        //Đổi mật khẩu
        public bool ChangePassWord(string matkhau)
        {
            string sql = "UPDATE GIAOVIEN SET MatKhau='" + matkhau + "' WHERE MaGV='" + Utilities.user.MaGV + "'";
            if (connData.RunSQL(sql))
                return true;
            return false;
        }

        //Lấy Mã dg kế tiếp
        public string NextID()
        {
            return Utilities.NextID(connData.GetLastID("GIAOVIEN", "MaGV"), "GV");
        }
    }
}
