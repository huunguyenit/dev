using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frmManage.DAL;
using frmManage.DTO;

namespace frmManage.BLL
{
    class Chuong_BLL
    {
        ConnectDB connData = new ConnectDB();

        //Lấy tất cả danh sách Chương để hiển thị
        public DataTable GetListChapter()
        {
            string sql = "select MaChuong, TenChuong, MaMH_Chuong, (Case QuanTrong when 'true' then N'Đúng' else 'Sai' end)as QuanTrong from Chuong";
            return connData.GetData(sql);
        }

        public DataTable GetChapterLoad()
        {
            string sql = "select MaChuong, TenChuong from Chuong";
            return connData.GetData(sql);
        }

        public DataTable GetListChapterRP(Chuong_DTO chuong)
        {
            string sql = "select MaChuong, TenChuong, (case QuanTrong when 'true' then N'Đúng' else 'Sai' end) as QuanTrong from Chuong where MaMH_Chuong = '" + chuong.MaMH_Chuong + "'";
            return connData.GetData(sql);
        }
        //Kiểm tra trước khi lưu
        public bool CheckBeforeSave(Chuong_DTO chuong_DTO)
        {
            if(chuong_DTO.TenChuong.Equals(""))
            {
                MessageBox.Show("Tên Chương không hợp lệ!");
                return false;
            }
            return true;
        }
        //Thêm chương trong CSDL
        public bool AddChapter(Chuong_DTO chuong_DTO)
        {
            if(CheckBeforeSave(chuong_DTO))
            {
                string sql = string.Format("insert into Chuong (MaChuong, TenChuong, MaMH_Chuong, QuanTrong)" + "values ('{0}',N'{1}','{2}',{3})", chuong_DTO.MaChuong, chuong_DTO.TenChuong, chuong_DTO.MaMH_Chuong, chuong_DTO.QuanTrong);
                if(connData.RunSQL(sql))
                {
                    MessageBox.Show("Thêm thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }
        //Sửa chương trong CSDL
        public bool EditChapter(Chuong_DTO chuong_DTO)
        {
            if(CheckBeforeSave(chuong_DTO))
            {
                string sql = string.Format("update Chuong set TenChuong = N'{1}',QuanTrong={2} where MaChuong = '{0}'", chuong_DTO.MaChuong, chuong_DTO.TenChuong, chuong_DTO.QuanTrong);
                if(connData.RunSQL(sql))
                {
                    MessageBox.Show("Sửa thông tin Chương thành công! ", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }
        //Xoá chương trong CSDL
        public bool DelChapter(Chuong_DTO chuong_DTO)
        {
            string sql = string.Format("delete from Chuong where MaChuong = '{0}'",chuong_DTO.MaChuong);
            if(connData.RunSQL(sql))
            {
                MessageBox.Show("Xoá thông tin Chương thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        //Tìm kiếm chương trong CSDL
        public DataTable SearchChapter(string DieuKien, string TieuChi)
        {
            string sql;
            if (DieuKien != "QuanTrong")
            {
                sql = "Select MaChuong, TenChuong, MaMH_Chuong, (CASE QuanTrong when 'true' then N'Đúng' else N'Sai' end)as QuanTrong from Chuong where " + DieuKien + " like N'%" + TieuChi + "%'";
            }
            else
            {
                int trueorfalse = 0;
                if (TieuChi == "true")
                {
                    trueorfalse = 1;
                }
                sql = "Select MaChuong, TenChuong, MaMH_Chuong, (CASE QuanTrong when 'true' then N'Đúng' else N'Sai' end) as QuanTrong from Chuong where QuanTrong = " + trueorfalse;
            }
            return connData.GetData(sql);
        }
        //Lấy mã Chương tiếp theo
        public string NextID()
        {
            return Utilities.NextID(connData.GetLastID("Chuong", "MaChuong"), "CH");
        }
    }
}
