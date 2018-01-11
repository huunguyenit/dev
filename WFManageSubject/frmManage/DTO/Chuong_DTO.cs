using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmManage.DTO
{
    class Chuong_DTO
    {
        private string _MaChuong;

        public string MaChuong
        {
            get { return _MaChuong; }
            set { _MaChuong = value; }
        }

        private string _TenChuong;

        public string TenChuong
        {
            get { return _TenChuong; }
            set { _TenChuong = value; }
        }

        private string _MaMH_Chuong;

        public string MaMH_Chuong
        {
            get { return _MaMH_Chuong; }
            set { _MaMH_Chuong = value; }
        }

        private int _QuanTrong;

        public int QuanTrong
        {
            get { return _QuanTrong; }
            set { _QuanTrong = value; }
        }
    }
}
