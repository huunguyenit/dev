using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmManage.DTO
{
    class BaiTap_KiemTra_DTO
    {
        private string _MaBT_KT;

        public string MaBT_KT
        {
            get { return _MaBT_KT; }
            set { _MaBT_KT = value; }
        }

        private string _TenBT_KT;

        public string TenBT_KT
        {
            get { return _TenBT_KT; }
            set { _TenBT_KT = value; }
        }

        private string _MaChuong_BK;

        public string MaChuong_BK
        {
            get { return _MaChuong_BK; }
            set { _MaChuong_BK = value; }
        }

        private int _DiemBT_KT;

        public int DiemBT_KT
        {
            get { return _DiemBT_KT; }
            set { _DiemBT_KT = value; }
        }

        private string _MaMH_BK;

        public string MaMH_BK
        {
            get { return _MaMH_BK; }
            set { _MaMH_BK = value; }
        }

        private string _MaHS_BK;

        public string MaHS_BK
        {
            get { return _MaHS_BK; }
            set { _MaHS_BK = value; }
        }

        private string _MaNhom_BK;

        public string MaNhom_BK
        {
            get { return _MaNhom_BK; }
            set { _MaNhom_BK = value; }
        }

        private int _BaiNhom;

        public int BaiNhom
        {
            get { return _BaiNhom; }
            set { _BaiNhom = value; }
        }

        private int _BaiTap;

        public int BaiTap
        {
            get { return _BaiTap; }
            set { _BaiTap = value; }
        }
    }
}
