using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmManage.DTO
{
    class TaiLieu_DTO
    {
        private string _TenTL;

        public string TenTL
        {
            get { return _TenTL; }
            set { _TenTL = value; }
        }

        private string _MaChuong_TL;

        public string MaChuong_TL
        {
            get { return _MaChuong_TL; }
            set { _MaChuong_TL = value; }
        }

        private int _QuanTrong;

        public int QuanTrong
        {
            get { return _QuanTrong; }
            set { _QuanTrong = value; }
        }

        public Chuong_DTO _Chuong_DTO { get; set; }
    }
}
