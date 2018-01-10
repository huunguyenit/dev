using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmManage.DTO
{
    class MonHoc_DTO
    {
        private string _MaMH;

        public string MaMH
        {
            get { return _MaMH; }
            set { _MaMH = value; }
        }
        private string _TenMH;

        public string TenMH
        {
            get { return _TenMH; }
            set { _TenMH = value; }
        }

        public GiaoVien_Day_MH_DTO _GiaoVien_Day_MH_DTO { get; set; }
        public GiaoVien_DTO _GiaoVien_DTO { get; set; }
    }
}
