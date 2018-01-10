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
    }
}
