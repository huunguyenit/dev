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
    class HocSinh_Thi_MonHoc_BLL
    {
        ConnectDB connData = new ConnectDB();

        public DataTable GetStudentTestSubjectLoad(string MaHS, string MaMH)
        {
            string sql = "SELECT DIEMTHI FROM HocSinh_Thi_MonHoc HST, MonHoc MH, HocSinh HS WHERE MH.MaMH = HST.MaMH AND HS.MaHS = HST.MaHS AND HS.MaHS = '"+MaHS+"'"+"AND MH.MaMH = '"+MaMH+"'";
            return connData.GetData(sql);
        }

        public DataTable GetListTestSubject()
        {
            string sql = "select * from HocSinh_Thi_MonHoc";
            return connData.GetData(sql);
        }

        public bool CheckBeforeSave(HocSinh_Thi_Monhoc_DTO hocSinh_Thi_Monhoc)
        {
            if(hocSinh_Thi_Monhoc.DiemThi>10||hocSinh_Thi_Monhoc.DiemThi<0)
            {
                MessageBox.Show("Điểm không hợp lệ!");
                return false;
            }
            if(hocSinh_Thi_Monhoc.DiemThi.Equals(""))
            {
                MessageBox.Show("Điểm thi không được để trống!");
                return false;
            }
            return true;
        }
        public bool AddTestSubject(HocSinh_Thi_Monhoc_DTO hocSinh_Thi_Monhoc)
        {
            string sql = string.Format("Insert into HocSinh_Thi_MonHoc (MaMH, MaHS, DiemThi) values ('{0}','{1}','{2}')", hocSinh_Thi_Monhoc.MaMH, hocSinh_Thi_Monhoc.MaHS, hocSinh_Thi_Monhoc.DiemThi);
            if(connData.RunSQL(sql))
            {
                MessageBox.Show("Thêm bài thi thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        public bool EditTestSubject(HocSinh_Thi_Monhoc_DTO hocSinh_Thi_Monhoc)
        {
            string sql = string.Format("Update HocSinh_Thi_MonHoc set DiemThi={2} where MaHS = '{0}' and MaMH = '{1}' ", hocSinh_Thi_Monhoc.MaHS, hocSinh_Thi_Monhoc.MaMH, hocSinh_Thi_Monhoc.DiemThi);
            if(connData.RunSQL(sql))
            {
                MessageBox.Show("Sửa bài thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        public bool DelTestSubject(HocSinh_Thi_Monhoc_DTO hocSinh_Thi_Monhoc)
        {
            string sql = string.Format("Delete from HocSinh_Thi_MonHoc where MaHS ='" + hocSinh_Thi_Monhoc.MaHS + "'" + "MaMH='" + hocSinh_Thi_Monhoc.MaMH + "'");
            if(connData.RunSQL(sql))
            {
                MessageBox.Show("Xoá bài thi thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }
    }
}
