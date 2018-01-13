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
    class BaiTap_KiemTra_BLL
    {
        ConnectDB connData = new ConnectDB();

        public DataTable GetListTestChapter()
        {
            string sql = "select MaBT_KT,TenBT_KT,MaChuong_BK,DiemBT_KT,MaMH_BK,MaHS_BK,MaNhom_BK, (CASE BaiTap WHEN 'true' THEN N'Bài tập' ELSE N'Bài kiểm tra' END) AS BaiTap, (CASE BaiNhom WHEN 'true' THEN N'Nhóm' ELSE N'Cá nhân' END) AS BaiNhom from BaiTap_KiemTra";
            return connData.GetData(sql);
        }
        //Thong ke
        //Bai tap, bai kiem tra
        public string CountTest()
        {
            string sql = "select count(*) from BaiTap_KiemTra bk where bk.BaiTap=0";
            return connData.CountData(sql);
        }

        public string CountExercise()
        {
            string sql = "select count(*) from BaiTap_KiemTra bk where bk.BaiTap=1";
            return connData.CountData(sql);
        }
        //Nhom, ca nhan
        public string CountGroup()
        {
            string sql = "select count(*) from BaiTap_KiemTra bk where bk.BaiNhom=1";
            return connData.CountData(sql);
        }
        public string CountStudent()
        {
            string sql = "select count(*) from BaiTap_KiemTra bk where bk.BaiNhom=0";
            return connData.CountData(sql);
        }
        public bool CheckBeforeSave(BaiTap_KiemTra_DTO baiTap_KiemTra)
        {
            if (baiTap_KiemTra.TenBT_KT.Equals(""))
            {
                MessageBox.Show("Tên bài không hợp lệ ! ");
                return false;
            }
            if(baiTap_KiemTra.DiemBT_KT.Equals(""))
            {
                MessageBox.Show("Điểm không được để trống!");
                return false;
            }
            if(baiTap_KiemTra.DiemBT_KT>10||baiTap_KiemTra.DiemBT_KT<0)
            {
                MessageBox.Show("Điểm không hợp lệ! ");
                return false;
            }
            if(baiTap_KiemTra.MaHS_BK.Equals(""))
            {
                MessageBox.Show("Tên học sinh không được để trống!");
                return false;
            }
            return true;
        }

        public bool AddTest_Chapter(BaiTap_KiemTra_DTO baiTap_KiemTra)
        {
            if (CheckBeforeSave(baiTap_KiemTra))
            {
                string sql = string.Format("INSERT INTO BaiTap_KiemTra (MaBT_KT, TenBT_KT, MaChuong_BK, DiemBT_KT, MaMH_BK, MaHS_BK, MaNhom_BK, BaiNhom, BaiTap) VALUES ('{0}',N'{1}','{2}','{3}','{4}','{5}',{6},{7},{8})", baiTap_KiemTra.MaBT_KT, baiTap_KiemTra.TenBT_KT, baiTap_KiemTra.MaChuong_BK, baiTap_KiemTra.DiemBT_KT, baiTap_KiemTra.MaMH_BK, baiTap_KiemTra.MaHS_BK, baiTap_KiemTra.MaNhom_BK, baiTap_KiemTra.BaiNhom, baiTap_KiemTra.BaiTap);
                if (connData.RunSQL(sql))
                {
                    MessageBox.Show("Thêm bài thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        public bool EditTest_Chapter(BaiTap_KiemTra_DTO baiTap_KiemTra)
        {
            if (CheckBeforeSave(baiTap_KiemTra))
            {
                string sql = string.Format("UPDATE BaiTap_KiemTra SET TenBT_KT =N'{1}' ,MaChuong_BK = '{2}',DiemBT_KT= '{3}',MaMH_BK ='{4}',MaHS_BK='{5}',MaNhom_BK={6},BaiNhom={7},BaiTap={8} WHERE MaBT_KT='{0}' ",baiTap_KiemTra.MaBT_KT,baiTap_KiemTra.TenBT_KT,baiTap_KiemTra.MaChuong_BK,baiTap_KiemTra.DiemBT_KT,baiTap_KiemTra.MaMH_BK,baiTap_KiemTra.MaHS_BK,baiTap_KiemTra.MaNhom_BK,baiTap_KiemTra.BaiNhom,baiTap_KiemTra.BaiTap);
                if (connData.RunSQL(sql))
                {
                    MessageBox.Show("Sửa thông tin bài thành công !", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }


        public bool DelTest_Chapter(BaiTap_KiemTra_DTO baiTap_KiemTra)
        {
            string sql = string.Format("DELETE FROM BaiTap_KiemTra WHERE MaBT_KT='" + baiTap_KiemTra.MaBT_KT + "'");
            if (connData.RunSQL(sql))
            {
                MessageBox.Show("Xóa thông tin Sách thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        public DataTable SearchTest_Chapter(string DieuKien, string TieuChi)
        {
            string sql = "select * from BaiTap_KiemTra where " + DieuKien + " like N'%" + TieuChi + "%'";
            return connData.GetData(sql);
        }

        public string NextID()
        {
            return Utilities.NextID(connData.GetLastID("BaiTap_KiemTra", "MaBT_KT"), "BK");
        }
    }
}
