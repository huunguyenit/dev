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
    class TaiLieu_BLL
    {
        ConnectDB connData = new ConnectDB();
        //Lấy tất cả danh sách Tài liệu để hiển thị
        public DataTable GetListDocument()
        {
            string sql = "select TenTL, MaChuong_TL, (Case QuanTrong when 'true' then N'Đúng' else 'Sai' end)as QuanTrong from TaiLieu";
            return connData.GetData(sql);
        }
        //Kiểm tra trước khi lưu
        public bool CheckBeforeSave(TaiLieu_DTO taiLieu_DTO)
        {
            if (taiLieu_DTO.TenTL.Equals(""))
            {
                MessageBox.Show("Tên tài liệu không hợp lệ!");
                return false;
            }
            return true;
        }
        //Thêm tài liệu trong CSDL
        public bool AddDocument(TaiLieu_DTO taiLieu_DTO)
        {
            if (CheckBeforeSave(taiLieu_DTO))
            {
                string sql = string.Format("insert into TaiLieu (TenTL, MaChuong_TL, QuanTrong)" + "values (N'{0}','{1}',{2})", taiLieu_DTO.TenTL, taiLieu_DTO.MaChuong_TL, taiLieu_DTO.QuanTrong);
                if (connData.RunSQL(sql))
                {
                    MessageBox.Show("Thêm thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }
        //Sửa chương trong CSDL
        public bool EditDocument(TaiLieu_DTO taiLieu_DTO)
        {
            if (CheckBeforeSave(taiLieu_DTO))
            {
                string sql = string.Format("update TaiLieu set TenTL = N'{1}',QuanTrong={2} where MaChuong_TL = '{0}'", taiLieu_DTO.MaChuong_TL, taiLieu_DTO.TenTL, taiLieu_DTO.QuanTrong);
                if (connData.RunSQL(sql))
                {
                    MessageBox.Show("Sửa thông tin Tài liệu thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }
        //Xoá chương trong CSDL
        public bool DelDocument(TaiLieu_DTO taiLieu_DTO)
        {
            string sql = string.Format("delete from TaiLieu where TenTL = N'{0}'", taiLieu_DTO.TenTL);
            if (connData.RunSQL(sql))
            {
                MessageBox.Show("Xoá thông tin tài liệu thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
    }
}
